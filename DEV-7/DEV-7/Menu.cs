using System;
using System.Collections.Generic;

namespace DEVTask7
{
    /// <summary>
    /// Class menu for communicate with user
    /// </summary>
    class Menu
    {
        private ProductBuilder productBuilder = null;
        public ICommand<List<Product>> GetSuitableCars { get; set; }
        public ICommand<bool> AddCarToStorage { get; set; }
        public ICommand<bool> DeleteCarFromStorage { get; set; }
        public ICommand<bool> IsAvailableProductGetter { get; set; }

        /// <summary>
        /// Method which starts endless cycle for communicating with user 
        /// </summary>
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Input product options.");
                string brandName = GetBrandName();
                productBuilder = GetProductBuilder(brandName);
                Product chosenProduct = productBuilder.Create();
                CommunicateWithUser communicate = new CommunicateWithUser(chosenProduct);
                chosenProduct = communicate.SetChosenByUserParamsOfProduct();
                (GetSuitableCars as SuitableProductGetter).SetChosenByUserProduct(chosenProduct);
                List<Product> suitableProducts = GetSuitableCars.Execute();
                OutputSuitableProducts(suitableProducts);
                int chosenProductNumber = GetChoiceNumber(1, suitableProducts.Count);
                chosenProduct = suitableProducts[chosenProductNumber - 1];
                if (chosenProductNumber != 0)
                {
                    (IsAvailableProductGetter as IsAvailableProductChecker).SetChosenByUserProduct(chosenProduct);
                    if (IsAvailableProductGetter.Execute())
                    {
                        (DeleteCarFromStorage as DeleterFromStorage).SetChosenByUserProduct(chosenProduct);
                        Console.WriteLine("User buy product");
                    }
                    else
                    {
                        (AddCarToStorage as ToStorageAdder).SetChosenByUserProduct(chosenProduct);
                        Console.WriteLine("You made request for product, it will be awailable tommorow");
                    }
                }
            }
        }

        private int GetChoiceNumber(int min, int max)
        {
            Console.Write("Input car number of enter to skip: ");
            int response;
            string inputLine;
            while (!int.TryParse(inputLine = Console.ReadLine(), out response) || response < min || response > max)
            {
                if (inputLine == string.Empty)
                {
                    response = 0;
                    break;
                }
                Console.Write("Input right car number;");
            }
            return response;
        }

        private void OutputSuitableProducts(List<Product> suitableProducts)
        {
            int counter = 1;
            foreach (Product product in suitableProducts)
            {
                Console.WriteLine($"{counter}. {product}");
                counter++;
            }
        }

        private string GetBrandName()
        {
            Console.Write("Choose name of brand:\n" +
                "1.Lada\n" +
                "2.Pegueot\n" +
                "3.Bmw\n" +
                "Choose: ");
            string[] brandNames = new string[] { "Lada", "Pegueot", "Bmw" };
            int response;
            while (!int.TryParse(Console.ReadLine(), out response) && response > 3 || response < 1)
            {
                Console.Write("Choose wright brand, please: ");
            }
            return brandNames[response - 1];
        }

        private ProductBuilder GetProductBuilder(string paramBrandName)
        {
            if (paramBrandName == "Lada")
            {
                return new LadaBuilder();
            }
            else if (paramBrandName == "Bmw")
            {
                return new BmwBuilder();
            }
            else if (paramBrandName == "Lada")
            {
                return new PegueotBuilder();
            }
            return null;
        }
    }
}

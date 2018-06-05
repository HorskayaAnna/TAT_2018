using System;

namespace DEVTask7
{
    /// <summary>
    /// Class to communicate with user
    /// </summary>
    class CommunicateWithUser
    {
        private Product product;

        public CommunicateWithUser(Product chosenProduct)
        {
            product = chosenProduct;
        }

        /// <summary>
        /// This method asks user to input attributes
        /// </summary>
        /// <returns>
        /// Product with filed attributes
        /// </returns>
        public Product SetChosenByUserParamsOfProduct()
        {
            Console.WriteLine("Choose suitable options for product, please. \n" +
                "To skip input empty line.");
            SetModel();
            SetBodyType();
            SetTransmissionType();
            SetEngineType();
            SetVolume();
            SetPower();
            SetClimateControl();
            SetSalonType();
            return product;
        }

        void SetModel()
        {
            Console.Write("Input suitable Model, please: ");
            product.Model = Console.ReadLine();
        }

        void SetBodyType()
        {
            Console.Write("Input suitable body type, please: ");
            product.BodyType = Console.ReadLine();
        }

        void SetTransmissionType()
        {
            Console.Write("Input suitable transmission type, please: ");
            product.TransmissionType = Console.ReadLine();
        }

        void SetEngineType()
        {
            Console.Write("Input suitable engine type, please: ");
            product.EngineType = Console.ReadLine();
        }

        void SetVolume()
        {
            Console.Write("Inout suitable volume, please: ");
            int productVolume;
            string inputLine = string.Empty;
            while (!int.TryParse(inputLine = Console.ReadLine(), out productVolume) || productVolume < 0)
            {
                if (inputLine == string.Empty)
                {
                    productVolume = 0;
                    break;
                }
                Console.Write("Input correct volume, please: ");
            }
            product.Volume = productVolume;
        }

        void SetPower()
        {
            Console.Write("Inout suitable power, please: ");
            int productPower;
            string inputLine = string.Empty;
            while (!int.TryParse(inputLine = Console.ReadLine(), out productPower) || productPower < 0)
            {
                if (inputLine == string.Empty)
                {
                    productPower = 0;
                    break;
                }
                Console.WriteLine("Input correct volume, please: ");
            }
            product.Volume = productPower;
        }

        void SetClimateControl()
        {
            Console.Write("Input suitable climate control, please: ");
            product.ClimateControl = Console.ReadLine();
        }

        void SetSalonType()
        {
            Console.Write("Input suitable salon type, please: ");
            product.SalonType = Console.ReadLine();
        }
    }
}

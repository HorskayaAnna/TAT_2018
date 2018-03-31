using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace DEVTask7
{
    /// <summary>
    /// class storage for storing product and interacting with them 
    /// </summary>
    class Storage
    {
        List<Product> products;

        public Storage()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            { 
                TypeNameHandling = TypeNameHandling.Auto
            };
            Product[] cars = JsonConvert.DeserializeObject<Product[]>(File.ReadAllText(@"storage.json"), settings);
            products = new List<Product>();
            foreach (Product car in cars)
            {
                switch (car.Brand)
                {
                    case "Bmw":
                        BmwBuilder bmwBuilder = new BmwBuilder();
                        Product bmw = bmwBuilder.Create();
                        FillFieldsWithCarAttrs(bmw, car);
                        products.Add(bmw);
                        break;
                    case "Lada":
                        LadaBuilder ladaBuilder = new LadaBuilder();
                        Product lada = ladaBuilder.Create();
                        FillFieldsWithCarAttrs(lada, car);
                        products.Add(lada);
                        break;
                    case "Pegueot":
                        PegueotBuilder pegueotBuilder = new PegueotBuilder();
                        Product pegueot = pegueotBuilder.Create();
                        FillFieldsWithCarAttrs(pegueot, car);
                        products.Add(pegueot);
                        break;
                }
            }
        }

        /// <summary>
        /// Method which checks if the product is in the list or not 
        /// </summary>
        /// <param name="paramProduct">
        /// Product to check
        /// </param>
        /// <returns>
        /// true if contain of false if not
        /// </returns>
        public bool IsAvailableProduct(Product paramProduct)
        {
            return products.Contains(paramProduct);
        }

        /// <summary>
        /// Method, which delete product from storage
        /// </summary>
        /// <param name="paramProduct">
        /// Product to remove
        /// </param>
        public void RemoveProduct(Product paramProduct)
        {
            products.Remove(paramProduct);
        }

        /// <summary>
        /// Method, which add product to the storage
        /// </summary>
        /// <param name="paramProduct">
        /// Product to add
        /// </param>
        public void AddProductToStorage(Product paramProduct)
        {
            products.Add(paramProduct);
        }

        private void FillFieldsWithCarAttrs(Product product, Product carFromJson)
        {
            product.BodyType = carFromJson.BodyType;
            product.Brand = carFromJson.Brand;
            product.ClimateControl = carFromJson.ClimateControl;
            product.EngineType = carFromJson.EngineType;
            product.Model = carFromJson.Model;
            product.Power = carFromJson.Power;
            product.SalonType = carFromJson.SalonType;
            product.TransmissionType = carFromJson.TransmissionType;
            product.Volume = carFromJson.Volume;
        }
    }
}

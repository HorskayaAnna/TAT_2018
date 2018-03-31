using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace DEVTask7
{
    /// <summary>
    /// class catalog for storing product and interacting with them 
    /// </summary>
    class Catalog
    {
        List<Product> products;

        public Catalog()
        {
            products = new List<Product>();
            LoadProductsToCatalog(GetCarsFromJson());
        }

        private Product[] GetCarsFromJson()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            };
            return JsonConvert.DeserializeObject<Product[]>(File.ReadAllText(@"cars.json"), settings);
        }

        private void LoadProductsToCatalog(Product[] cars)
        {
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
        /// This method returns all suitable 
        /// </summary>
        /// <param name="paramProduct">
        /// Product to compare with
        /// </param>
        /// <returns>
        /// List of suitable products
        /// </returns>
        public List<Product> GetSuitableProducts(Product paramProduct)
        {
            List<Product> responseList = new List<Product>();
            foreach (Product product in products)
            {
                if (product.GetType() == paramProduct.GetType() && AreSuitable(paramProduct, product))
                {
                    responseList.Add(product);
                }
            }
            return responseList;
        }

        private bool AreSuitable(Product chosenProduct, Product product)
        {
            bool response = true;
            if (chosenProduct.BodyType != string.Empty && product.BodyType != chosenProduct.BodyType)
            {
                response = false;
            }
            else if (chosenProduct.Brand != string.Empty && product.Brand != chosenProduct.Brand)
            {
                response = false;
            }
            else if (chosenProduct.ClimateControl != string.Empty && product.ClimateControl != chosenProduct.ClimateControl)
            {
                response = false;
            }
            else if (chosenProduct.EngineType != string.Empty && product.EngineType != chosenProduct.EngineType)
            {
                response = false;
            }
            else if (chosenProduct.Model != string.Empty && product.Model != chosenProduct.Model)
            {
                response = false;
            }
            else if (chosenProduct.SalonType != string.Empty && product.SalonType != chosenProduct.SalonType)
            {
                response = false;
            }
            else if (chosenProduct.Power != 0 && product.Power != chosenProduct.Power)
            {
                response = false;
            }
            else if (chosenProduct.Volume != 0 && product.Volume != chosenProduct.Volume)
            {
                response = false;
            }
            return response;
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

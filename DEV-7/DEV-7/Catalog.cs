using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DEVTask7
{
    /// <summary>
    /// class catalog for storing product and interacting with them 
    /// </summary>
    public class Catalog
    {
        List<Product> products;

        public Catalog(string path)
        {
            products = new List<Product>();
            LoadProductsToCatalog(GetCarsFromJson(path));
        }
        public Catalog()
        {
            products = new List<Product>();         
        }

        private Product[] GetCarsFromJson(string path)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            };
            return JsonConvert.DeserializeObject<Product[]>(File.ReadAllText(path), settings);
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
            List<Product> response = new List<Product>();
            if (paramProduct.BodyType != string.Empty) response = products.Where(t => t.BodyType == paramProduct.BodyType).ToList();
            if (paramProduct.Brand != string.Empty) products.Where(t => t.Brand == paramProduct.Brand).ToList();
            if (paramProduct.ClimateControl != string.Empty) products.Where(t => t.ClimateControl == paramProduct.ClimateControl).ToList();
            if (paramProduct.EngineType != string.Empty) products.Where(t => t.EngineType == paramProduct.EngineType).ToList();
            if (paramProduct.SalonType != string.Empty) products.Where(t => t.SalonType == paramProduct.SalonType).ToList();
            if (paramProduct.Model != string.Empty) products.Where(t => t.Model == paramProduct.Model).ToList();
            if (paramProduct.Volume != -1) products.Where(t => t.Volume == paramProduct.Volume).ToList();
            if (paramProduct.Power != -1) products.Where(t => t.Power == paramProduct.Power).ToList();
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

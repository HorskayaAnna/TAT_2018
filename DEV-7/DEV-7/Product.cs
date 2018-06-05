using Newtonsoft.Json;

namespace DEVTask7
{
    /// <summary>
    /// Class product stores information about product
    /// </summary>
    [JsonObject]
    public class Product
    {
        string brand;
        string model;
        string bodyType;
        string transmissionType;
        string engineType;
        int volume;
        int power;
        string climateControl;
        string salonType;

        public Product()
        {
            brand = string.Empty;
            model = string.Empty;
            bodyType = string.Empty;
            transmissionType = string.Empty;
            engineType = string.Empty;
            volume = 0;
            power = 0;
            climateControl = string.Empty;
            salonType = string.Empty;
        }
   
        public Product(string brand, string model, string bodyType, string transmissionType, string engineType, int volume, int power, string climateControl, string salonType)
        {
            this.brand = brand;
            this.model = model;
            this.bodyType = bodyType;
            this.transmissionType = transmissionType;
            this.engineType = engineType;
            this.volume = volume;
            this.power = power;
            this.climateControl = climateControl;
            this.salonType = salonType;
        }

        [JsonProperty("Brand")]
        public string Brand { get => brand; set => brand = value; }
        [JsonProperty("Model")]
        public string Model { get => model; set => model = value; }
        [JsonProperty("BodyType")]
        public string BodyType { get => bodyType; set => bodyType = value; }
        [JsonProperty("TransmissionType")]
        public string TransmissionType { get => transmissionType; set => transmissionType = value; }
        [JsonProperty("EngineType")]
        public string EngineType { get => engineType; set => engineType = value; }
        [JsonProperty("Volume")]
        public int Volume { get => volume; set => volume = value; }
        [JsonProperty("Power")]
        public int Power { get => power; set => power = value; }
        [JsonProperty("ClimateControl")]
        public string ClimateControl { get => climateControl; set => climateControl = value; }
        [JsonProperty("SalonType")]
        public string SalonType { get => salonType; set => salonType = value; }

        /// <summary>
        /// override method to cheking equality of two objects
        /// </summary>
        /// <param name="obj">
        /// object for comparison
        /// </param>
        /// <returns>
        /// true, if object are equal or false if not
        /// </returns>
        public override bool Equals(object obj)
        {
            bool response = true;
            if (GetType() != obj.GetType())
            {
                return false;
            }
            Product product = (Product)obj;
            if (product.BodyType != BodyType)
            {
                response = false;
            }
            else if (product.Brand != Brand)
            {
                response = false;
            }
            else if (product.ClimateControl != ClimateControl)
            {
                response = false;
            }
            else if (product.EngineType != EngineType)
            {
                response = false;
            }
            else if (product.Model != Model)
            {
                response = false;
            }
            else if (product.SalonType != SalonType)
            {
                response = false;
            }
            else if (product.Power != Power)
            {
                response = false;
            }
            else if (product.Volume != Volume)
            {
                response = false;
            }
            return response;
        }

        /// <summary>
        /// override method, which return information about object   
        /// </summary>
        /// <returns>
        /// information about object
        /// </returns>
        public override string ToString()
        {
            return $"Product: {brand}, {model}, {bodyType}, {engineType}, {climateControl}, {salonType}, V: {volume}, P: {power}";
        }
    }
}

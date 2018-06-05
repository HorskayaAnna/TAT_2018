using Newtonsoft.Json;

namespace DEVTask7
{
    /// <summary>
    /// Class bmw extends product class
    /// </summary>
    [JsonObject]
    class Peugeot : Product
    {
        public Peugeot()
        {
            Brand = "Peugeot";
        }

        public Peugeot(string brand, string model, string bodyType, string transmissionType, string engineType, int volume, int power, string climateControl, string salonType)
           : base(brand, model, bodyType, transmissionType, engineType, volume, power, climateControl, salonType)
        { }
    }
}

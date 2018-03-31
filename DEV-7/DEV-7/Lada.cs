using Newtonsoft.Json;

namespace DEVTask7
{

    /// <summary>
    /// Class lada extends product class
    /// </summary>
    [JsonObject]
    class Lada : Product
    {
        public Lada()
        {
            Brand = "Lada";
        }

        public Lada(string brand, string model, string bodyType, string transmissionType, string engineType, int volume, int power, string climateControl, string salonType)
           : base(brand, model, bodyType, transmissionType, engineType, volume, power, climateControl, salonType)
        { }
    }
}

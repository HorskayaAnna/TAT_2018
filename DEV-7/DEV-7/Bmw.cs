using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace DEVTask7
{
    /// <summary>
    /// Class bmw extends product class
    /// </summary>
    [JsonObject]
    class Bmw : Product
    {
        public Bmw()
        {
            Brand = "Bmw";
        }

        public Bmw(string brand, string model, string bodyType, string transmissionType, string engineType, int volume, int power, string climateControl, string salonType)
            : base(brand, model, bodyType, transmissionType, engineType, volume, power, climateControl, salonType)
        { }
    }
}

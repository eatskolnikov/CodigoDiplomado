using System;
using Newtonsoft.Json;

namespace Clase5Ejercicio1.Entities
{
    public class Weather
    {
        [JsonProperty("temp_c")]
        public string celcius { get; set; }

        public string CelciusText { 
            get {
                return $"{celcius} °C";
            }
        }

        [JsonProperty("temp_f")]
        public string fahrenheit { get; set; }

        public string FahrenheitText
        {
            get
            {
                return $"{fahrenheit} °F";
            }
        }
        [JsonProperty("is_day")]
        public bool isday { get; set; }

        [JsonProperty("last_updated")]
        public string lastupdated { get; set; }


        public Condition condition { get; set; }
    }
}

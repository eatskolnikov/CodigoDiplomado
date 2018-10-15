using System;
namespace Clase5Ejercicio1.Entities
{
    public class Condition
    {
        public string text { get; set; }
        public string icon { get; set; }
        public string IconUrl { 
            get
            {
                return $"http:{icon}";
            }
        }
    }
}

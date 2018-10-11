using System;
namespace Clase3Ejercicio1.Data
{
    public class Article
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }

        public string AllInfo{
            get{
                return $"Cuesta US${Price}, Cantidad {Quantity} unidades";
            }
        }
    }
}

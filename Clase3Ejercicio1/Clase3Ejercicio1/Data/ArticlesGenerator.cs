using System;
using System.Collections.Generic;

namespace Clase3Ejercicio1.Data
{
    public class ArticlesGenerator
    {
        private List<string> _articleNames;
        private List<string> _articleImages;

        public ArticlesGenerator()
        {
            _articleNames = new List<string> {
                "Pasta dental",
                "Arroz",
                "Azucar",
                "Plátano",
                "Naranja"
            };
            _articleImages = new List<string>
            {
                "http://amenigraf.com/30-thickbox_default/pasta-dental-colgate.jpg",
                "http://cdnprod.foodnetworklatam.com/wp-content/uploads/2015/11/1446689777-Arroz-con-leche.jpg",
                "https://www.billboard.com/files/styles/article_main_image/public/media/Celia-Cruz-1987-billboard-1548.jpg",
                "https://uptownco.files.wordpress.com/2011/09/platanos-sg.jpg",
                "https://i.ytimg.com/vi/ZN5PoW7_kdA/hqdefault.jpg"
            };
        }
        public List<Article> GenerateList()
        {
            var collection = new List<Article>();
            for (int i = 0; i < _articleNames.Count;++i)
            {
                collection.Add(
                    new Article
                    {
                        Title = _articleNames[i],
                        ImageUrl = _articleImages[i],
                        Price = (i +1) * 74,
                        Quantity = (i+1) % 3
                    }
                );
            }
            return collection;
        }
    }

}

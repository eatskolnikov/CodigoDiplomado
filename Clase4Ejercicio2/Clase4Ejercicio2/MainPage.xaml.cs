using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Clase4Ejercicio2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var items = new List<Item>{
                new Item {
                    ImageUrl="https://img.timesnownews.com/story/1539056969-John_Cena_WWE.jpg?d=600x450"
                },
                new Item {
                    ImageUrl="https://c.o0bg.com/rf/image_960w/Boston/2011-2020/2015/11/17/BostonGlobe.com/Sports/Images/Tlumacki_soxvsroyals432.jpg"
                },
                new Item {
                    ImageUrl="https://c.o0bg.com/rf/image_960w/Boston/2011-2020/2015/11/17/BostonGlobe.com/Sports/Images/Tlumacki_soxvsroyals432.jpg"
                }
            };
            cvCarousel.ItemsSource = items;
        }
    }

    class Item
    {
        public string ImageUrl { get; set; }
    }
}

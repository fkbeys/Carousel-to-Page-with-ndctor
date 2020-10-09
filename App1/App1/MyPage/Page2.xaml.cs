using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CAROUSELVIEW_WITH_INDICATOR.MyPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentView
    {
        
        public Page2()
        {
            InitializeComponent();

            var MyStockList = new List<Stock>();
            for (int i = 0; i < 500; i++)
            {
               var Stocks = new Stock { Name = $"Stock-{i}" };
                MyStockList.Add(Stocks);
            }

            MyList.ItemsSource = MyStockList;


        }
    }

    internal class Stock
    {
        public string Name { get; set; }

    }
}
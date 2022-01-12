using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MusicShop;
using MusicShop.DB;
using DB.Products;

namespace MusicShop.Windows
{
    /// <summary>
    /// Interaction logic for ShoppingBasket.xaml
    /// </summary>
    public partial class ShoppingBasket : UserControl
    {
        public ShoppingBasket()
        {
            InitializeComponent();
        }

    

        MusicShopDB db = new MusicShopDB();
        Order order = new Order();
        ProductsBase products = new ProductsBase();
        DB.Client client = new DB.Client();
  


        public void Order()
        {



            var res = db.Products.Join
            (
            db.Orders, p => p.Id, o => o.ProductId, (p, o) => new
            {
                p.ProductName,
                p.Price,
                p.Id
            }
            ).Where(x => x.Id == 1)

              .ToList().Take(1);

            DataGridOrder.ItemsSource = res;

            


        }




   



        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}


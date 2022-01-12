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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MusicShop.DB;
using MusicShop;
using DB.Products;

namespace ShoppinBasket
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ShoppinBasket : UserControl
    {
        public ShoppinBasket()
        {
            InitializeComponent();
        }
        MusicShopDB db = new MusicShopDB();
        ProductsBase products = new ProductsBase();


        


        public void OrderProduct1()
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

        public void OrderProduct2()
        {



            var res = db.Products.Join
            (
            db.Orders, p => p.Id, o => o.ProductId, (p, o) => new
            {
                p.ProductName,
                p.Price,
                p.Id
            }
            ).Where(x => x.Id == 2)

              .ToList().Take(1);

            DataGridOrder.ItemsSource = res;



        }

        public void OrderProduct3()
        {



            var res = db.Products.Join
            (
            db.Orders, p => p.Id, o => o.ProductId, (p, o) => new
            {
                p.ProductName,
                p.Price,
                p.Id
            }
            ).Where(x => x.Id == 3)

              .ToList().Take(1);

            DataGridOrder.ItemsSource = res;



        }

        private void Save()
        {
            try
            {
                Order order = new Order();
                Client client = new Client();

                var resultClientId = db.Clients.Where(x => x.Login == Lg1.Text).Select(n => n.Id).FirstOrDefault();
                var resultOrderId = db.Clients.Where(x => x.Login == Lg1.Text);

                var res = db.Clients.Join
                    (
                    db.Orders, p => p.Id, o => o.clientId, (p, o) => new
                    {
                        p.Id,
                        o.ProductId,
                        p.Login
                    }).Where(x => x.Login == Lg1.Text).Join
                    (
                    db.Products, p => p.ProductId, o => o.Id, (p, o) => new
                    {
                        p.ProductId
                    }
                    );
                // int product = Convert.ToInt32(res);

                order.clientId = resultClientId;
                //order.ProductId = product;





                db.Orders.Add(order);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Sorry but it's demo, you can't buy anything :( ", "Version Demo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            



        }






        public void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;

           

        }

        private void ContinueBtn_Click(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show("Your order has been completed, thank you!", "Order Completed", MessageBoxButton.OK, MessageBoxImage.Information);
            Save();

        }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
           
            DataGridOrder.ItemsSource = null;
        }
    }
}

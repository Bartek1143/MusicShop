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
using System.Windows.Shapes;
using RegisterUserControl;
using MusicShop.DB;
using Microsoft.Identity.Client;
using MusicShop;
using MusicShop.LoginWindow;
using LoginUserControl;
using System.Security.Permissions;
using DB.Products;



namespace MusicShop.Windows
{
    /// <summary>
    /// Interaction logic for ShoppingCart.xaml
    /// </summary>
    public partial class Orders : Window
    {
        public Orders()
        {
            InitializeComponent();
           

        }

        MusicShopDB db = new MusicShopDB();
        Order order = new Order();
        LoginControl loginControl = new LoginControl();
        MainWindow main = new MainWindow();
        ProductsBase products = new ProductsBase();
        DB.Client client = new DB.Client();
        



        public void Details()
        {
            
            MainWindow window = new MainWindow();



          
                var resultName = db.Clients.Where(x => x.Login == Lg1.Text).Select(n => n.Name).FirstOrDefault().ToString();
                var resultSurname = db.Clients.Where(x => x.Login == Lg1.Text).Select(n => n.Surname).FirstOrDefault().ToString();
                var resultEmail = db.Clients.Where(x => x.Login == Lg1.Text).Select(n => n.Email).FirstOrDefault().ToString();
                var resultAddress = db.Clients.Where(x => x.Login == Lg1.Text).Select(n => n.Address).FirstOrDefault().ToString();
                var resultPhone = db.Clients.Where(x => x.Login == Lg1.Text).Select(n => n.PhoneNumber).FirstOrDefault();
                var resultAge = db.Clients.Where(x => x.Login == Lg1.Text).Select(n => n.Age).FirstOrDefault().ToString();


                NameBox.Text = resultName.ToString();
                SurnameBox.Text = resultSurname.ToString();
                EmailBox.Text = resultEmail.ToString();
                AddressBox.Text = resultAddress.ToString();
                PhoneNumberBox.Text = resultPhone;
                AgeBox.Text = resultAge.ToString();

            



        }
        
        private void Order()
        {
            


            var check = db.Clients.Where(x => x.Login == Lg1.Text).FirstOrDefault().ToString();
            {


                var query = db.Orders.Join
               (
               db.Products, p => p.ProductId, o => o.Id, (r, p) => new
               {
                   r.clientId,
                   r.ProductId,
                   p.ProductName,
                   p.Price
               }
               )
               .Join(db.Clients, b => b.clientId, c => c.Id, (c, b) => new
               {
                   b.Name,
                   b.Surname,
                   c.ProductName,
                   c.Price
               }).Where( x => x.Name == NameBox.Text)
               .ToList().Take(5);


                DataGridOrder.ItemsSource = query;
                

               

            };
            

           



         
                

                
               



            
                          
        }

        private void ContinueBtn_Click(object sender, RoutedEventArgs e)
        {
           
                Details();
                LogStckPnl.Visibility = Visibility.Hidden;
                DetailsStpn2.Visibility = Visibility.Visible;
                DetailsStpnl.Visibility = Visibility.Visible;
                Order();
            

         }
           

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Lg1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Lg1.Text != null)
            {
                ContinueBtn.IsEnabled = true;
            }
        }
    }

     
       

       
    
}

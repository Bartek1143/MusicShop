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
using MusicShop.Client;
using MusicShop.DB;
using Microsoft.Identity.Client;
using MusicShop;
using MusicShop.LoginWindow;
using LoginUserControl;
using System.Security.Permissions;



namespace MusicShop.Windows
{
    /// <summary>
    /// Interaction logic for ShoppingCart.xaml
    /// </summary>
    public partial class ShoppingBasket : Window
    {
        public ShoppingBasket()
        {
            InitializeComponent();

        }

        
            

   public void Details()
        {
            MusicShopDB db = new MusicShopDB();
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

        private void ContinueBtn_Click(object sender, RoutedEventArgs e)
        {
            Details();
            LogStckPnl.Visibility = Visibility.Hidden;
            DetailsStpn2.Visibility = Visibility.Visible;
            DetailsStpnl.Visibility = Visibility.Visible;
        }
    }

     
       

       
    
}

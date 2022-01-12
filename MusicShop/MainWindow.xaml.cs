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
using System.Windows.Media.Animation;
using RegisterUserControl;
using MusicShop.DB;
using Microsoft.Identity.Client;
using MusicShop;
using MusicShop.LoginWindow;
using LoginUserControl;
using MusicShop.Windows;
using System.Diagnostics;

namespace MusicShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void Bag_Click(object sender, RoutedEventArgs e)
        {
            ((Storyboard)Resources["BagAnimation"]).Begin();
            Order();
         

        }

        private void Letter_Click(object sender, RoutedEventArgs e)
        {
            ((Storyboard)Resources["LetterAnimation"]).Begin();
        }

       private void Gift_Click(object sender, RoutedEventArgs e)
        {
            ((Storyboard)Resources["GiftAnimation"]).Begin();
            Orders OrderstWindow = new Orders();
            OrderstWindow.Show();
        }

        private void PreviousOrders_Click(object sender, RoutedEventArgs e)
        {
            ((Storyboard)Resources["GiftAnimation"]).Begin();
            Orders OrdersWindow = new Orders();
            OrdersWindow.Show();
        }

        private void User_Click(object sender, RoutedEventArgs e)
        {
            ((Storyboard)Resources["UserAnimation"]).Begin();
            LogOrRegWindow MenuWindow = new LogOrRegWindow();
            MenuWindow.Show();
            MenuWindow.SignInBtn.Click += SignInBtn_Click;
            MenuWindow.RegisterInBtn.Click += RegisterInBtn_Click;
            
            

        }

        private void RegisterInBtn_Click(object sender, RoutedEventArgs e)
        {
            Register();
        }

        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            SignIn();
            
         
        }

        private void Accessories_Click(object sender, RoutedEventArgs e)
        {

            NavigationWindow AccessoriesPage = new NavigationWindow();
            AccessoriesPage.Source = new Uri("Pages/Products.xaml", UriKind.Relative);
            AccessoriesPage.Show();
            AccessoriesPage.Height = 750;  
            this.Visibility = Visibility.Hidden;

          
        }

        private void Order()
        {
            ShoppinBaskUSC.Visibility = Visibility.Visible;
            MainBanner.Visibility = Visibility.Hidden;
            CenterBannerButton1.Visibility = Visibility.Hidden;
            CenterBannerButton2.Visibility = Visibility.Hidden;
            CenterBannerButton3.Visibility = Visibility.Hidden;
            
        }
        
            

        public void Register()
        {
           // RegisterControl register = new RegisterControl();
            RegisterPanel.Visibility = Visibility.Visible;
            ExitRegisterButton.Visibility = Visibility.Visible;
            MainBanner.Visibility = Visibility.Hidden;
            CenterBannerButton1.Visibility = Visibility.Hidden;
            CenterBannerButton2.Visibility = Visibility.Hidden;
            CenterBannerButton3.Visibility =  Visibility.Hidden;

     

        }

       
        
        

        private void ExitRegisterButton_Click(object sender, RoutedEventArgs e)
        {
   
            RegisterPanel.Visibility = Visibility.Hidden;
            ExitRegisterButton.Visibility = Visibility.Hidden;
            MainBanner.Visibility = Visibility.Visible;
            CenterBannerButton1.Visibility = Visibility.Visible;
            CenterBannerButton2.Visibility = Visibility.Visible;
            CenterBannerButton3.Visibility = Visibility.Visible;

        }

        public void SignIn()
        {
            LoginPanel.Visibility = Visibility.Visible;
            ExitLoginButton.Visibility = Visibility.Visible;
            MainBanner.Visibility = Visibility.Hidden;
            CenterBannerButton1.Visibility = Visibility.Hidden;
            CenterBannerButton2.Visibility = Visibility.Hidden;
            CenterBannerButton3.Visibility = Visibility.Hidden;
          



        }

        private void ExitLoginButton_Click(object sender, RoutedEventArgs e)
        {
            NameBtn.Text = /* "User " +*/ LoginPanel.Text;
            ExitLoginButton.Visibility = Visibility.Hidden;
            LoginPanel.Visibility = Visibility.Hidden; 
            MainBanner.Visibility = Visibility.Visible;
            CenterBannerButton1.Visibility = Visibility.Visible;
            CenterBannerButton2.Visibility = Visibility.Visible;
            CenterBannerButton3.Visibility = Visibility.Visible;
            
            
        }

        private void CenterBannerButton2_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow AccessoriesPage = new NavigationWindow();
            AccessoriesPage.Source = new Uri("Pages/Products.xaml", UriKind.Relative);
            AccessoriesPage.Show();
            AccessoriesPage.Height = 750;
            this.Visibility = Visibility.Hidden;

         
        }

        private void CenterBannerButton1_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow AccessoriesPage = new NavigationWindow();
            AccessoriesPage.Source = new Uri("Pages/Products.xaml", UriKind.Relative);
            AccessoriesPage.Show();
            AccessoriesPage.Height = 750;
            this.Visibility = Visibility.Hidden;
        }

        private void CenterBannerButton3_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow AccessoriesPage = new NavigationWindow();
            AccessoriesPage.Source = new Uri("Pages/Products.xaml", UriKind.Relative);
            AccessoriesPage.Show();
            AccessoriesPage.Height = 750;
            this.Visibility = Visibility.Hidden;
        }

        private void Tickets_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Currently we don't have any tickets.", "Information", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            ContactGrid.Visibility = Visibility.Visible;
            MainBanner.Visibility = Visibility.Hidden;
            CenterBannerButton1.Visibility = Visibility.Hidden;
            CenterBannerButton2.Visibility = Visibility.Hidden;
            CenterBannerButton3.Visibility = Visibility.Hidden;
            OpeningGrid.Visibility = Visibility.Hidden;

        }



        private void FB_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/oolinek");
        }

        private void GM_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("bartlomiej.olesinski2@gmail.com", "Email", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void LK_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/bart%C5%82omiej-olesi%C5%84ski-a72ab0192/"); 
        }


        private void Home_Click(object sender, RoutedEventArgs e)
        {
            ContactGrid.Visibility = Visibility.Hidden;
            MainBanner.Visibility = Visibility.Visible;
            CenterBannerButton1.Visibility = Visibility.Visible;
            CenterBannerButton2.Visibility = Visibility.Visible;
            CenterBannerButton3.Visibility = Visibility.Visible;
            OpeningGrid.Visibility = Visibility.Hidden;
        }

        private void News_Click(object sender, RoutedEventArgs e)
        {
            OpeningGrid.Visibility = Visibility.Visible;
            MainBanner.Visibility = Visibility.Hidden;
                
        }

      

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

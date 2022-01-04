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
        }

        private void Letter_Click(object sender, RoutedEventArgs e)
        {
            ((Storyboard)Resources["LetterAnimation"]).Begin();
        }

        private void Gift_Click(object sender, RoutedEventArgs e)
        {
            ((Storyboard)Resources["GiftAnimation"]).Begin();
        }

        private void User_Click(object sender, RoutedEventArgs e)
        {
            ((Storyboard)Resources["UserAnimation"]).Begin();
            Register();

        }

        private void Accessories_Click(object sender, RoutedEventArgs e)
        {

            NavigationWindow AccessoriesPage = new NavigationWindow();
            AccessoriesPage.Source = new Uri("Pages/Products.xaml", UriKind.Relative);
            AccessoriesPage.Show();
            AccessoriesPage.Height = 750;  
            this.Visibility = Visibility.Hidden;

          
        }

        private void Register()
        {
           // RegisterControl register = new RegisterControl();
            RegisterPanel.Visibility = Visibility.Visible;
            MainBanner.Visibility = Visibility.Hidden;
            CenterBannerButton1.Visibility = Visibility.Hidden;
            CenterBannerButton2.Visibility = Visibility.Hidden;
            CenterBannerButton3.Visibility =  Visibility.Hidden;
           

        }

        
    }
}

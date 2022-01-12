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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DB.Products;
using MusicShop.Pages;
using LoginUserControl;
using MusicShop.DiscountServiceReference;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading;
using MusicShop.Windows;

namespace MusicShop
{
    /// <summary>
    /// Interaction logic for Products.xaml
    /// </summary>
    public partial class Products : Page
    {
       

        public Products()
        {
           
            InitializeComponent();

            
            

            
         
        }

        private void Bag_Click(object sender, RoutedEventArgs e)
        {
            ((Storyboard)Resources["BagAnimation"]).Begin();
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            ((Storyboard)Resources["ReturnAnimation"]).Begin();

            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.Visibility = Visibility.Visible;
            Window win = (Window)this.Parent;
            win.Close();
        }

        private void TShirt1Btn_Click(object sender, RoutedEventArgs e)
        {
            Product1Grid.Visibility = Visibility.Visible;


            Clothes clothes;
            clothes = new Tshirt();
            string Tshirt = clothes.Material("80% Cotton", "20% Polyester");
            Product1Tbx.Text = Tshirt;
            

        }


        private void Tshirt2Btn_Click(object sender, RoutedEventArgs e)
        {
            Product2Grid.Visibility = Visibility.Visible;

            Clothes clothes;
            clothes = new Tshirt();
            string Tshirt = clothes.Material("60% Cotton", "40% Polyester");
            Product2Tbx.Text = Tshirt;
        }

        private void Product1Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            Product1Grid.Visibility = Visibility.Hidden;
        }

        private void Product2Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            Product2Grid.Visibility = Visibility.Hidden;
        }

        private void Tshirt3Btn_Click(object sender, RoutedEventArgs e)
        {
            Product3Grid.Visibility = Visibility.Visible;

            Clothes clothes;
            clothes = new Jacket();
            string Jacket = clothes.Material("75%", "90% Synthetic");
            Product3Tbx.Text = Jacket;
        }

        private void Product3Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            Product3Grid.Visibility = Visibility.Hidden;
        }

        public void BuyNowBtn1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Product will be update in you basket", "Information",MessageBoxButton.OKCancel, MessageBoxImage.Information);


            ShoppingBasketUSC.Visibility = Visibility.Visible;
            gridPrd.Visibility = Visibility.Hidden;
            ShoppingBasketUSC.OrderProduct1();
          
         
            

        }

        private void SaleBtn_Click(object sender, RoutedEventArgs e)
        {
            DiscountBorder.Visibility = Visibility.Visible;

        }


        private void DiscountBtn_Click(object sender, RoutedEventArgs e)
        {
            

            int Price, Discount, AllDiscount;

            DiscountServiceReference.Service1Client discount = new Service1Client();

            Price = int.Parse(CurrentPriceTbx.Text);
            Discount = int.Parse(DiscountTbx.Text);

            AllDiscount = discount.CountDiscount(Price, Discount);

            DiscountAll.Text = AllDiscount.ToString();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            DiscountBorder.Visibility = Visibility.Hidden;
          
        }

        private void BuyNowBtn2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Product has been update in you basket", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            ShoppingBasketUSC.Visibility = Visibility.Visible;
            gridPrd.Visibility = Visibility.Hidden;
            ShoppingBasketUSC.OrderProduct2();



        }

        private void BuyNowBtn3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Product has been update in you basket", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            ShoppingBasketUSC.Visibility = Visibility.Visible;
            gridPrd.Visibility = Visibility.Hidden;
            ShoppingBasketUSC.OrderProduct3();

        }
    }
}

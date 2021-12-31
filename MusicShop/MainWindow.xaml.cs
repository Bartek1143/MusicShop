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
        }
    }
}

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
using MusicShop;


namespace MusicShop.LoginWindow
{
    /// <summary>
    /// Interaction logic for LogOrRegWindow.xaml
    /// </summary>
    public partial class LogOrRegWindow : Window
    {
        readonly MainWindow mainWindow = new MainWindow();


        public LogOrRegWindow()
        {
            InitializeComponent();
           
        }
      
        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
            
           
           
        }

        private void RegisterInBtn_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }
    }
}

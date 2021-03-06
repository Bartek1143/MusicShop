using MusicShop;
using MusicShop.DB;
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

namespace LoginUserControl
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
            
        }

        // Check if login and password are correct
        public void Login()
        {
            MusicShopDB db = new MusicShopDB();
            var result = db.Clients.Any(x => x.Login == LoginBox.Text && x.Password == Password.Password);
                {
                if(result == true)
                {
                    MessageBox.Show("Sign in successfull", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    LoginControl loginControl = new LoginControl();
                    
                }
                else
                {
                    MessageBox.Show("Wrong Password or Login, Please try again", "Attention", MessageBoxButton.OK, MessageBoxImage.Error);
                }
               
            };

        }

        public void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Login();
        }

        public string login;

        public string Text
        {
            get { return LoginBox.Text; }
            set { value = login ; }
        }

        
    }
}

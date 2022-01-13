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





namespace RegisterUserControl
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class RegisterControl : UserControl
    {
      

        public RegisterControl()
        {
            InitializeComponent();
         
        }

       




        public void RegisterData()
        {
            MusicShopDB db = new MusicShopDB();
            Client Save = new Client();
            
            // automatically increment of Id
            Save.Name = NameBox.Text;
            Save.Surname = SurnameBox.Text;
            Save.PhoneNumber = PhoneNumberBox.Text;
            Save.Age = AgeBox.Text;
            Save.Email = EmailBox.Text;
            Save.Address = AddressBox.Text;
            Save.Password = Password.Password;
            Save.Login = LoginBox.Text;

           
           
           
           
            db.Clients.Add(Save);
            db.SaveChanges();
            RegisterControl register = new RegisterControl();

            MessageBox.Show("Thank you for register, please shut the window", "Information", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            


        }

       

    

        public void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterData();
            
        }
    }
}

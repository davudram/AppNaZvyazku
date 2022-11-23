using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
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
using ValidationResult = System.Windows.Controls.ValidationResult;

namespace TestZvyazok
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ZvyazokModel model = new ZvyazokModel();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            model.Authorizations.Add(new Authorization{ Login = TextBoxLogin.Text, Password = TextBoxPassword.Password, FullName = TextBoxFullName.Text, Email = TextBoxEmail.Text});
            var context = new ValidationContext(model);
            model.SaveChanges();
            if(context!=null)
            {
                MessageBox.Show("Успіх");
                MainMenu menu = new MainMenu();
                menu.Show();
                Close();
            }
        }

        //private Boolean chekUser()
        //{
        //    string loginUser = TextBoxLogin.Text;
        //    string passwordUser = TextBoxPassword.Password;

            
        //}
    }
}

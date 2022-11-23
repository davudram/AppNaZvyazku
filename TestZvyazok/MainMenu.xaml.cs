using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TestZvyazok
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fcont.Navigate(new Uri("Pages/News.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Container_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void btn_Command(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            fcont.Navigate(new Uri("Pages/PersonalArea.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            fcont.Navigate(new Uri("Pages/Subscription.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            fcont.Navigate(new Uri("Pages/Tariff.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            fcont.Navigate(new Uri("Pages/AboutApp.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            fcont.Navigate(new Uri("Pages/Help.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}

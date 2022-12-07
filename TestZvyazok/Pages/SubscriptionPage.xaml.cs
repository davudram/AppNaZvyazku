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
using TestZvyazok.ViewModels;

namespace TestZvyazok.Pages
{
    /// <summary>
    /// Логика взаимодействия для SubscriptionPage.xaml
    /// </summary>
    public partial class SubscriptionPage : Page
    {
        private int subscriptionID;

        public SubscriptionPage()
        {
            InitializeComponent();
            DataContext = new SubscriptionViewModel();
        }

        public SubscriptionPage(int subscriptionID)
        {
            this.subscriptionID = subscriptionID;
        }
    }
}

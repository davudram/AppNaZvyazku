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

namespace TestZvyazok.Pages
{
    /// <summary>
    /// Логика взаимодействия для SubscriptionPage.xaml
    /// </summary>
    public partial class SubscriptionPage : Page
    {
        private object subscriptionID;

        public SubscriptionPage()
        {
            InitializeComponent();
        }

        public SubscriptionPage(object subscriptionID)
        {
            this.subscriptionID = subscriptionID;
        }
    }
}

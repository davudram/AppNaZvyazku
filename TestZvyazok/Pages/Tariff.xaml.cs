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
    /// Логика взаимодействия для Tariff.xaml
    /// </summary>
    public partial class Tariff : Page
    {
        public Tariff()
        {
            InitializeComponent();
            this.DataContext = new TariffViewModel();
        }

        public Tariff(int tariffID)
        {
            this.DataContext = tariffID;
        }
    }
}

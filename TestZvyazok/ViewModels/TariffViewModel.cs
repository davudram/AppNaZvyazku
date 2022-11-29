using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestZvyazok.Models;
using TestZvyazok.Pages;

namespace TestZvyazok.ViewModels
{
    public class TariffViewModel : INotifyPropertyChanged
    {

        private TARIFF tariff; 

        ZvyazokModel model;

        public TARIFF Tariff
        {
            get { return tariff; }
            set 
            {
                tariff = value;
                OnPropertyChanged("Tariff");
            }
        }

        private RelayCommand myVar;

        public RelayCommand AuthCommand
        {
            get { return myVar ?? (myVar = new RelayCommand(ShowData)); }
        }

        private void ShowData()
        {            //UserControlTariff controlTariff = new UserControlTariff();
            //controlTariff.NameTariff = tariff.Name;

        }


        public TariffViewModel()
        {
            tariff = new TARIFF();
            model = new ZvyazokModel();
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

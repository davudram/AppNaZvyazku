using GalaSoft.MvvmLight.Command;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestZvyazok.Models;
using TestZvyazok.Pages;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TestZvyazok.ViewModels
{
    public class TariffViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<TARIFF> tariff; 
        public ObservableCollection<TARIFF> Tariffs
        {
            get { return tariff; }
            set 
            {
                tariff = value;
                OnPropertyChanged("Tariffs");
            }
        }

        private TARIFF _selectedTariff;

        public TARIFF SelectedTariff
        {
            get { return _selectedTariff; }
            set 
            {
                _selectedTariff = value;
                OnPropertyChanged("SelectedTariff");
                ShowTariff();
            }
        }

        public TariffViewModel()
        {
            tariff = new ObservableCollection<TARIFF>(new ZvyazokModel().TARIFFs);
            
        }

        private RelayCommand _showCommand;

        public RelayCommand ShowCommand
        {
            get { return _showCommand ?? (_showCommand = new RelayCommand(ShowTariff)); }
        }

        void ShowTariff()
        {
            if (SelectedTariff == null)
                return;
            Tariff tariffControl = new Tariff(SelectedTariff.TariffID);
            tariffControl.ShowDialog(SelectedTariff);
        }



        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

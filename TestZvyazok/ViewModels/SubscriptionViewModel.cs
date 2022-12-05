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
using Subscription = TestZvyazok.Models.Subscription;

namespace TestZvyazok.ViewModels
{
    public class SubscriptionViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Subscription> subscriptions;
        public ObservableCollection<Subscription> Subscriptions
        {
            get { return subscriptions; }
            set
            {
                subscriptions = value;
                OnPropertyChanged("Subscriptions");
            }
        }

        private Subscription _selectedSubscription;

        public Subscription SelectedSubscriptions
        {
            get { return _selectedSubscription; }
            set
            {
                _selectedSubscription = value;
                OnPropertyChanged("SelectedSubscriptions");
                ShowSubscriptions();
            }
        }

        public SubscriptionViewModel()
        {
            subscriptions = new ObservableCollection<Subscription>(new ZvyazokModel().Subscriptions);

        }

        private RelayCommand _showCommand;

        public RelayCommand ShowSubCommand
        {
            get { return _showCommand ?? (_showCommand = new RelayCommand(ShowSubscriptions)); }
        }

        void ShowSubscriptions()
        {
            if (SelectedSubscriptions == null)
                return;
            SubscriptionPage subscription = new SubscriptionPage(SelectedSubscriptions.SubscriptionID);
            subscription.ShowDialog(SelectedSubscriptions);
        }



        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

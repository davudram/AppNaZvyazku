using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TestZvyazok.Models;
using TestZvyazok.Pages;
using TestZvyazok.UserModels;

namespace TestZvyazok.ViewModels
{
    public class CardViewModel : INotifyPropertyChanged
    {
        private CardAuth card;

        ZvyazokModel model;

        public CardAuth Card
        {
            get { return card; }
            set
            {
                card = value;
                OnPropertyChanged("Card");
            }
        }
        

        private RelayCommand myVar;

        public RelayCommand MyProperty
        {
            get { return myVar ?? (myVar = new RelayCommand(EnterCardData)); }
        }

        public void EnterCardData()
        {
            CreditCard addcard = new CreditCard();
            addcard.CardNumber = Card.CardNumber;
            addcard.CVV = Card.CVV;
            addcard.DateCard = Card.DateCard;
            if(model.CreditCards.FirstOrDefault(x => x.CardNumber.Equals(addcard.CardNumber)) == null){
                model.CreditCards.Add(addcard);
            }

            else
            {
                MessageBox.Show("Дана картка вже прив'язана");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}

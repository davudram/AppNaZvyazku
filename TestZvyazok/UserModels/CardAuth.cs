using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestZvyazok.UserModels
{
    public class CardAuth
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string cardnumber;

        public string CardNumber
        {
            get { return cardnumber; }
            set { cardnumber = value; OnPropertyChanged("CardNumber"); }
        }

        private int cvv;

        public int CVV
        {
            get { return cvv; }
            set { cvv = value; OnPropertyChanged("CVV"); }
        }

        private string datecard;

        public string DateCard
        {
            get { return datecard; }
            set { datecard = value; OnPropertyChanged("DateCard"); }
        }


        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}

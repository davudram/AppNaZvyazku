using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TestZvyazok.Models;
using TestZvyazok.UserModels;

namespace TestZvyazok.ViewModels
{
    public class EntranceViewModel : INotifyPropertyChanged
    {
        private UserAuth user;

        ZvyazokModel model;

        public UserAuth User
        {
            get { return user; }
            set
            {
                user = value;
                OnPropertyChanged("User");
            }
        }

        private RelayCommand myVar;

        public RelayCommand AuthCommand
        {
            get { return myVar ?? (myVar = new RelayCommand(EnterData)); }
        }


        private void EnterData()
        {
            Authorization authorization = new Authorization();
            authorization.Login = User.Login;
            authorization.Password = User.Password;
            if (model.Authorizations.FirstOrDefault(x => x.Login.Equals(authorization.Login)) == null)
            {
                MessageBox.Show("Такий користувач не існує!!!");
            }

            else
            {
                MainMenu menu = new MainMenu();
                menu.Show();
            }
        }

        public EntranceViewModel()
        {
            user = new UserAuth();
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

using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using TestZvyazok.Models;
using TestZvyazok.Properties;
using TestZvyazok.UserModels;

namespace TestZvyazok.ViewModels
{
    class RegistrationViewModel : INotifyPropertyChanged
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
            get { return myVar ?? (myVar = new RelayCommand(AddData)); }
        }


        private void AddData()
        {
            Authorization authorization = new Authorization();
            authorization.Login = User.Login;
            authorization.Password = User.Password;
            if (model.Authorizations.FirstOrDefault(x => x.Login.Equals(User.Login)) == null)
            {
                model.Authorizations.Add(authorization);
                model.SaveChanges();
                USER user = new USER() { RoleID = 1, AuthorizationID = model.Authorizations.FirstOrDefault(x => x.Login.Equals(authorization.Login)).AuthorizationID };
                model.SaveChanges();
                MainMenu menu = new MainMenu();
                menu.Show();
            }

            else
            {
                MessageBox.Show("Такий користувач вже існує!!!");
            }
        }

        public RegistrationViewModel()
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

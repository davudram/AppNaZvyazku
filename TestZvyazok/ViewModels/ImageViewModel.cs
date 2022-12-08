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
    public class ImageViewModel : INotifyPropertyChanged
    {
		ZvyazokModel model;

		private PersonalAreaAuth personalArea;

		public PersonalAreaAuth PersonalAreas
		{
			get { return personalArea; }
			set { personalArea = value; OnPropertyChanged("PersonalArea"); }
		}

		private RelayCommand myPersonalArea;

		public RelayCommand PersonalAreaAutho
		{
			get { return myPersonalArea ?? (myPersonalArea = new RelayCommand(AddPersonalAreaInfo)); }
		}

		private void AddPersonalAreaInfo()
		{
			PersonalArea area = new PersonalArea();
			area.FullName = personalArea.FullName;
			area.Avatar = personalArea.Image;
			if(model.PersonalAreas.FirstOrDefault(x => x.FullName.Equals(area.FullName)) == null)
			{
				model.PersonalAreas.Add(area);
				model.SaveChanges();
			}

			else
			{
				MessageBox.Show("Помилка.");
			}
		}


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

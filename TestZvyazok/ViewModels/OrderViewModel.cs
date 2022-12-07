using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using TestZvyazok.Models;

namespace TestZvyazok.ViewModels
{
    public class OrderViewModel : INotifyPropertyChanged
    {
        ZvyazokModel model;

        private ObservableCollection<OrderINFO> order;

        public ObservableCollection<OrderINFO> Orders
        {
            get { return order; }
            set { order = value; }
        }

        private OrderINFO _selectedOrder;

        public OrderINFO SelectedOrders
        {
            get { return _selectedOrder; }
            set
            {
                _selectedOrder = value;
                AddSelectedOrder();
                OnPropertyChanged("SelectedOrders");
            }
        }

        private RelayCommand myOrders;

        public RelayCommand MyOrder
        {
            get { return myOrders ?? (myOrders = new RelayCommand(AddSelectedOrder)); }
        }

        public OrderViewModel()
        {
            order = new ObservableCollection<OrderINFO>(new ZvyazokModel().OrderINFOes);
        }

        public OrderViewModel(int orderID)
        {
            order = new ObservableCollection<OrderINFO>(new ZvyazokModel().OrderINFOes.Where(x => x.OrderINFOId == orderID));
        }

        private void AddSelectedOrder()
        {

            if (order != null)
            {
                OrderINFO orderINFO = new OrderINFO() { OrderINFOId = SelectedOrders.OrderINFOId};
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

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MasterDetailBottomSheet
{
    public class BindableBase : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class Order {
        public string OrderID {
            get;
            set;
        }
        public DateTime OrderDate {
            get;
            set;
        }
        public decimal TotalAmount {
            get {
                return Details.Sum(d => d.ProductTotal);
            }
        }
        public OrderStatus Status {
            get;
            set;
        }
        public ObservableCollection<OrderDetails> Details {
            get;
            set;
        }
    }
    public enum OrderStatus {
        New,
        Shipping,
        Finished,
        Cancelled
    }
    public class OrderDetails {
        public Product Product {
            get;
            set;
        }
        public int Quantity {
            get;
            set;
        }
        public decimal ProductTotal {
            get {
                return Quantity * Product.UnitPrice;
            }
        }
    }
    public class Product {
        public string ProductName {
            get;
            set;
        }
        public string ImagePath {
            get;
            set;
        }
        public decimal UnitPrice {
            get;
            set;
        }
    }

    public class ActionItem {
        public ActionItem(string caption, string iconPath, ICommand command) {
            Caption = caption;
            IconPath = iconPath;
            Command = command;
        }
        public string Caption {
            get;
            set;
        }
        public string IconPath {
            get;
            set;
        }
        public ICommand Command {
            get;
            set;
        }
    }
}

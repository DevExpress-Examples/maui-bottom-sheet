using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MasterDetailBottomSheet {
    public class MainViewModel : BindableBase {
        Order selectedOrder;
        public ObservableCollection<Order> Orders {
            get;
            set;
        }
        public Order SelectedOrder {
            get { return selectedOrder; }
            set {
                selectedOrder = value;
                RaisePropertyChanged();
            }
        }
        public MainViewModel() {
            Orders = DataGenerator.CreateOrders();
            Command commonActionItemCommand = new Command<ActionItem>(OrderItemAction);
            ActionItems = new ObservableCollection<ActionItem>() {
                new ActionItem("Share","share",commonActionItemCommand),
                new ActionItem("Print","print",commonActionItemCommand),
                new ActionItem("Repeat","repeat",commonActionItemCommand),
                new ActionItem("Feedback","feedback",commonActionItemCommand),
                new ActionItem("Bookmark","bookmark",commonActionItemCommand),
            };
        }
        public void OrderItemAction(ActionItem actionItem) {
            Debug.WriteLine(actionItem.Caption + " click");
        }
        public ObservableCollection<ActionItem> ActionItems { get; set; }
    }


}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailBottomSheet {
    public static class DataGenerator {
        public static ObservableCollection<Order> CreateOrders() {
            ObservableCollection<Order> orders = new ObservableCollection<Order>();
            Random rnd = new Random();
            orders.Add(new Order() { Details = CreateRandomDetails(), OrderDate = DateTime.Now, Status = OrderStatus.New, OrderID = string.Format("OD{0:0000}", rnd.Next(1, 9999)) });
            orders.Add(new Order() { Details = CreateRandomDetails(), OrderDate = DateTime.Now, Status = OrderStatus.Shipping, OrderID = string.Format("OD{0:0000}", rnd.Next(1, 9999)) });
            for (int i = 1; i < 20; i++) {
                orders.Add(new Order() { Details = CreateRandomDetails(), OrderDate = DateTime.Now.AddDays(-i * 2), Status = rnd.Next(10) > 7 ? OrderStatus.Cancelled : OrderStatus.Finished, OrderID = string.Format("OD{0:0000}", rnd.Next(1, 9999)) });
            }
            return orders;
        }

        static ObservableCollection<OrderDetails> CreateRandomDetails() {
            ObservableCollection<OrderDetails> result = new ObservableCollection<OrderDetails>();
            Random rnd = new Random();
            List<int> possibleIndexes = Enumerable.Range(0, AllProducts.Count - 1).ToList();
            int detailsCount = rnd.Next(3, 8);
            for (int i = 0; i < detailsCount; i++) {
                int index = rnd.Next(0, possibleIndexes.Count - 1);
                result.Add(new OrderDetails() { Product = AllProducts[possibleIndexes[index]], Quantity = rnd.Next(1, 10) });
                possibleIndexes.RemoveAt(index);
            }
            return result;
        }


        static List<Product> AllProducts = new List<Product>() {
            new Product(){ ProductName = "Chai", ImagePath="beverages", UnitPrice = 4.4m },
            new Product(){ ProductName = "Sasquatch Ale", ImagePath="beverages", UnitPrice = 10.25m },
            new Product(){ ProductName = "Tofu", ImagePath="produce", UnitPrice = 3.5m },
            new Product(){ ProductName = "Rössle Sauerkraut", ImagePath="produce", UnitPrice = 6.1m  },
            new Product(){ ProductName = "Oatmeal", ImagePath="grains", UnitPrice = 5.90m },
            new Product(){ ProductName = "Filo Mix", ImagePath="grains", UnitPrice = 9.95m },
            new Product(){ ProductName = "Marmalade", ImagePath="confections", UnitPrice = 3.75m },
            new Product(){ ProductName = "Tarte au sucre", ImagePath="confections", UnitPrice = 3.5m },
            new Product(){ ProductName = "Boston Crab Meat", ImagePath="seafood", UnitPrice = 3.5m },
            new Product(){ ProductName = "Spegesild", ImagePath="seafood", UnitPrice = 3.5m },
            new Product(){ ProductName = "Camembert Pierrot", ImagePath="diaryproducts", UnitPrice = 3.5m },
            new Product(){ ProductName = "Geitost", ImagePath="diaryproducts", UnitPrice = 3.5m },
            new Product(){ ProductName = "Alice Mutton", ImagePath="meat", UnitPrice = 3.5m },
            new Product(){ ProductName = "Tourtière", ImagePath="meat", UnitPrice = 3.5m },
            new Product(){ ProductName = "Genen Shouyu", ImagePath="condiments", UnitPrice = 3.5m },
            new Product(){ ProductName = "Aniseed Syrup", ImagePath="condiments", UnitPrice = 3.5m },
        };

    }
}

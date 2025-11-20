using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A25___Lists_and_Collections
{
    internal class Program
    {
        //Task 1: Class inventory
        class Inventory
        {
            //Task 1a: List to store product names
            private List<string> items = new List<string>();

            //Task 1b: Dictionary to store product details
            private Dictionary<string, (double price, int stock)> itemDetails = new Dictionary<string, (double price, int stock)>();

            //Task 2: Methods

            public void AddItem(string productName, double price, int stock)
            {
                items.Add(productName);
                itemDetails[productName] = (price, stock);
            }

            public void RemoveItem(string productName)
            {
                items.Remove(productName);
                itemDetails.Remove(productName);
            }

            public void UpdateStock(string productName, int newStock)
            {
                if (itemDetails.ContainsKey(productName))
                {
                    var details = itemDetails[productName];
                    itemDetails[productName] = (details.price, newStock);
                }
                else
                {
                    Console.WriteLine("Item not found in inventory.");
                }
            }

            public void PrintInventory()
            {
                Console.WriteLine("Current Inventory:");
                foreach (var product in items)
                {
                    var details = itemDetails[product];
                    Console.WriteLine($"Product: {product}, Price: {details.price:F2}, Stock: {details.stock}");
                }
            }

            public void MostExpensive()
            {
                if (itemDetails.Count == 0)
                {
                    Console.WriteLine("Inventory is empty.");
                    return;
                }
                string mostExpensiveItem = null;
                double highestPrice = double.MinValue;
                foreach (var product in items)
                {
                    var details = itemDetails[product];
                    if (details.price > highestPrice)
                    {
                        highestPrice = details.price;
                        mostExpensiveItem = product;
                    }
                }
                Console.WriteLine($"Most Expensive Item: {mostExpensiveItem}, Price: {highestPrice:F2}");
            }

            public void TotalValue()
            {
                double totalValue = 0.0;
                foreach (var product in items)
                {
                    var details = itemDetails[product];
                    totalValue += details.price * details.stock;
                }
                Console.WriteLine($"Total Inventory Value: {totalValue:F2}");
            }
        }
        static void Main(string[] args)
        {
            //Task 3: Instance of inventory
            Inventory storeInventory = new Inventory();
            storeInventory.AddItem("Laptop", 1200.50, 7);
            storeInventory.AddItem("Smartphone", 799.99, 12);
            storeInventory.AddItem("Tablet", 399.99, 15);

            //Task 4: Print items and details
            storeInventory.PrintInventory();
            Console.WriteLine();

            //Task 5: Update stock of an item
            string productName = "Laptop";
            int newStock = 5;
            storeInventory.UpdateStock(productName, newStock);
            Console.WriteLine($"Stock of {productName} updated to {newStock}.\n");

            //Task 6: Remove an item'
            string removeItem = "Tablet";
            storeInventory.RemoveItem(removeItem);
            Console.WriteLine($"{removeItem} has been removed from the inventory.\n");

            //Task 7: Most expensive item
            storeInventory.MostExpensive();
            Console.WriteLine();

            //Task 8: Total inventory value
            storeInventory.TotalValue();
        }
    }
}

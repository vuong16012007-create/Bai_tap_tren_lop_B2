using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
namespace ClassAndObjectsExercise
{
    public class Product
    {
        private string name;
        private double price;
        private int quantity;
        private string sku;

        public Product (string name, double price, int quantity, string sku)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.sku = sku;
        } 
        public void Sell ( int amount)
        {
            if (amount > quantity)
            {
                Console.WriteLine($"The current stock does not meet your requirement quantity");
            }
            else
            {
                quantity -= amount;
                Console.WriteLine("Successfully!");
            }
        }
        public void Restock(int amount)
        {
            if (amount + quantity > 200)
            {
                Console.WriteLine("The warehouse is overloaded because it has exceeded the weight limit.");
            }
            else
            {
                quantity += amount;
                Console.WriteLine("Stock-in successful");
            }
        }
        public void ApplyDiscount(double percent)
        {
            if (percent >= 0 && percent <= 100)
            {
                price = price - (price * (percent  / 100));
                Console.WriteLine("Discount successfully!");
            }
            else
            {
                Console.WriteLine("Discount fail.");
            }
        }
        public double GetTotalValue()
        {
           return price * quantity;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"[{sku}] {name} | Giá: ${price:0.00} | Tồn kho: {quantity} | Tổng vốn: ${GetTotalValue():0.00}");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Product steak = new Product("Beef Steak",  25.50, 40, "MMO");
            Product wine = new Product("Red Wine", 45.00, 77, "BJSD");
            Product pasta = new Product("Seafood Pasta", 18.00, 120,"LOQ");

            steak.ShowInfo();
            wine.ShowInfo();
            pasta.ShowInfo();
            Console.WriteLine(new string('-', 40));

            Console.WriteLine("\n--- TEST: BÁN HÀNG ---");
            steak.Sell(15);      // Hợp lệ
            steak.Sell(190);      // Quá số lượng kho

            Console.WriteLine("\n--- TEST: NHẬP KHO ---");
            wine.Restock(10);    
            wine.Restock(190);

            Console.WriteLine("\n--- TEST: GIẢM GIÁ ---");
            steak.ApplyDiscount(20);   // Hợp lệ
            pasta.ApplyDiscount(150);  // Không hợp lệ (> 100)
            pasta.ApplyDiscount(-10);  // Không hợp lệ (< 0)



        }
    }
}
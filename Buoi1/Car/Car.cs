using System;
using System.Runtime.CompilerServices;

namespace ClassAndObjectsExercise
{
    public class Car
    {
        private string brand;
        private string model;
        private int year;
        private int speed;
        private int fuelLevel;
        public Car(string brand, string model, int year, int speed = 0, int fuelLevel = 100)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.speed = speed;
            this.fuelLevel = fuelLevel;
            this.speed = speed;
        }
        public void Accelerate(int increment)
        {
            if(increment + speed  > 200)
            {
                Console.WriteLine("Increment exceeds maximum speed limit.");
                return;
            }
            else
            {
            speed += increment;
            Console.WriteLine($"{brand} {model} is accelerating. Current speed: {speed} km/h");
            }
        }
        public void Brake(int decrement)
        {
            speed -= decrement;
            if (speed < 0)
            {
                speed = 0; // Đảm bảo tốc độ không âm       
            }
        }
        public void Refuel(int amount)
        {
            fuelLevel += amount;
            if (fuelLevel > 100)
            {
                fuelLevel = 100; // Đảm bảo mức nhiên liệu không vượt quá 100
            }
            Console.WriteLine($"{brand} {model} is refueled. Current fuel level: {fuelLevel}%");
        }
        private string GetBrand() => brand;
        private string GetModel() => model;
        private int GetYear() => year;
        private int GetSpeed() => speed;
        private int GetFuelLevel() => fuelLevel;
        public void ShowInfo()
        {
            Console.WriteLine($"Car Info: Brand: {brand}, Model: {model}, Year: {year}, Speed: {speed} km/h, Fuel Level: {fuelLevel}%");
        }
    }
public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Car Class Demo ===\n");

            // Tạo nhiều object Car với giá trị field khác nhau
            Car car1 = new Car("Toyota", "Camry", 2020, 0, 80);
            Car car2 = new Car("Honda", "Civic", 2019, 0, 60);
            Car car3 = new Car("Ford", "Mustang", 2021, 0, 40);

            // Gọi method của từng instance - mỗi object hoạt động độc lập
            car1.ShowInfo();
            car1.Accelerate(50);
            car1.Brake(20);
            car1.Refuel(30);

            Console.WriteLine();

            car2.ShowInfo();
            car2.Accelerate(70);
            car2.Brake(30);
            car2.Refuel(50);

            Console.WriteLine();

            car3.ShowInfo();
            car3.Accelerate(100);
            car3.Brake(50);
            car3.Refuel(20);
        }
    }
}
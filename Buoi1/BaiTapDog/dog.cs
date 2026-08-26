using System;
using System.Runtime.CompilerServices;

namespace ClassAndObjectsExercise
{
    // ================================
    // CLASS: Dog
    // ================================
    public class Dog
    {
        // ---- Fields (dữ liệu / state) ----
        private string name;
        private string breed;
        private int age;
        // ---- Constructor ----
        // Được gọi tự động khi ta dùng "new Dog(...)"
        public Dog( string name, string breed, int age)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
        }
 
        // ---- Methods (hành vi / behavior) ----
        public void bark()
        {
            Console.WriteLine($"{name} says: Woof! Woof!");
        }
        public void eat()
        {
            Console.WriteLine($"{name} is eating.");
        }
        public void sleep()
        {
            Console.WriteLine($"{name} is sleeping.");
        }
        // Getter methods - đọc dữ liệu ra ngoài
         public string GetName() => name;
        public string GetBreed() => breed;
        public int GetAge() => age;
        // Method in thông tin tổng hợp của con chó
        public void showinfo()
        {
            Console.WriteLine($"Name: {name}, breed: {breed}, age: {age} ");
        }
    
    }
 
    // ================================
    // CLASS: Main Program (theo yêu cầu 1.6:
    // "Create Main method on another class")
    // ================================
    public class Program
    {
         public static void Main(string[] args)
        {
            Console.WriteLine("=== Dog Class Demo ===\n");
 
            // Tạo nhiều object Dog với giá trị field khác nhau
            Dog tommy = new Dog("Tommy", "Golden Retriever", 3);
            Dog freedo = new Dog("Freedo", "Poodle", 2);
            Dog rex = new Dog("Rex", "German Shepherd", 5);
 
            // Gọi method của từng instance - mỗi object hoạt động độc lập
            tommy.showinfo();
            tommy.bark();
            tommy.eat();
 
            Console.WriteLine();
 
            freedo.showinfo();
            freedo.bark();
            freedo.sleep();
 
            Console.WriteLine();
 
            rex.showinfo();
            rex.bark();
            rex.eat();
 
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
    
}
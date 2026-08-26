using System;

namespace ClassAndObjectsExercise
{
    // ================================
    // CLASS: Book
    // ================================
    public class Book
    {
        // ---- Fields (dữ liệu / state) ----
        private string title;
        private string author;
        private double price;
        private bool isAvailable;

        // Field mới tự thêm (bước 5 trong đề bài)
        private int publishYear;

        // ---- Constructor ----
        // Sách mới tạo ra mặc định luôn có sẵn để mượn (isAvailable = true)
        public Book(string title, string author, double price, int publishYear)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.publishYear = publishYear;
            this.isAvailable = true;
        }

        // ---- Methods (hành vi / behavior) ----

        // Mượn sách - có kiểm tra logic (giống ý tưởng Encapsulation)
        public void Borrow()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine($"\"{title}\" has been borrowed successfully.");
            }
            else
            {
                Console.WriteLine($"\"{title}\" is currently unavailable (already borrowed).");
            }
        }

        // Trả sách
        public void Return()
        {
            if (!isAvailable)
            {
                isAvailable = true;
                Console.WriteLine($"\"{title}\" has been returned successfully.");
            }
            else
            {
                Console.WriteLine($"\"{title}\" was not borrowed, no need to return.");
            }
        }

        // Method mới tự thêm (bước 5): kiểm tra sách có phải "mới xuất bản" không
        // Quy ước: xuất bản trong vòng 2 năm gần đây (so với năm hiện tại) thì tính là mới
        public bool IsNewRelease()
        {
            int currentYear = DateTime.Now.Year;
            return (currentYear - publishYear) <= 2;
        }

        // Getter methods
        public string GetTitle() => title;
        public string GetAuthor() => author;
        public double GetPrice() => price;
        public bool GetIsAvailable() => isAvailable;
        public int GetPublishYear() => publishYear;

        // In thông tin tổng hợp
        public void ShowInfo()
        {
            string status = isAvailable ? "Available" : "Borrowed";
            string newTag = IsNewRelease() ? " [NEW RELEASE]" : "";
            Console.WriteLine(
                $"Title: {title} | Author: {author} | Price: {price:C} | " +
                $"Year: {publishYear} | Status: {status}{newTag}"
            );
        }
    }

    // ================================
    // CLASS: Main Program (tách riêng khỏi class Book)
    // ================================
    public class BookProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Book Class Demo ===\n");

            // Tạo 3 object Book với giá trị field khác nhau
            Book book1 = new Book("Clean Code", "Robert C. Martin", 35.99, 2008);
            Book book2 = new Book("The Pragmatic Programmer", "Andy Hunt", 42.50, 2019);
            Book book3 = new Book("C# in Depth", "Jon Skeet", 39.99, 2025);

            // In thông tin ban đầu
            book1.ShowInfo();
            book2.ShowInfo();
            book3.ShowInfo();

            Console.WriteLine("\n--- Testing Borrow / Return ---\n");

            // Mượn sách bình thường
            book1.Borrow();
            book1.ShowInfo();

            Console.WriteLine();

            // Yêu cầu thêm: gọi Borrow() 2 lần liên tiếp trên cùng 1 quyển sách
            book2.Borrow();       // lần 1: hợp lệ
            book2.Borrow();       // lần 2: không hợp lệ vì đã có người mượn
            book2.ShowInfo();

            Console.WriteLine();

            // Trả sách rồi mượn lại
            book1.Return();
            book1.ShowInfo();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
using System;

namespace ClassAndObjectsExercise
{
    // ================================
    // CLASS: Student
    // ================================
    public class Student
    {
        // ---- Fields (dữ liệu / state) ----
        private string name;
        private int age;
        private double score;
        private string major;

        // ---- Constructor ----
        public Student(string name, int age, double score, string major)
        {
            this.name = name;
            this.age = age;
            this.score = score;
            this.major = major;
        }

        // ---- Methods (hành vi / behavior) ----

        // Getter methods
        public string GetName() => name;
        public int GetAge() => age;
        public double GetScore() => score;
        public string GetMajor() => major;

        // Kiểm tra đậu / rớt
        public bool IsPassed()
        {
            return score >= 5.0;
        }

        // Phân loại học lực dựa theo điểm
        public string GetClassification()
        {
            if (score >= 8.0) return "Excellent";
            if (score >= 6.5) return "Good";
            if (score >= 5.0) return "Average";
            return "Weak";
        }

        // In thông tin tổng hợp
        public void ShowInfo()
        {
            Console.WriteLine(
                $"Name: {name} | Age: {age} | Major: {major} | " +
                $"Score: {score} | Passed: {IsPassed()} | Classification: {GetClassification()}"
            );
        }
    }

    // ================================
    // CLASS: Main Program
    // ================================
    public class StudentProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Student Class Demo ===\n");

            // Tạo nhiều object Student với giá trị field khác nhau
            Student s1 = new Student("Anna", 20, 8.5, "Computer Science");
            Student s2 = new Student("Minh", 21, 6.0, "Business Administration");
            Student s3 = new Student("Linh", 19, 4.2, "Marketing");

            // Gọi method của từng instance
            s1.ShowInfo();
            s2.ShowInfo();
            s3.ShowInfo();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
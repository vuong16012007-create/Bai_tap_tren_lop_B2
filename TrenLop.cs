using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
 
namespace StudentManagementExercise
{
    
    public class Student
    {

        private string name;
        private double score;
         private static int totalStudents = 0;
 
        public Student(string name, double score)
        {
            this.name = name;
            this.score = score;
            totalStudents++;   
        }

 
        public string GetName() => name;
 
        public double GetScore() => score;
 
        public bool IsPassed()
        {
            return score >= 5.0;
        }
 
        public string GetClassification()
        {
            if (score >= 8.0) return "Excellent";
            if (score >= 6.5) return "Good";
            if (score >= 5.0) return "Average";
            return "Weak";
        }
 
        public static int GetTotalStudents()
        {
            return totalStudents;
        }
 
        public static Student FindTopStudent(Student[] students)
        {
            if (students == null || students.Length == 0)
                return null;
 
            Student top = students[0];
            for (int i = 1; i < students.Length; i++)
            {
                if (students[i].score > top.score)
                {
                    top = students[i];
                }
            }
            return top;
        }
 
        public static double CalculateAverageScore(Student[] students)
        {
            if (students == null || students.Length == 0)
                return 0;
 
            double total = 0;
            foreach (Student s in students)
            {
                total += s.score;
            }
            return total / students.Length;
        }
    }
 

    public class Program
    {
        public static void Main(string[] args)
        {
            Student[] students = new Student[5]
            {
                new Student("Anna", 9.2),
                new Student("Minh", 6.0),
                new Student("Linh", 4.5),
                new Student("Khoa", 7.5),
                new Student("Trang", 8.0)
            };
            Console.WriteLine($"Total students created: {Student.GetTotalStudents()}\n");
            Console.WriteLine("--- Student List ---");
            foreach (Student s in students)
            {
                string status = s.IsPassed() ? "Passed" : "Failed";
                Console.WriteLine(
                    $"{s.GetName(),-10} | Score: {s.GetScore(),-5} | " +
                    $"Classification: {s.GetClassification(),-10} | Status: {status}"
                );
            }
 
            Student top = Student.FindTopStudent(students);
            Console.WriteLine($"\nTop student: {top.GetName()} with score {top.GetScore()}");
 
            double avg = Student.CalculateAverageScore(students);
            Console.WriteLine($"Class average score: {avg:F2}");
 
        }
    }
}
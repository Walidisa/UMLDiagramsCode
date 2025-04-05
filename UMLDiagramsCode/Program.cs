using System;

namespace UMLDiagramsCode
{
    class Program
    {
        static void Main(string[] args)
        {
           Student st1 = new Student("S001", "John Doe", "Computer Science", 3.5);
            st1.enroll("CS101");
            st1.enroll("CS102");
            st1.enroll("CS103");
            st1.drop("CS101");
            double gpa = st1.calculateGPA();
            Console.WriteLine("Student Details:");
            Console.WriteLine($"Student ID: {st1.StudentId}");
            Console.WriteLine($"Name: {st1.Name}");
            Console.WriteLine($"Major: {st1.Major}");
            Console.WriteLine($"GPA: {gpa}");
            Console.WriteLine($"Enrolled Courses: {string.Join(", ", st1.EnrolledCourses)}");
            Console.WriteLine();

            Product pr1 = new Product("P001", "Pixel 7 pro", "Google Pixel 7 pro phone", 899.99, 10, "Smart Phone");
            pr1.ApplyDiscount(0.2);
            pr1.UpdateStock(-1);
            Console.WriteLine("Product Details:");
            Console.WriteLine($"Product ID: {pr1.ProductId}");
            Console.WriteLine($"Name: {pr1.Name}");
            Console.WriteLine($"Description: {pr1.Description}");
            Console.WriteLine($"Price: {pr1.Price.ToString("F2")}");
            Console.WriteLine($"Stock Quantity: {pr1.StockQuantity}");
            Console.WriteLine($"Category: {pr1.Category}");
            Console.WriteLine($"Is In Stock: {pr1.IsInStock()}");
            Console.WriteLine();

            Movie mv1 = new Movie(101, "Dune Part 2", "Sci-Fi", 2024, 19.99, true);
            mv1.ApplyDiscount(0.2);
            mv1.UpdateStock(3);
            Console.WriteLine("Movie Details:");
            Console.WriteLine($"Movie ID: {mv1.MovieId}");
            Console.WriteLine($"Title: {mv1.Title}");
            Console.WriteLine($"Genre: {mv1.Genre}");
            Console.WriteLine($"Release Year: {mv1.ReleaseYear}");
            Console.WriteLine($"Price: {mv1.Price.ToString("F2")}");
            Console.WriteLine($"Availability: {mv1.IsInStock()}");
            Console.WriteLine($"Stock Quantity: {mv1.StockQuantity}");
            Console.WriteLine($"Is In Stock: {mv1.IsInStock()}");
            Console.WriteLine();

        }
    }
}

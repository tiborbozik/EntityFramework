// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System;
using System.Data.Entity;

namespace StudentDatabase
{
    // Define the Student entity
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // Define the context
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                // Create a new student
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe"
                };

                // Add the student to the context
                context.Students.Add(student);
                // Save changes to the database
                context.SaveChanges();

                // Output to confirm
                Console.WriteLine("Student added successfully.");
            }

            Console.ReadLine();
        }
    }
}

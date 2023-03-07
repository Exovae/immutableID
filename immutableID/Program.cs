using System;

class Student
{
    // auto-implemented properties
    public int Id { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // default constructor
    public Student()
    {
        Id = 0;
        FirstName = "";
        LastName = "";
    }

    // parameterized constructor with ID only
    public Student(int i)
    {
        Id = i;
        FirstName = "";
        LastName = "";
    }

    // parameterized constructor
    public Student(int i, string First, string Last)
    {
        Id = i;
        FirstName = First;
        LastName = Last;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // create a new student object with ID only
        Student student1 = new Student(1);

        // set the first name and last name properties
        student1.FirstName = "John";
        student1.LastName = "Doe";

        // create a second student object with ID and name
        Student student2 = new Student(2, "Jane", "Smith");

        // print out the values from both objects using the get methods
        Console.WriteLine("Student 1: ID-{0}, Name-{1} {2}", student1.Id, student1.FirstName, student1.LastName);
        Console.WriteLine("Student 2: ID-{0}, Name-{1} {2}", student2.Id, student2.FirstName, student2.LastName);
    }
}

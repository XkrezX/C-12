using System;
using System.Collections.Generic;

public class Address
{
    public string City { get; set; }
    public string Street { get; set; }
    public int HouseNumber { get; set; }
}

public class Student
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public DateTime BirthDate { get; set; }
    public Address HomeAddress { get; set; }
    public string PhoneNumber { get; set; }
    public List<int> Grades { get; } = new List<int>();

    public Student(string lastName, string firstName, string middleName, DateTime birthDate, Address homeAddress, string phoneNumber)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
        BirthDate = birthDate;
        HomeAddress = homeAddress;
        PhoneNumber = phoneNumber;
    }

    public Student(string lastName, string firstName, string middleName, DateTime birthDate, Address homeAddress, string phoneNumber, List<int> grades)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
        BirthDate = birthDate;
        HomeAddress = homeAddress;
        PhoneNumber = phoneNumber;
        Grades = grades;
    }

    public void AddGrade(int grade)
    {
        Grades.Add(grade);
    }

    public double CalculateAVG()
    {
        double sum = 0;
        foreach (int grade in Grades)
        {
            sum += grade;
        }
        return sum / Grades.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"First Name: {FirstName}");
        Console.WriteLine($"Middle Name: {MiddleName}");
        Console.WriteLine($"Birth Date: {BirthDate.ToShortDateString()}");
        Console.WriteLine($"Home Address: {HomeAddress.City}, {HomeAddress.Street}, {HomeAddress.HouseNumber}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
        Console.WriteLine($"Grades: {string.Join(", ", Grades)}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address
        {
            City = "Odesa",
            Street = "heroes of the defense of Odessa",
            HouseNumber = 22
        };

        Address address1 = new Address
        {
            City = "Odesa",
            Street = "Lusanovka",
            HouseNumber = 8
        };

        Student student1 = new Student("Yakuskin", "Arkadiy", "D.", new DateTime(2005, 1, 1), address, "555-1234");
        student1.AddGrade(80);
        student1.AddGrade(90);
        student1.AddGrade(85);
        student1.DisplayInfo();

        Student student2 = new Student("Potapov", "Valeriy", "V.", new DateTime(2006, 3, 15), address1, "555-7645", new List<int> { 70, 75, 80 });
        student2.DisplayInfo();

        Console.WriteLine($"{student2.FirstName} {student2.LastName} has an avg of {student2.CalculateAVG()}");
    }
}

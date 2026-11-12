using System;
using System.Linq;

class Student
{
    public string name;
    public string surname;
    public int age;
    public string university;
}

class Program
{
    static void Main()
    {
        //1

        int[] numbers = { 1, 8, 14, 21, 32, 40, 49, 56, 63 };

        Console.WriteLine("All numbers:");
        Console.WriteLine(string.Join(" ", numbers));

        Console.WriteLine("Even:");
        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));

        Console.WriteLine("Odd:");
        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));

        Console.WriteLine("Greater than 20:");
        Console.WriteLine(string.Join(" ", numbers.Where(x => x > 20)));

        Console.WriteLine("From 10 to 50:");
        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= 10 && x <= 50)));

        Console.WriteLine("Divisible by 7:");
        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 7 == 0).OrderBy(x => x)));

        Console.WriteLine("Divisible by 8:");
        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 8 == 0).OrderByDescending(x => x)));


        //2

        string[] cities = { "Amsterdam", "New York", "London", "Neapol", "Nantes", "Berlin", "Miami" };

        Console.WriteLine("All cities:");
        Console.WriteLine(string.Join(", ", cities));

        Console.WriteLine("Length is 6:");
        Console.WriteLine(string.Join(", ", cities.Where(x => x.Length == 6)));

        Console.WriteLine("Starts with A:");
        Console.WriteLine(string.Join(", ", cities.Where(x => x.StartsWith("A"))));

        Console.WriteLine("Ends with M:");
        Console.WriteLine(string.Join(", ", cities.Where(x => x.EndsWith("M"))));

        Console.WriteLine("Starts with N and ends with K:");
        Console.WriteLine(string.Join(", ", cities.Where(x => x.StartsWith("N") && x.EndsWith("K"))));

        Console.WriteLine("Starts with Ne:");
        Console.WriteLine(string.Join(", ", cities.Where(x => x.StartsWith("Ne")).OrderByDescending(x => x)));


        //3

        Student[] students =
        {
            new Student { name = "Boris", surname = "Brown", age = 21, university = "MIT" },
            new Student { name = "John", surname = "Brooks", age = 19, university = "Oxford" },
            new Student { name = "Anna", surname = "Smith", age = 22, university = "Oxford" },
            new Student { name = "Boris", surname = "Wilson", age = 18, university = "MIT" },
            new Student { name = "Alex", surname = "Brown", age = 24, university = "Harvard" }
        };

        Console.WriteLine("All students:");
        foreach (var s in students)
            Console.WriteLine(s.name + " " + s.surname + " " + s.age + " " + s.university);

        Console.WriteLine("Name Boris:");
        foreach (var s in students.Where(x => x.name == "Boris"))
            Console.WriteLine(s.name + " " + s.surname);

        Console.WriteLine("Surname starts with Bro:");
        foreach (var s in students.Where(x => x.surname.StartsWith("Bro")))
            Console.WriteLine(s.name + " " + s.surname);

        Console.WriteLine("Older than 19:");
        foreach (var s in students.Where(x => x.age > 19))
            Console.WriteLine(s.name + " " + s.age);

        Console.WriteLine("Age between 20 and 23:");
        foreach (var s in students.Where(x => x.age > 20 && x.age < 23))
            Console.WriteLine(s.name + " " + s.age);

        Console.WriteLine("Students in MIT:");
        foreach (var s in students.Where(x => x.university == "MIT"))
            Console.WriteLine(s.name);

        Console.WriteLine("Oxford students older than 18:");
        foreach (var s in students.Where(x => x.university == "Oxford" && x.age > 18).OrderByDescending(x => x.age))
            Console.WriteLine(s.name + " " + s.age);


        //4

        string[] words = { "Apple", "Car", "Banana", "Hi", "Orange", "Watermelon" };

        Console.WriteLine("Ascending:");
        Console.WriteLine(string.Join(", ", words.OrderBy(x => x.Length)));
        Console.WriteLine("Descending:");
        Console.WriteLine(string.Join(", ", words.OrderByDescending(x => x.Length)));
    }
}
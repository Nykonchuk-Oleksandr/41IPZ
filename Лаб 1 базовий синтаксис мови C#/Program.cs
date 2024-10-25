using System;
using System.Collections.Generic;

class Program
{
    class Student
{
    public string Name { get; set; }
    public List<int> Grades { get; set; }

    public Student(string name, List<int> grades)
    {
        Name = name;
        Grades = grades;
    }
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

class Bookstore
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }

    public Bookstore(string name, List<Book> books)
    {
        Name = name;
        Books = books;
    }
}

class Point3D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
}

class User
{
    public string Username { get; set; }
    public string Password { get; set; }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }
}
class Programs
{
    void ModifyValues(ref int a, ref int b)
    {
        a += 1;
        b -= 2;
    }

    void SumArrayElements()
    {
        List<int> numbers = new List<int>();
        int input;
        do
        {
            Console.Write("Введіть число (0 для завершення): ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
                numbers.Add(input);
        } while (input != 0);

        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"Сума елементів: {sum}");
    }

    void InitializeAndModify2DArray()
    {
        double[,] array = {
        { 1.0, 0.0, -2.0 },
        { 0.0, 3.0, 4.0 },
        { -1.0, 0.0, 5.0 }
    };

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == 0)
                    array[i, j] = 1;
                else if (array[i, j] < 0)
                    array[i, j] = 0;
            }
        }
    }

    void ReplaceZerosWithAverage()
    {
        double[,] array = {
        { 1.0, 0.0, -2.0 },
        { 0.0, 3.0, 4.0 },
        { -1.0, 0.0, 5.0 }
    };

        double sum = 0;
        int count = 0;

        foreach (var value in array)
        {
            sum += value;
            count++;
        }

        double average = sum / count;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == 0)
                    array[i, j] = average;
            }
        }
    }

    class Cuboid
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Cuboid(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double this[int index]
        {
            get
            {
                return index switch
                {
                    0 => Length,
                    1 => Width,
                    2 => Height,
                    _ => throw new IndexOutOfRangeException("Неправильний індекс")
                };
            }
            set
            {
                switch (index)
                {
                    case 0: Length = value; break;
                    case 1: Width = value; break;
                    case 2: Height = value; break;
                    default: throw new IndexOutOfRangeException("Неправильний індекс");
                }
            }
        }
    }

    void PrintWordsInNewLines(string sentence)
    {
        string[] words = sentence.Split(' ');
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }

    void ConcatenateWords(string sentence)
    {
        string[] words = sentence.Split(' ');
        string result = string.Join("", words);
        Console.WriteLine(result);
    }
}


    void ModifyValues(ref int a, ref int b)
    {
        a += 1;
        b -= 2;
    }

    void SumArrayElements()
    {
        List<int> numbers = new List<int>();
        int input;
        do
        {
            Console.Write("Введіть число (0 для завершення): ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
                numbers.Add(input);
        } while (input != 0);

        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"Сума елементів: {sum}");
    }

    // Інші методи тут

    public static void Main(string[] args)
    {
        Program program = new Program();
        program.SumArrayElements();

        // Виклик інших методів для тестування
    }
}

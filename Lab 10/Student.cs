using System;

class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public double Marks { get; set; }

    public Student(string name, int id, double marks)
    {
        Name = name;
        ID = id;
        Marks = marks;
    }

    public char GetGrade()
    {
        if (Marks >= 90) return 'A';
        if (Marks >= 80) return 'B';
        if (Marks >= 70) return 'C';
        if (Marks >= 60) return 'D';
        return 'F';
    }

    public void DisplayStudent()
    {
        Console.WriteLine($"Name: {Name}, ID: {ID}, Marks: {Marks}, Grade: {GetGrade()}");
    }
}

class StudentIITGN : Student
{
    public string Hostel_Name_IITGN { get; set; }

    public StudentIITGN(string name, int id, double marks, string hostel) : base(name, id, marks)
    {
        Hostel_Name_IITGN = hostel;
    }

    public void DisplayIITGNStudent()
    {
        DisplayStudent();
        Console.WriteLine($"Hostel: {Hostel_Name_IITGN}");
    }
}

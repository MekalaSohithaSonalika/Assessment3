class Program
{
    static void Main()
    {
        Student student1 = new Student("John Doe", 101, 85);
        student1.DisplayStudent();

        StudentIITGN iitgnStudent = new StudentIITGN("Jane Doe", 102, 92, "Himalaya");
        iitgnStudent.DisplayIITGNStudent();
    }
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<Student> studentslist = new List<Student>();
Student s1 = new Student("Mona", 123456789);
Student s2 = new Student("Pooja", 4561237945);
Student s3 = new Student("Shweta", 4567956562);
studentslist.Add(s1);
studentslist.Add(s2);
studentslist.Add(s3);
class Student
{
    public string Name;
    public long Phone;
    

    public Student(string name,long phone)
    {
        this.Name = name;
        this.Phone = phone;
    }
}
class College
{
    string clgname;
    List<Student> stud;

    public void displaystudent(List<Student> stud)
    {
        foreach (Student student in stud)
        {
            Console.WriteLine($"student name :{student.Name},phone :{student.Phone}");
        }
    }
    public  College(List<Student>stud)
    {
        this.stud = stud;
    }
}

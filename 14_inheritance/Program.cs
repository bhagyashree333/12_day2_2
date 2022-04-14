// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
////SINGLE LEVEL INHERITANCE
//Console.WriteLine("called display and accesss from obj of w1");
//wxp1 w1=new wxp1();     //display and access are methods from wxp1
//w1.display();
//w1.access();

//Console.WriteLine("called display.camera and accesss from obj of w2");
//wxp2 w2=new wxp2();    //but xp2 is wxp1 child so we can use them
//w2.display();
//w2.access();
//w2.camera();

////but if we stopped wxp1 but we still want all only feartures of wxp1then
//Console.WriteLine("called display and accesss from obj w3 with reference type wxp1");
//wxp1 w3=new wxp2();
//w3.display();
//w3.access();
////w3.camera();     //here we cant use camera bcoz camera is method of wxp2 class and here we are using ref type wxp1
//class wxp1
//{
//    public void display()
//    {
//        Console.WriteLine("hi xp1 display");
//    }
//    public void access()
//    {
//        Console.WriteLine("hi xp1 access");
//    }
//}
//class wxp2 : wxp1
//{
//    public void camera()
//    {
//        Console.WriteLine(" hi xp2 camera");
//    }
//}

//-----------------------------------------------------------------------------------------------
//multilevel inheritance

//A a=new A();

//B b=new B();
//b.Bshow();
//C c=new C();
//c.Bshow();
//c.Cshow();

//B c1=new C();
//c1.Bshow();
////c1.Cshow();
//class A
//{
//    protected void Ashow()
//    {
//        Console.WriteLine("Ashow protected one");
//    }
//}
//class B : A
//{
//    public void Bshow()
//    {
//        Console.WriteLine("Bshow B:A ");
//        Ashow();
//    }
//}
//class C : B
//{
//    public void Cshow()
//    {
//        Console.WriteLine("c show C:B");
//    }
//}


//------------------------------------------------------------------------------------------------

//HERE WE ARE PASSING OBJECT OF ONE CLASS AS PARAMETER OF ANOTHER CLASS
Address add = new Address("Nagar", "savedi");
Address add2 = new Address("pune", "nashik");

Student s = new Student("Mona", add);
Student s1 = new Student("pooja", add);
Student s3 = new Student("salim", add2);

s.display();
s1.display();
s3.display();

    class Address
{
    public string city;
    public string dist;
    public Address(string city, string dist)
    {
        this.city = city;
        this.dist = dist;
    }

}
class Student
{
    string name;
    public Address address;
    public Student(string nm,Address addr)
    {
        this.name = nm;
        this.address = addr;

    }
    public void display()
    {
        Console.WriteLine($"{name}, {address.city},{address.dist}");
    }
}




// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//A a=new(5,5);  //object

//Console.WriteLine (a.Add());
//Console.WriteLine( a.Mul());
//Console.WriteLine( a.div());
//class A
//{
//    public int a;
//    public int b;
//    public A(int a1,int b1)         //constructor
//    {
//      a= a1; 
//      b= b1;
//    }
//  public int Add()
//    {
//        return a + b;
//    }
//  public  int Mul()
//    {
//        return a * b;
//    }
//  public  int div()
//    {
//        return a/b;
//    }
//}

//-----------------------------------------------------------------------------------------------------------------------
//EX = 2
//-----------------------------------------------------------------------------------------------------------------------
//Student s = new Student("bk", 1, "nagar", 12346789);//object
//Student p = new Student("pg", 2, "savedi", 444444);
////s.phone=5555555555;
////s.address = "kedgaon";
//s.newclg("zzzz");
//s.display();
//p.display();

//Console.WriteLine(Student._clgnm);

//class Student
//{
//    string _name;
//    int _id;
//    string _address;
//    long _phone;
//    public static string _clgnm = "nagar";

//    public Student(string nm, int id, string addr, long phn)
//    {
//        this._name = nm;
//        this._id = id;
//        this._address = addr;
//        this._phone = phn;


//    }
//    public void display()
//    {
//        Console.WriteLine($"Name: {_name},Id :{_id},Addresss : {_address},Phone :{_phone},Collegename :{_clgnm}");
//    }
//    public void update()
//    {
//        Console.WriteLine("enter new no");
//        long no = long.Parse(Console.ReadLine());
//        this._phone = no;

//        Console.WriteLine("enter new name");
//        string nm = Console.ReadLine();
//        this._name = nm;

//    }
//    public void newclg(string clgnm)
//    {
//        // this._clgnm=clgnm;
//    }
//}
//-----------------------------------------------------------------------------------------------------------------------
//EX = 2
//------------------------------------------------------------------------------------------------------

Employee emp1 = new Employee(1, "mk", "nagar", 82081456789);
emp1.display();
class Employee
{
    int _eid;
    string _ename;
    string _eaddr;
    long _ephn;

    public Employee(int eid,string ename,string eaddr,long ephn)
    {
        this._eid = eid;
        this._ename = ename;
        this._eaddr = eaddr;
        this._ephn = ephn;

    }
    public void display()
    {
        Console.WriteLine($"Employee id:{_eid},Employee name :{_ename},Employee adress:{_eaddr},Employee phn :{_ephn}");
    }
}
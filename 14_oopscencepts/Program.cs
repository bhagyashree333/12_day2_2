// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//COUNT INSTANCES IN CLASS
//B a = new B();
//a.displayB();
//B a2=new B();
//a2.getCount();
//class A
//{
//    public static int Count = 0;

//    public A()
//    {
//        Count++;

//    }
//    protected void display()
//    {
//        Console.WriteLine(" A display");
//    }
//}

//class B : A
//{
//    public B()
//    {
//        Count++;

//    }
//    public void displayB()
//    {
//        Console.WriteLine("B display");
//        display();
//    }

//    public void getCount()                       //use void bcoz we are not returning anything
//    {
//        Console.WriteLine( Count);
//    }
//}

//STATIC CLASS


//static class Math
//{
//    public static int Add(int a,int b)    //a,b are static local variables
//    {

//        return a + b;
//    }
//    public static int mul(int a,int b)
//    {
//        return a * b;
//    }
//    public static int  div(int a,int b)
//    {
//        return a / b;
//    }
//}


//CALL BY REFERENCE
//void myfun(ref int a)
//{
//    a = 50;
//}
//int a = 10;
//myfun(ref a);
//Console.WriteLine("a="+ a);  //50

////CALL BY VALUE
//void myfun2(int b)
//{
//    b = 20;
//}
//int b = 10;  //global ahe
//myfun2(a);
//Console.WriteLine(b);  //10


//SCOPE EXAMPLE 1                                                //??
//void myfun3()
//{
//    int a = 56;
//    if (a < 58)
//    {
//        int b1 = 70;
//    }
//    else
//    {
//        Console.WriteLine("a is bigger");
//    }
//    Console.WriteLine("a is small="+a);
//}

//SCOPE EXAMPLE 2
//for(int j=0; j<5; j++)
//{
//    Console.WriteLine("hii");
//}
//Console.WriteLine(j);   CANT ACCES J HERE BCOZ ITS SCOPE ENDS ABOVE




//GET SET

//Student s = new Student();
//s.nameInfo = "bhagyashree";       //we are setting val here
//Console.WriteLine(s.nameInfo);  
//class Student
//{
//    int id;
//    string name;

//    public string nameInfo
//    {
//        get 
//        { return this.name; }
//        set
//        {
//            this.name = value;  
//        }
//    }

//}



//Account question

Account user1=new Account(111,"Nm muley",50000,"saving");
user1.display();
user1.updatenm = "Nilima";
user1.upbalance = 1000000;
user1.upaccType = "current";
user1.display();
class Account
{
    int _accNum;
    string _accName;
    double _balance;
    string _accType;

    public Account(int accNum,string accName,double balance,string acctype)
    {
        this._accNum = accNum;
        this._accName = accName;
        this._balance = balance;
        this._accType = acctype;

    }
    public string updatenm
    {
        get { return this._accName; }
        set { this._accName = value; }
    }
    public double upbalance
    {
        get { return this._balance; }
        set { this._balance = value; }
    }
    public string upaccType
    {
        get { return this._accType; }
        set { this._accType = value; }
    }
    public void display()
    {
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine($"|{_accNum} ,  {_accName}       {_balance},  {_accType}      |");
        Console.WriteLine("--------------------------------------------------------------");
    }
}

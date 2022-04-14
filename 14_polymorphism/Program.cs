// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//OVERLOADING

//A a = new A();
//a.show();
//a.show(5,6);
//a.show(5.5F);
//a.show(5,6.7F);
//a.show(6);
//class A
//{
//    public void show()
//    {
//        Console.WriteLine("showing 1");
//    }
//    public void show(int a)
//    {
//        Console.WriteLine("showing with parameter int a");
//    }
//    public void show(float b)
//    {
//        Console.WriteLine("showing with float b" + b);
//    }
//    public void show(int a,int b)
//    {
//        Console.WriteLine("int" +a+"int"+ b);
//    }
//    public void show(int a,float b)
//    {
//        Console.WriteLine("int a float b");
//    }
//}


//-------------------------------------------------------------------------------------------------
//OVERRIDING

Animal a=new Animal();
a.eat();
 Animal a1=new Dog();
a1.eat();   

Animal a2=new cow();
a2.eat();
labro a3=new ();

class Animal
{
    public virtual void eat()
    {
        Console.WriteLine("eating style");
    }
}
class Dog:Animal
{
public override void eat()
    {
        Console.WriteLine("licking for dog");
    }
}

class labro : Dog
{
    public override void eat()
    {
       Console.WriteLine("this is for labro");
    }
}
class cow:Animal
{
    public override void eat()
    {
        Console.WriteLine("ravanth for cow");
    }
}



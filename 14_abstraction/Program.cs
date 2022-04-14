// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Animal a = new Dog();
a.sound();

a.showing();


Animal b = new Cow();
b.sound();
b.sound();
abstract class Animal
{
    public abstract void sound();
    public void showing()
    {
        Console.WriteLine("showing method in abstract class");
    }
}
class Dog : Animal
{
    public void display()
    {
        Console.WriteLine("calling dog");
    }
    public override void sound()
    {
        Console.WriteLine("bhoww");
    }
    public void eat()
    {
        Console.WriteLine("dog eating");
    }
}
class Cow: Animal
{
    public void display()
    {
        Console.WriteLine("calling cow");
    }
    public override void sound()
    {
        Console.WriteLine("something");

        }
    public void eat()
    {
        Console.WriteLine("cow eating");
    }
    }


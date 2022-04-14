// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Cat c=new Cat();
c.sound();
c.behaviour();

Cow cow1=new Cow();
cow1.sound();
cow1.behaviour();

Lion lion1=new Lion();
lion1.sound();  
lion1.behaviour();
interface IAnimal
{
    public void sound();
    public void behaviour();
}


class Cat : IAnimal
{
    public void behaviour()
    {
        Console.WriteLine("running ");
    }

    public void sound()
    {
        Console.WriteLine("meow meow");
    }
}
class Cow : IAnimal
{
    public void behaviour()
    {
        Console.WriteLine("walk");
    }

    public void sound()
    {
        Console.WriteLine("mhaaaaaa");
    }
}

class Lion : IAnimal
{
    public void behaviour()
    {
       Console.WriteLine("hunt");
    }

    public void sound()
    {
        Console.WriteLine("roar");
    }
}
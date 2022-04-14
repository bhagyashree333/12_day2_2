// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Console.WriteLine("enter any number you want to check");
//int a=int.Parse(Console.ReadLine());

// if (IsoddEven(a))
//{
//    Console.WriteLine("even");
//}
//else
//{
//    Console.WriteLine("odd");
//}

// bool IsoddEven(int a)
//{
//    if(a%2==0)
//        return true;
//    else
//        return false;
//}



//ex2

//float myfunc(float f) //para
//{
//    Console.WriteLine("hi");
//    return 0;
//}

//myfunc(20);//arg

//--------------------------------------------------------------------------------------------------------------------------

//
//void myfunc( )
//{
//    return;
//}
//myfunc();


//--------------------------------------------------------------------------------------------------------------------------
////CHECK PRIME USING FUNCTION

//Console.WriteLine("enter num");
//int no = int.Parse(Console.ReadLine());

//if (isPrime(no))
//{
//    Console.WriteLine("prime ");

//}
//else
//    Console.WriteLine("not prime");

//bool isPrime(int no)                     //we are returning true false out of func hence return type of func is bool
//{
//    for (int i = 2; i < no; i++)
//    {
//        if (no % i == 0)
//        {
//            return false;
//        }
//    }
//    return true;
//}

//--------------------------------------------------------------------------------------------------------------------------


//CHECK ODD EVEN USING FUNCTION 


//for (int i = 0; i <= 100; i++)
//{
//  if (oddeventcheck(i))                //here i am calling func
// {
// console.writeline("even="+ i);
// }
//  else
// {
//  console.writeline("odd="+i);
// }
//}
//bool oddeventcheck(int i)           //here i am initializing function
//{
//  if (i % 2 == 0)
//  {
//      return true;

//}
//   return false;
//}


//-----------------------------------------------------------------------------------------------------------

Console.WriteLine("enter  odd no or even");
string stype = Console.ReadLine();

Console.WriteLine("enter how many num you want");
int num = int.Parse(Console.ReadLine());

if(stype == "even")
{
    Even(num);
}
else if(stype =="odd")
{
    Odd(num);
}

void Even(int num)
{
    for (int i = 0; i < num; i++)
    { 
        if (i % 2 == 0)
            Console.WriteLine(i);    
    }
}

void Odd(int num)
{
    for(int i = 0; i <num; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
}


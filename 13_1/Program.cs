// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

////*                          *
////        *             *
////                *
////        *              *
////*                           *


//int row = 5;
//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < row; j++) 
//    {
//        if (i == j || ((i + j) == row - 1))
//        {
//            Console.Write("*\t");
//        }
//        else
//        {
//            Console.Write("\t");
//        }
//    }
//    Console.WriteLine();
//}

//-------------------------------------------------------------------------------------------------------------




////ARRAY FIND LARGEST NO FROM DYNAMIC ARRAY
//Console.WriteLine("enter row no");
//int row = int.Parse(Console.ReadLine());
//Console.WriteLine("enter col no");
//int col=int.Parse(Console.ReadLine());
//Console.WriteLine("enter "+row*col +" nums to add in your array");

//int[,] arr=new int[row,col];
//for(int i=0;i<row;i++)
//{
//    for(int j=0;j<col;j++)
//    {
//        arr[i,j] = int.Parse(Console.ReadLine());          //for reading
//    }
//}
//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < col; j++)
//    {
//        Console.Write(arr[i, j]+"\t");                       //for printing

//    }
//    Console.WriteLine();
//}

//for(int i=0;i<row;i++)
//{
//    for(int j=0;j<col;j++)
//    {
//        if (arr[i, j] > largeno)
//        {
//            largeno = arr[i, j];
//        }

//    }
//}


////for prime
// bool checkPrime(int val)
//{
//    for (int i = 2; i < val; i++)
//    {
//        if (val % i == 0)
//        {
//            return false;
//        }
//    }
//    return true;

//}
//var largeno = 0;
//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < col; j++)
//    {
//        if (arr[i, j] > largeno)
//        {
//            largeno = arr[i, j];
//        }
//        if (checkPrime(arr[i,j]))
//        {
//            Console.WriteLine(arr[i,j]+"is prime");
//        }
//        else
//        {
//            Console.WriteLine("not prime");
//        }
//    }
//}
//Console.WriteLine("larger no =" + largeno);
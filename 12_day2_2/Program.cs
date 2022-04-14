// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//1] NORMAL ALL ZERO MATRIX
//for(int i = 1; i <= 3; i++)       //row
//{
//    for (int j = 1; j <= 4; j++)       //col
//    {
//        Console.Write(" 0 \t");
//    }
//    Console.WriteLine("");
//}

//--------------------------------------------------------------------------------------------------------
//6X6

//for(int i = 1; i <=6; i++)           //row
//{
//    for(int j = 1; j<=6; j++  )          //col
//    {
//        if (i== 2)
//        {
//            Console.Write("2 \t");          //we want it in single line so write
//        } else
//        {
//            Console.Write("1 \t");
//        }
//    }
//    Console.WriteLine();
//}

//--------------------------------------------------------------------------------------------------------

//for(int i=1;i<=3;i++)
//{
//    for(int j=1;j<=3;j++)
//    {
//        if(i==2 && j==2)
//        {
//            Console.Write("1 \t");
//        }else
//            Console.Write("0 \t");
//    }
//    Console.WriteLine();
//}

//--------------------------------------------------------------------------------------------------------

//print 1 in diagonal

//Console.WriteLine("enter row no");
//int row=int.Parse(Console.ReadLine());

//Console.WriteLine("enter col no ");
//int col=int.Parse(Console.ReadLine());

//for (int i = 1; i<= row; i++)
//{
//    for(int j = 1; j<= col; j++)
//    {
//        if (i == j )
//        {
//            Console.Write("1 \t");
//        }
//        else
//            Console.Write("0\t");
//    }
//    Console.WriteLine();
//}

//--------------------------------------------------------------------------------------------------------

//for(int i=1;i<=row;i++) //row
//{
//    for(int j=0;j<=col;j++)   //col
//    {
//        if (i == 1 && j == 1)
//            Console.Write("1 \t");
//        else if (i == 2 && j == 1)
//            Console.Write("2\t");
//        else if (i == 2 && j == 2)
//            Console.Write("3\t");
//        else if (i == 3 && j == 1)
//            Console.Write("4\t");
//        else if (i == 3 && j == 2)
//            Console.Write("5 \t");
//        else if (i == 3 && j == 3)
//            Console.Write("6\t");
//    }
//    Console.WriteLine();
//}



//--------------------------------------------------------------------------------------------------------
//(3,4)
//|1      |
//|2 3    |
//|4 5 6  |

//int a = 1;
//for (int i = 1; i<= 4; i++) //row
//{
//    for (int j = 1; j<= 4; j++)   //col
//    {
//        if (j <= i)
//        {
//            Console.Write(a + " \t");
//        }
//        else
//        {
//            Console.Write("0 \t");
//        }
//        a++;     
//    }

//    Console.WriteLine();
//}

//--------------------------------------------------------------------------------------------------------
//multidiamentional array
//Console.WriteLine("enter val row");
//int[,] arr = new int[3, 3];
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.WriteLine("enter val for col");
//        arr[i, j] = int.Parse(Console.ReadLine());
//    }

//}
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write(arr[i, j] + "\t");

//    }
//}
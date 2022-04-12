// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//ARRAY 

//int[] myint;

//string[] MystringArray = new string[10];

//int[] MyintArray = { 1,2,3 };

//int[] myarr2 = new int[5];
//myarr2[0] = 50;
//myarr2[1] = 60;
//myarr2[2] = 70;
//myarr2[3] = 80;
//myarr2[4] = 90;
////Console.WriteLine(myarr2[4]);
//for (int i = 0; i < myarr2.Length; i++)
//{
//    Console.WriteLine(myarr2[i]);
//}

//accept vals from user store in array and display them

//int[] myarr3 = new int[5];
//Console.WriteLine("enter no to add in array");
//for (int i = 0; i < 5; i++)          //this for loop for storing
//{
//    myarr3[i] = int.Parse(Console.ReadLine());

//}
//for (int j = 0; j < 5; j++)           //this for loop for displaying
//{
//    Console.WriteLine(myarr3[j] + "\t");
//}

//----------------------------------------------------------------------------------------------------------
//int[,] arr2=new int[3,3];
//for(int i=0; i<3; i++)
//{
//    for(int j=0; j<3; j++)
//    {
//        arr2[i,j]=int.Parse(Console.ReadLine());      ///for accepting /reading

//    }

//}
//for(int i=0; i<3; i++)
//{
//    for(int j=0;j<3; j++)
//    {
//        if (arr2[i,j] % 5 == 0)

//            Console.Write("* \t");
//        else
//            Console.Write(arr2[i, j]+"\t");

//    }
//    Console.WriteLine();
//}


//----------------------------------------------------------------------------------------------------------
//int[,] arr3=new int[5,5];
//for(int k=0; k<5; k++)     //row
//{
//    for(int l=0; l<5; l++)    //col
//    {
//        if (k < l)                   //row<col
//            Console.Write(" *\t");
//        else
//            Console.Write(" \t");
//    }
//    Console.WriteLine();
//}

//----------------------------------------------------------------------------------------------------------

//Console.WriteLine("enter row no");
//int row = int.Parse(Console.ReadLine());

//int col = row;

//for (int i = 0; i<row; i++)
//{
//    for (int j = 0; j<col;j++)
//    {
//        if (i == 0 || i == row-1 ||j==0 ||j==row-1)
//            Console.Write("*\t");
//        else
//            Console.Write("\t");

//    }
//    Console.WriteLine();
//}


//----------------------------------------------------------------------------------------------------------

//L

//for(int i = 0; i<5;i++)
//{
//    for(int j=0;j<5;j++)
//    {
//        if(j==0 || i==4)
//        {
//            Console.Write("*\t");
//        }
//    }
//    Console.WriteLine();
//}

//----------------------------------------------------------------------------------------------------------

//for (int k=0;k<5;k++) //r
//{
//    for(int l=0;l<5;l++) //c
//    {
//        if(k==4 || l==4)
//        {
//            Console.Write("*\t");
//        }
//        else
//        Console.Write("\t");
//    }
//    Console.WriteLine();
//}


//----------------------------------------------------------------------------------------------------------


//p

for (int r=0;r<=6;r++)
{
    for(int c=0;c<=4;c++)
    {
        if((r==0 ||r==3 ||c==0)|| (c == 4) &&  (r < 3))
        {
            Console.Write("*\t");
        }
        else
        Console.Write("\t");

    }
    Console.WriteLine();
}
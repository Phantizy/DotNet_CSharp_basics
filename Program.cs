// See https://aka.ms/new-console-template for more information
Console.WriteLine("My name is Elijah Phillips");
Console.WriteLine("Lets Learn C# Programming");

float baseSalary = 5000;
float hra = 0.30F;
float netSalary =(baseSalary -(baseSalary * hra));
Console.WriteLine("Base Salary:" + baseSalary);
Console.WriteLine("Net Salary:" + netSalary);

int temp = 50;
if (temp < 20)
    Console.WriteLine("It's pretty cold outside");
else
    Console.WriteLine("It's Ok outside");

bool isLoggedIn = true;
bool isEmailVerified = true;
bool cardInfo = true;
if(isLoggedIn && isEmailVerified && cardInfo)
    Console.WriteLine("Allowed to make a purchase");
else
    Console.WriteLine("Stop purchase");

int[] marks = new int[5] {45,50,55,60,75};

foreach (int mark in marks)
    Console.WriteLine(mark);

for (int i=0; i < marks.Length; i++)
    Console.WriteLine(marks[0]);

int[,] multiArray = new int[3,4]
    {{1,2,3,4},{1,2,3,4},{1,2,3,4}};

for (int i=0;i <=2;i++)
{
    for(int j =0; j <=3; j++)
    {
        Console.WriteLine(multiArray[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

int[][] jaggedArray = new int[2][];
jaggedArray[0] = new int[2];
jaggedArray[1] = new int[3];

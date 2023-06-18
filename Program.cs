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

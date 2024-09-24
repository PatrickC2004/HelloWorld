// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");

Console.WriteLine("type first number");
int firstnum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("type second number");
int secondnum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The sum of the numbers is " + (firstnum + secondnum));


Console.WriteLine("Please enter your name");
string name  = Console.ReadLine();

Console.WriteLine("Please enter your age");
int age= Convert.ToInt32(Console.ReadLine());

if(age < 1 ||  age > 110)
{
    Console.WriteLine("invalid age ");
    return;
}

int futureAge = age + 5;

Console.WriteLine("hello " + name + " you will be "+ futureAge+" in five years");

if(age < 13)
{
    Console.WriteLine("You are a child");
}
else if(age > 13 && age <20)
{
    Console.WriteLine("You are a teenager");
}
else if (age >= 20)
{
    Console.WriteLine("You are an adult");
}

Console.WriteLine("Please enter number");
int number= Convert.ToInt32(Console.ReadLine());

if(number == 0)
{
    Console.WriteLine(number+" is zero");
}

else if (number % 2 == 0)
{
    Console.WriteLine(number + " is positive");
}
else 
{
    Console.WriteLine(number+" is negative");
}

Console.WriteLine("Please enter year");
int year =Convert.ToInt32(Console.ReadLine());

if(year %4 == 0)
{
    Console.WriteLine("The year "+year+" is a leap year");
}
else
{
    Console.WriteLine("The year " + year + " is not a leap year");
}

Console.WriteLine("Please enter number");
int oddOrEven=Convert.ToInt32(Console.ReadLine());

 if (oddOrEven % 2 == 0)
{
    Console.WriteLine(oddOrEven + " is Even");
}
else
{
    Console.WriteLine(oddOrEven + " is Odd");
}
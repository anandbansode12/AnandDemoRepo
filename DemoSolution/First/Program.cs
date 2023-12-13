// See https://aka.ms/new-console-template for more information
using First;

Console.WriteLine("Calculator for Addition");

Console.WriteLine("Value of a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Value of b: ");
int b = int.Parse(Console.ReadLine());

Calculator calculator = new Calculator();
calculator.Add(a, b);

Console.ReadLine();

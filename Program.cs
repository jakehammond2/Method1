// See https://aka.ms/new-console-template for more information

Console.WriteLine("What is your name?");
string name = Console.ReadLine();

Console.WriteLine("What is your age?");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is your favorite animal?");
string animal = Console.ReadLine();

Console.WriteLine($"My name is {name} and I am {num} years old. My favorite animal is a {animal}.");
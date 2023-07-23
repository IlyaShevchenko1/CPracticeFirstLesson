 /* int intNumber = 25; //Целые числа
double doubleNumber =12.5; // Дробные числа
string "text";
bool logicVar = true;
*/

/*
int num = 5;
int num1 = 10;
int num2 = 15;
Console.WriteLine ("My number is " + num);
Console.WriteLine ("My numbers are " + num1 + " and " + num2 + " and it is good");
Console.WriteLine ($"My numbers are {num1} and {num2} and it is good");
*/
/*
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your number is " + num);
*/

// Task 1. Напишите программу, которая на входпринимает два числа и проверяет,
// является ли первое число квадратом второго.

Console.WriteLine("Input a first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2)
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}
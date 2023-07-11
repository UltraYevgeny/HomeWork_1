/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
Console.Write("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.Write("First number: " + number1 + " - is greater than second: " + number2);
}
if (number1 < number2)
{
    Console.Write("Second number: " + number2 + " - is greater than first: " + number1);
}
if (number1 == number2)
{
    Console.Write("Numbers are equal");
}
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
int count = 1;
int max = 0;
while (count <= 3)
{
    Console.Write("Enter number №" + count + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (max < number)
    {
        max = number;
    }
    count += 1;
}
Console.WriteLine("Maximum number: " + max);
*/


/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

/*
Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2 == 0)
{
    Console.Write("Number is even");
}
else
{
    Console.Write("Number is not even");
}
*/

/*
Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 
*/

int countN = 1;
Console.Write("Enter number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberN > 1)
{
    while (countN <= numberN)
    {
        if (countN % 2 == 0)
        {
            Console.Write(countN + ", ");
        }
        countN += 1;
    }
}
else
{
    Console.Write("Error!");
}
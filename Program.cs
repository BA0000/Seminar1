// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int n1, n2;

n1 = 5;
n2 = 8;

Console.Write("output max and min number ");
n1 = Convert.ToInt32(Console.ReadLine());
n2 = Convert.ToInt32(Console.ReadLine());

if(n1>n2)
 {
    Console.WriteLine("number" + n1 + "is greater than" + n2); 
 }
else
{
    Console.WriteLine("number" + n2 + "is greater than" + n1);
}
   
















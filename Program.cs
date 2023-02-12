// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
System.Console.WriteLine("Введите 3 числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
// if (a > b)
// {
//     if (a > c)
//     {
//         System.Console.WriteLine(a);
//     }
//     else
//     {
//         System.Console.WriteLine(c);
//     }
// }
// else
// {
//     if (b > c)
//     {
//         System.Console.WriteLine(b);
//     }
//     else
//     {
//         System.Console.WriteLine(c);
//     }
// }
int max = a;
if (b > max)
{
    max = b;
}
else if (max > c)
{
    System.Console.WriteLine(max);
}
else
{
    System.Console.WriteLine(c);
}

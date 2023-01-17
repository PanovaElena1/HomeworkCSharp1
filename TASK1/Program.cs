// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int NumberA = Convert.ToInt32(Console.ReadLine());
int NumberB = Convert.ToInt32(Console.ReadLine());
int max = NumberA;
int min = NumberB;

if (NumberB > max) max = NumberB;
if (NumberB < max) max = NumberA;
if (NumberA < min) min = NumberA;
if (NumberA > min) min = NumberB;

Console.Write ("max = ");
Console.WriteLine(max);

Console.Write ("min = ");
Console.WriteLine(min);
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int N = 8;
int currentValue = 1;
while (currentValue <= N)
{
if (currentValue % 2 == 0)
{
Console.Write(currentValue + " ");
}
currentValue++;
}

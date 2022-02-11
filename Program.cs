//Написать программу вычисления произведения чисел от 1 до N

Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int fact = 1;
int i = 1;
while (i <= N)
{
    fact *= i;
    i++;
}

Console.WriteLine($"Произведение чисел от 1 до {N}: {fact}");
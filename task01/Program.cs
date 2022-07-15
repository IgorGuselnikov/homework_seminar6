// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество используемых цифр");
int inputDate = Convert.ToInt32(Console.ReadLine());
int count = 0;

Console.WriteLine("Введите по порядку отрицательные и положительные числа");
for (int i = 1; i <= inputDate; i++)
{
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    if (inputNumber > 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество чисел больше 0 среди введенных: {count}");

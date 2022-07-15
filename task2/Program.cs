// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Получение из y значение x
//k1*x + b1 = k2*x + b2
//k1*x - k2*x = b2 - b1
//x*(k1-k2) = b2 - b1
//x = (b2 - b1)/(k1-k2)

Console.WriteLine("Введите координату k1");
double coordinateK1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату k2");
double coordinateK2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату b1");
double coordinateB1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату b2");
double coordinateB2 = Convert.ToDouble(Console.ReadLine());

double x = Math.Round((coordinateB2 - coordinateB1)/(coordinateK1-coordinateK2),2);
double y = Math.Round((coordinateK1 * x + coordinateB1),2);


if (((coordinateK1-coordinateK2) != 0) && (x > 0 || x < 0 || x == 0) && (y > 0 || y < 0 || y == 0))
{
    Console.WriteLine($"Прямые пересекаются в координатах: ({x} ; {y})");
}
else
{
    Console.WriteLine($"Прямые не имеют точек перечесения");
}
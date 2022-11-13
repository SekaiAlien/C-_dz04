// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень числа:");
int degree = Convert.ToInt32(Console.ReadLine());


int DegreeOfNum(int number)
{
    int result = 1;
      
    for (int i = 0; i < degree; i++)
    {
        result *= number;
    }
    return result;
}

Console.WriteLine("Число " + num + " в степени " + degree + " равно " + DegreeOfNum(num));


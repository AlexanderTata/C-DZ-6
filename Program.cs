void Zadacha41()
{
//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

    int FirstNumber = 7;
    int count = 0;

    for(int i = 0; i < FirstNumber; i++)
    {
        Console.WriteLine();
        Console.Write($"Введите {i+1}-е число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) count++;
    }
    Console.WriteLine("Количество чисел больше нуля:" + count);


}

void Zadacha43()
{
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    int k1 = 1;
    int k2 = 5;
    int b1 = 1;
    int b2 = 3;
    double x;
    double y;
    
    if (k1 != k2)
    {
        x = (b2 - b1)/(k1 - k2);
        y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения прямых ({x}, {y})");

    }
    else
    {
        Console.WriteLine("Прямые параллельны");
    }
    


}

//Zadacha41();
Zadacha43();
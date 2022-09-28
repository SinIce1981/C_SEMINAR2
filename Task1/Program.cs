
void Zadacha2()
{


    Console.WriteLine("Задача 2");
    int a = 15;
    int b = 5;

    if (a > b)
    {
        Console.WriteLine("Наибольшее число " + a);
        Console.WriteLine("Наименьшее число " + b);
    }
    else
    {
        Console.WriteLine("Наибольшее число " + b);
        Console.WriteLine("Наименьшее число " + a);
    }
}

void Zadacha4()

{
    // // Задача 4 . Найти максимальное из 3 чисел
    Console.WriteLine("___________________________");
    Console.WriteLine("Задача 4");
    int a = 23;
    int b = 15;
    int c = 7;
    int max = a;

    if (b > max)
    {
        max = b;
    }
    if (c > max)
    {
        max = c;
    }
    Console.WriteLine(max);
}

void Zadacha6()
{
    // // Задача 6.Выяснить являетмя ли число четным

    Console.WriteLine("___________________________");
    Console.WriteLine("Задача 6");
    int number = 27;
    if (number % 2 == 0)
    {
        Console.WriteLine($"{number}четное число");
    }
    else
    {
        Console.WriteLine($"{number} нечетное число");
    }
}

void Zadacha8()
{
    // Задача 8 показать все четные числа от 1 до N

    Console.WriteLine("___________________________");
    Console.WriteLine("Задача 8");
    int number = 12;
    int counter = 2;
    while (counter <= number)
    {
        Console.WriteLine(counter);
        counter += 2;
    }
}

// Zadacha2();
// Zadacha4();
// Zadacha6();
// Zadacha8();

// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

void Zadacha9()

{
    Random random = new Random();
    int number = random.Next(10, 100);
    Console.WriteLine(number);
    int tens = number / 10;
    int ones = number % 10;
    Console.WriteLine(tens);
    Console.WriteLine(ones);
    if (tens > ones)
    {
        Console.WriteLine("Наибольшее число " + tens);
        Console.WriteLine("Наименьшее число " + ones);
    }
    else
    {
        Console.WriteLine("Наибольшее число " + ones);
        Console.WriteLine("Наименьшее число " + tens);
    }
}
// Zadacha9();
//  Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

void Zadacha11()
{
    Console.WriteLine("___________________________");
    Console.WriteLine("Задача 11");
    Random random = new Random();
    int number = random.Next(100, 1000);
    Console.WriteLine(number);
    int thousand = number / 100;
    int th = thousand % 100;
    int tens = number / 10;
    int tens1 = tens % 10;
    int ones = number % 10;
    Console.WriteLine(thousand);
    Console.WriteLine(tens1);
    Console.WriteLine(ones);
    Console.WriteLine("Новое число:");

    Console.Write(thousand);
    Console.Write(ones);
    Console.WriteLine();


}
// Zadacha11();

//  12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
//  Если число 2 не кратно числу 1,
//   то программа выводит остаток от деления



void Zadacha14()
{
    Console.WriteLine("Введите первое число:");
    double number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    double number1 = Convert.ToInt32(Console.ReadLine());
    if (number % number1 == 0)
    {
        Console.Write(number);
        Console.Write("," + number1);
        Console.Write(" - Кратно");
        Console.WriteLine();
    }
    else
    {

        Console.WriteLine($"Не кратно, остаток = {number % number1}");
        Console.WriteLine();
    }

}
// 14. Напишите программу, которая принимает на вход число и проверяет,
//  кратно ли оно одновременно 7 и 23.
// Zadacha12();

void Zadacha15()
{
    Console.WriteLine("Введите число:");
    double number = Convert.ToInt32(Console.ReadLine());

    if (number % 7 == 0 && number % 23 == 0)
    {

        Console.Write(" - Кратно");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Не кратно");
        Console.WriteLine();
    }
}

// Zadacha15();

void Zadacha16()
{
    Console.WriteLine("Введите первое число");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 == num2 * num2 || num2 == num1 * num1) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
Zadacha16();
/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");*/

/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Решаем с помощью "/" и "%", со строками не работаем
456 -> 5
782 -> 8
918 -> 1*/
/*int number = new Random().Next(100,1000);
int secondNumber = number / 10 % 10;
Console.WriteLine($"Вторая цифра в числе {number} -> {secondNumber}");*/


/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решаем с помощью "/" и "%", со строками не работаем (Максимальное число 100000)
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

   /* Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine()!);
    if (num < 100)
    {
         Console.WriteLine($"Третей цифры нет");
         return;
    }
    int num3 = 0;
    if( num > 99 && num < 1000){
        num3 = (num % 100) % 10;
     }
     if( num > 999 && num < 10000){
        num3 = (num % 100) / 10;
     }
     if( num > 9999 && num < 100000){
        num3 = (num % 1000) / 100;
     }
     Console.WriteLine($"Третья цифра числа {num} - > {num3}");*/

/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательно сделать проверку на ввод чисел меньше 1 и больше 7
6 -> да
7 -> да
1 -> нет*/
/*Console.Write("Введите число от 1 до 7: ");
    int numDay = int.Parse(Console.ReadLine()!);
    if (numDay < 1 && numDay > 8){
         Console.WriteLine($"Вы ввели не верное число");
         return;
    }
     if( numDay == 6 && numDay == 7){
     Console.WriteLine($"Выходной");
    }
else if( numDay > 0 && numDay < 6){
     Console.WriteLine($"Рабочий");
    }
*/

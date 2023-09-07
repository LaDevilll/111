using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BEGIN:
            //4. Дан диаметр окружности d. Найти ее длину L = π·d. В качестве значения π использовать 3.14.
            //double pi = 3.14;
            //double d;
            //Console.WriteLine("Введите диаметр окружности:");
            //string tmp = Console.ReadLine();
            //d = double.Parse(tmp);
            //Console.WriteLine("L = " + (pi * d));
            //Console.ReadKey();

            //6. Даны длины ребер a, b, c прямоугольного параллелепипеда. Найти его объем V = a·b·c и площадь поверхности S = 2·(a·b + b·c + a·c).
            //double a;
            //double b;
            //double c;
            //Console.WriteLine("Введите длину стороны a: ");
            //string tmp = Console.ReadLine();
            //a = double.Parse(tmp);
            //Console.WriteLine("Введите длину стороны b: ");
            //string tmk = Console.ReadLine();
            //b = double.Parse(tmk);
            //Console.WriteLine("Введите длину стороны c: ");
            //string tmb = Console.ReadLine();
            //c = double.Parse(tmb);
            //Console.WriteLine("V = " + (a * b * c));
            //Console.WriteLine("S = " + (2 * (a * b + b * c + a * c)));
            //Console.ReadKey();

            //9. Даны два неотрицательных числа a и b.Найти их среднее геометрическое, то есть квадратный корень из их произведения: a ⋅b.
            //double a;
            //double b;
            //Console.WriteLine("Введите число a: ");
            //string tmp = Console.ReadLine();
            //a = double.Parse(tmp);
            //Console.WriteLine("Введите число b: ");
            //string tmk = Console.ReadLine();
            //b = double.Parse(tmk);
            //if (a >= 0 && b >= 0)
            //{
            //    Console.WriteLine("Среднее геометрическое равно = " + Math.Sqrt(a * b));
            //} else
            //{
            //    Console.WriteLine("Введите нетрицательные числа");
            //}
            //Console.ReadKey();

            //10. Даны два ненулевых числа.Найти сумму, разность, произведение и частное их квадратов.
            //double a;
            //double b;
            //Console.WriteLine("Введите первое число: ");
            //string tmp = Console.ReadLine();
            //a = double.Parse(tmp);
            //Console.WriteLine("Введите второе число: ");
            //string tmk = Console.ReadLine();
            //b = double.Parse(tmk);
            //if (a != 0 && b != 0)
            //{
            //    Console.WriteLine("Сумма = " + (a + b));
            //    Console.WriteLine("Разность = " + (a - b));
            //    Console.WriteLine("Произведенгие = " + (a * b));
            //    Console.WriteLine("Частность = " + (a / b));
            //}
            //else
            //{
            //    Console.WriteLine("Введите ненулевые значения");
            //}
            //Console.ReadKey();




            // INTEGER:
            //3. Дан размер файла в байтах.Используя операцию деления нацело, найти количество полных килобайтов, которые занимает данный файл (1 килобайт = 1024 байта).
            //int a;
            //int b = 1024;
            //Console.WriteLine("Введите размер файла в байтах: ");
            //string tmp = Console.ReadLine();
            //a = int.Parse(tmp);
            //Console.WriteLine("Размер файла в килобайтах: " + (a / b));
            //Console.ReadKey();

            //4. Даны целые положительные числа A и B (A > B).На отрезке длины A размещено максимально возможное количество отрезков длины B(без наложений).
            //    Используя операцию деления нацело, найти количество отрезков B, размещенных на отрезке A.
            //int a;
            //int b;
            //Console.WriteLine("Введите число A: ");
            //string tmp = Console.ReadLine();
            //a = int.Parse(tmp);
            //Console.WriteLine("Введите число B: ");
            //string tmk = Console.ReadLine();
            //b = int.Parse(tmk);
            //if (a >= 0 && b >= 0)
            //{
            //    if (a > b)
            //    {
            //        Console.WriteLine("Количество отрезков B, размещенных на отрезке A: " + (a / b));
            //    }
            //    else
            //    {
            //        Console.WriteLine("Число A должно быть больше B");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Числа должны быть положительные");
            //}
            //Console.ReadKey();

            //6. Дано двузначное число.Вывести вначале его левую цифру(десятки),а затем — его правую цифру(единицы).Для нахождения десятков 
            //    использовать операцию деления нацело, для нахождения единиц — операцию взятия остатка от деления.
            //int a;
            //Console.WriteLine("Введите двузначное число: ");
            //string tmp = Console.ReadLine();
            //a = int.Parse(tmp);
            //if (99 >= a && a >= 10)
            //{
            //    Console.WriteLine("Левая цифра: " + (a / 10));
            //    Console.WriteLine("Правая цифра: " + (a % 10));
            //}
            //else
            //{
            //    Console.WriteLine("Число должно быть двузначвное");
            //}
            //Console.ReadKey();

            //7. Дано двузначное число. Найти сумму и произведение его цифр.
            //int a;
            //int b;
            //int c;
            //Console.WriteLine("Введите двузначное число: ");
            //string tmp = Console.ReadLine();
            //a = int.Parse(tmp);
            //if (99 >= a && a >= 10)
            //{
            //     b = a / 10;
            //     c = a % 10;
            //     Console.WriteLine("Сумма цифр: " + (b + c));
            //     Console.WriteLine("Произведение цифр: " + (b * c));
            //}
            //else
            //{
            //    Console.WriteLine("Число должно быть двузначвным");
            //}
            //Console.ReadKey();



            // BOOLEAN:
            //2. Дано целое число A.Проверить истинность высказывания: «Число A является нечетным».
            //int a;
            //Console.WriteLine("Введите целое число: ");
            //string tmp = Console.ReadLine();
            //a = int.Parse(tmp);
            //if (a % 2 == 1)
            //{
            //    Console.WriteLine("Число нечётное");
            //}
            //else
            //{
            //    Console.WriteLine("Число чётное");
            //}
            //Console.ReadKey();

            //4. Даны два целых числа: A, B.Проверить истинность высказывания: «Справедливы неравенства A > 2 и B ≤ 3».
            //int a;
            //int b;
            //Console.WriteLine("Введите целое число A: ");
            //string tmp = Console.ReadLine();
            //a = int.Parse(tmp);
            //Console.WriteLine("Введите целое число B: ");
            //string tmk = Console.ReadLine();
            //b = int.Parse(tmk);
            //if (a > 2 && b <= 3)
            //{
            //    Console.WriteLine("Неравенства A > 2 и B <= 3 - справедливы");
            //}
            //else
            //{
            //    Console.WriteLine("Yеравенства A > 2 и B <= 3 - несправедливы");
            //}
            //Console.ReadKey();




            // IF:
            //3. Дано целое число. Если оно является положительным, то прибавить к нему 1; если отрицательным, то вычесть из него 2; если нулевым, то
            //заменить его на 10 Вывести полученное число.
            //int a;
            //int b;
            //Console.WriteLine("Введите целое число A: ");
            //string tmp = Console.ReadLine();
            //a = int.Parse(tmp);
            //if (a > 0)
            //{
            //    b = a + 1;
            //    Console.WriteLine("Число A явлеятся положительным. Результат: " + b);
            //}
            //else if (a < 0)
            //{
            //    b = a - 2;
            //    Console.WriteLine("Число A явлеятся отрицательным.Результат: " + b);
            //}
            //else 
            //{
            //    Console.WriteLine("Число A равно нулю: " + 10);
            //}
            //Console.ReadKey();

            //4. Даны три целых числа.Найти количество положительных чисел в исходном наборе.
            //int a;
            //int b;
            //int c;
            //int d = 0;  
            //Console.WriteLine("Введите целое число A: ");
            //string tmp = Console.ReadLine();
            //a = int.Parse(tmp);
            //Console.WriteLine("Введите целое число B: ");
            //string tmk = Console.ReadLine();
            //b = int.Parse(tmk);
            //Console.WriteLine("Введите целое число C: ");
            //string tmb = Console.ReadLine();
            //c = int.Parse(tmb);
            //if (a > 0)
            //{
            //    d++;
            //}
            //if (b > 0)
            //{
            //    d++;
            //}
            //if (c > 0) 
            //{ 
            //    d++; 
            //}
            //Console.WriteLine("Количество положительных чисел: " + d);
            //Console.ReadKey();

            //8. Даны два числа. Вывести вначале большее, а затем меньшее из них.
            //int a;
            //int b;
            //Console.WriteLine("Введите число A: ");
            //string tmp = Console.ReadLine();
            //a = int.Parse(tmp);
            //Console.WriteLine("Введите число B: ");
            //string tmk = Console.ReadLine();
            //b = int.Parse(tmk);
            //if (a > b)
            //{
            //    Console.WriteLine($"Результат: {a} {b}");
            //}
            //else if (b > a)
            //{
            //    Console.WriteLine($"Результат: {b} {a}");
            //}
            //else Console.WriteLine("Числа равны");
            //Console.ReadKey();

            //9. Даны две переменные вещественного типа: A, B. Перераспределить значения данных переменных так, чтобы в A оказалось меньшее из значений,
            //а в B — большее.Вывести новые значения переменных A и B.
            double a;
            double b;
            Console.WriteLine("Введите число A: ");
            string tmp = Console.ReadLine();
            a = double.Parse(tmp);
            Console.WriteLine("Введите число B: ");
            string tmk = Console.ReadLine();
            b = double.Parse(tmk);
            double c = a;
            if (a > b)
            {
                a = b;
                b = c;
                Console.WriteLine($"Результат: A = {a}, B = {c}");
            }
            if (c < b)
            {
                Console.WriteLine($"Результат: A = {a}, B = {b}");

            }
            Console.ReadKey();
        }
    }
}




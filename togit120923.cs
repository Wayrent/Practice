using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conbanwa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*void PrintPerson(string name, int age = 1, string company = "Undefined") //Здесь параметры age и company являются необязательными, так как им присвоены значения. Поэтому при вызове метода мы можем не передавать для них данные
            {
                Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
            }

            PrintPerson("Tom", 37, "Microsoft");  // Name: Tom  Age: 37  Company: Microsoft
            PrintPerson("Tom", 37);               // Name: Tom  Age: 37  Company: Undefined
            PrintPerson("Tom");*/

            /*void PrintMessage(string message) //метод PrintMessage() принимает один параметр, который называется message и имеет тип string
            {
                Console.WriteLine(message);
            }

            PrintMessage("che kak");
            PrintMessage("priv");
            PrintMessage("darova"); */

            /*string GetMessage()  // работаем с return
            {
                return "Hello";
            }*/

            /*string GetMessage()
            {
                return "Hello";
            }

            string message = GetMessage();  // получаем результат метода в переменную message
            Console.WriteLine(message);     // Hello */

            /*            void PrintPerson(string name, int age)
                        {
                            if (age > 120 || age < 1)
                            {
                                Console.WriteLine("Недопустимый возраст");
                                return;
                            }
                            Console.WriteLine($"Имя: {name}  Возраст: {age}");
                        }

                        PrintPerson("Tom", 37);         // Имя: Tom  Возраст: 37
                        PrintPerson("Dunkan", 1234);    // Недопустимый возраст*/


            /*void Increment(int n) //Наиболее простой способ передачи параметров представляет передача по значению, по сути это обычный способ передачи параметров
            {
                n++;
                Console.WriteLine($"Число в методе Increment: {n}");
            }

            int number = 5;
            Console.WriteLine($"Число до метода Increment: {number}");
            Increment(number);
            Console.WriteLine($"Число после метода Increment: {number}");*/

            /*void GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr)
            {
                rectArea = width * height;
                rectPerimetr = (width + height) * 2;
            }

            GetRectangleData(10, 20, out int area, out int perimetr);

            Console.WriteLine($"Площадь прямоугольника: {area}");       // тутъ 200
            Console.WriteLine($"Периметр прямоугольника: {perimetr}");   // тутъ 60*/

            /*void Sum(int initialValue, params int[] numbers)
            {
                int result = initialValue;
                foreach (var n in numbers)
                {
                    result += n;
                }
                Console.WriteLine(result);
            }

            int[] nums = { 1, 2, 3, 4, 5 };
            Sum(10, nums);  // число 10 - передается параметру initialValue
            Sum(1, 2, 3, 4);
            Sum(1, 2, 3);
            Sum(20); */

            /*void Sum(int[] numbers, int initialValue)
            {
                int result = initialValue;
                foreach (var n in numbers)
                {
                    result += n;
                }
                Console.WriteLine(result);
            }

            int[] nums = { 1, 2, 3, 4, 5 };
            Sum(nums, 10);

            // Sum(1, 2, 3, 4);     //так нельзя, надо передать массив */

            //метод для нахождения факториала, РЕКУРСИВНЫЕ ФУНКЦИИ
            /*int Factorial(int n)
            {
                if (n == 1) return 1;

                return n * Factorial(n - 1);
            }*/

            /*int Factorial(int n) //рекурсивный спуск
            {
                if (n == 1) return 1;

                return n * Factorial(n - 1);
            }

            int factorial4 = Factorial(4);  // 24
            int factorial5 = Factorial(5);  // 120
            int factorial6 = Factorial(6);  // 720

            Console.WriteLine($"Факториал числа 4 = {factorial4}");
            Console.WriteLine($"Факториал числа 5 = {factorial5}");
            Console.WriteLine($"Факториал числа 6 = {factorial6}");*/

            int Fibonachi(int n) //Рекурсивная функция Фибоначчи
            {
                if (n == 0 || n == 1) return n;

                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }

            int fib4 = Fibonachi(4);
            int fib5 = Fibonachi(5);
            int fib6 = Fibonachi(6);

            Console.WriteLine($"4 число Фибоначчи = {fib4}");
            Console.WriteLine($"5 число Фибоначчи = {fib5}");
            Console.WriteLine($"6 число Фибоначчи = {fib6}");

        }
    }
}

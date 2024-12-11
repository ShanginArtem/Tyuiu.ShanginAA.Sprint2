using Tyuiu.ShanginAA.Sprint2.Task3.V28.Lib;

namespace Tyuiu.ShanginAA.Sprint2.Task3.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double x;

            Console.Title = "Спринт #2 | Выполнил: Шангин А. А. | ИСП6-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Шангин Артём Александрович | ИСПб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
            Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит      *");
            Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение до    *");
            Console.WriteLine("* трех знаков после запятой                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("ВВЕДИТЕ ЗНАЧЕНИЕ X: ");
            x = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Значение функции = " + res);

            Console.ReadKey();


        }
    }
}
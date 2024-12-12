using Tyuiu.ShanginAA.Sprint2.Task7.V15.Lib;

namespace Tyuiu.ShanginAA.Sprint2.Task7.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double x;
            double y;

            Console.Title = "Спринт #2 | Выполнил: Шангин А. А. | ИСП6-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Шангин Артём Александрович | ИСПб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами  *");
            Console.WriteLine("*  X,Y в заштрихованной области.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("ВВЕДИТЕ ЗНАЧЕНИЕ X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ВВЕДИТЕ ЗНАЧЕНИЕ Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res == true)
            {
                Console.WriteLine("Точка находится в заштрихованной области.");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области.");
            }

            Console.ReadKey();


        }
    }
}
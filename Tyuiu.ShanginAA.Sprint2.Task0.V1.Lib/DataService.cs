using tyuiu.cources.programming.interfaces.Sprint2;

//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)
//    и арифметических выражений, которая вернет логическую последовательность(массив): 
//   (True, False, True, False, True, False), при x = 233, y = 122


namespace Tyuiu.ShanginAA.Sprint2.Task0.V1.Lib
{
    public class DataService : ISprint2Task0V1
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x - 111 == y;
            res[1] = x - 111 != y;
            res[2] = y < x;
            res[3] = y > x;
            res[4] = x - 111 <= y;
            res[5] = y >= x; 


            return res;
        }
    }
}

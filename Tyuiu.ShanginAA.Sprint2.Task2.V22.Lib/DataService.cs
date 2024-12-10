using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShanginAA.Sprint2.Task2.V22.Lib
{
    public class DataService : ISprint2Task2V22
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;

            if ((y == 3 || y == 4) && ((x >= 3 && x <= 5 ) || (x >= 9 && x <= 12)))
            {
                res = true;
            }
            else if ((y >= 5 && y <= 7) && (x >= 3 && x <= 13) && (x != 13 && y == 5))
            {
                res = true;
            }
            
            else if ((y == 8) && ((x >= 4 && x <= 6) || (x >= 9 && x <= 10) || (x >= 12 && x <= 13))) res = true;

            else if ((y == 9) && ((x >= 4 && x <= 6) || (x >= 9 && x <= 10) || (x == 12))) res = true;

            else if ((y == 10) && ((x >= 4 && x <= 6) || (x == 12))) res = true;

            else if ((y == 11) && ((x >= 3 && x <= 6) || (x == 12))) res = true;

            else if ((y == 12) && (x == 5)) res = true;

            else if ((y == 13) && (x == 5)) res = true;

            else if ((y == 14) && ((x >= 4 && x <= 10))) res = true;

            
            return res;



           
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShanginAA.Sprint2.Task5.V7.Lib
{
    public class DataService : ISprint2Task5V7
    {
        public string FindMonthName(int startYear, int n)
        {
            startYear = 1990;
            string month;
            if (n > 12)
            {
                n %= 12;
            }
            switch (n)
            {
                case 0:
                    month = "Январь";
                    break;
                case 1:
                    month = "Февраль";
                    break;
                case 2:
                    month = "Март";
                    break;
                case 3:
                    month = "Аперель";
                    break;
                case 4:
                    month = "Май";
                    break;
                case 5:
                    month = "Июнь";
                    break;
                case 6:
                    month = "Июль";
                    break;
                case 7:
                    month = "Август";
                    break;
                case 8:
                    month = "Сентябрь";
                    break;
                case 9:
                    month = "Октябрь";
                    break;
                case 10:
                    month = "Ноябрь";
                    break;
                case 11:
                    month = "Декабрь";
                    break;
                default:
                    month = "Неверное число";
                    break;
            }
            return month;
        }
    }
}

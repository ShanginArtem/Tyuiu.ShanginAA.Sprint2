using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShanginAA.Sprint2.Task6.V3.Lib
{
    public class DataService : ISprint2Task6V3
    {
        public string FindDayName(int value)
        {
            string result = value switch
            {
                1 => "понедельник",
                2 => "вторник",
                3 => "среда",
                4 => "четверг",
                5 => "пятница",
                6 => "суббота",
                7 => "воскресенье",
                _ => "Неверный номер"
            };
            return result;
        }
    }
}

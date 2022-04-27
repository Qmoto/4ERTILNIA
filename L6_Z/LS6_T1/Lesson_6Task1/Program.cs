using System;

namespace Lesson_6Task1
{
    class Program
    {
        enum DayOfWeek { MON, TUE, WED, THU, FRI, SAT, SUN };

        //the function outputs the names of the days
        static void PrintDayOfWeek(DayOfWeek dow)
        {
            //TODO: here you have to create SWITCH statement to check the day 
            //the hint: if the name of the day is MON, so to Print "Monday", etc.
            switch (dow)
            {
                case DayOfWeek.MON:
                    Console.WriteLine("Понедельник");
                    break;
                case DayOfWeek.TUE:
                    Console.WriteLine("Вторник");
                    break;
                case DayOfWeek.WED:
                    Console.WriteLine("Среда");
                    break;
                case DayOfWeek.THU:
                    Console.WriteLine("Четверг");
                    break;
                case DayOfWeek.FRI:
                    Console.WriteLine("Пятница");
                    break;
                case DayOfWeek.SAT:
                    Console.WriteLine("Суббота");
                    break;
                case DayOfWeek.SUN:
                    Console.WriteLine("Всокресенье");
                    break;
            }
        }

        //the function inputs the days of week (from 1 to 7) and returns the result of calling the function DayOfWeek with inputted argument
        static DayOfWeek ReadDayOfWeek()
        {
            int day;
            day = int.Parse(Console.ReadLine());
            DayOfWeek dow = DayOfWeek.MON;
            switch(day)
            {
                case 1:
                    dow = DayOfWeek.MON;
                    break;
                case 2:
                    dow = DayOfWeek.TUE;
                    break;
                case 3:
                    dow = DayOfWeek.WED;
                    break;
                case 4:
                    dow = DayOfWeek.THU;
                    break;
                case 5:
                    dow = DayOfWeek.FRI;
                    break;
                case 6:
                    dow = DayOfWeek.SAT;
                    break;
                case 7:
                    dow = DayOfWeek.SUN;
                    break;
            }
            return dow;
        }
        static void Main()
        { 
            DayOfWeek dow = ReadDayOfWeek();/*TODO: with a help of the function ReadDayOfWeek you have to initialize dow*/
            PrintDayOfWeek(dow);
            //TODO: call the function PrintDayOfWeek

        }
    }
}

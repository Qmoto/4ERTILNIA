using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Hw
    {
        static void Main(string[] args)
        {
            string name, surname, adress, country, course_name, teacher;
            int points, week_lessons;
            string birthday = "2004 12 18";
            string gender = "m";
            name = "Глеб";
            surname = "Васильев";
            adress = "Москва, Красная пл. дом 1";
            country = "Россия";
            course_name = "Разработка программных модулей";
            teacher = "Жукова М.А.";
            points = 100;
            week_lessons = 5;

            Console.WriteLine("Информация о студенте:");
            Console.WriteLine("\nИмя: " + name + "\nФамилия: " + surname + "\nДата  рождения: " + birthday + "\nАдрес: " + adress + "\nПол: " + gender + "\nСтрана " + country);
            Console.WriteLine();
            Console.WriteLine("Информация о курсе:");
            Console.WriteLine("\nНазвание курса: " + course_name + "\nБаллы: " + points + "\nКоличество занятий в неделю: " + week_lessons + "\nПреподаватель: " + teacher);
            Console.ReadKey();

        }
    }
}

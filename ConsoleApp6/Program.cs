//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace ConsoleApp6
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Задача 1.Дано целое число n, указывающее номер дня недели от 1 до 7.По указанному номеру n вывести название соответствующего дня недели.

//            Console.Write("Введите день недели - ");
//            byte day = byte.Parse(Console.ReadLine());
//            switch (day)
//            {
//                case 1:
//                    Console.WriteLine("Понедельник");
//                    break;
//                case 2:
//                    Console.WriteLine("Вторник");
//                    break;
//                case 3:
//                    Console.WriteLine("Среда");
//                    break;
//                case 4:
//                    Console.WriteLine("Четверг");
//                    break;
//                case 5:
//                    Console.WriteLine("Пятница");
//                    break;
//                case 6:
//                    Console.WriteLine("Суббота");
//                    break;
//                case 7:
//                    Console.WriteLine("Воскресенье");
//                    break;
//                default:
//                    Console.WriteLine("День введён неправильно");
//                    break;
//            }
//            Console.ReadLine();

//            Задача 2.По номеру месяца вывести название времени года.

//            Console.Write("Введите месяц - ");
//            byte month = byte.Parse(Console.ReadLine());
//            switch (month)
//            {
//                case 1:
//                    Console.Write("Январь");
//                    break;
//                case 2:
//                    Console.Write("Февраль");
//                    break;
//                case 3:
//                    Console.Write("Март");
//                    break;
//                case 4:
//                    Console.Write("Апрель");
//                    break;
//                case 5:
//                    Console.Write("Май");
//                    break;
//                case 6:
//                    Console.Write("Июнь");
//                    break;
//                case 7:
//                    Console.Write("Июль");
//                    break;
//                case 8:
//                    Console.Write("Август");
//                    break;
//                case 9:
//                    Console.Write("Сентябрь");
//                    break;
//                case 10:
//                    Console.Write("Октябрь");
//                    break;
//                case 11:
//                    Console.Write("Ноябрь");
//                    break;
//                case 12:
//                    Console.Write("Декабрь");
//                    break;
//                default:
//                    Console.Write("Месяц введён неправильно");
//                    break;
//            }
//            Console.ReadLine();

//            Задача 3.Дан признак транспортного средства: a – автомобиль, в – велосипед, м - мотоцикл, с – самолет, п – поезд.Вывести на экран максимальную скорость транспортного средства в зависимости от введенного признака.

//            Console.Write("Введите первую букву транспорта - ");
//            string transport = Console.ReadLine();
//            switch (transport)
//            {
//                case "а":
//                    Console.Write("Автомобиль имеет максимальную скорость 120 км/ч");
//                    break;
//                case "в":
//                    Console.Write("Велосипед имеет максимальную скорость 25 км/ч");
//                    break;
//                case "м":
//                    Console.Write("Мотоцикл имеет максимальную скорость 200 км/ч");
//                    break;
//                case "с":
//                    Console.Write("Самолёт имеет максимальную скорость 340 км/ч");
//                    break;
//                case "п":
//                    Console.Write("Поезд имеет максимальную скорость 50 км/ч");
//                    break;
//                default:
//                    Console.Write("Транспорт введён неправильно");
//                    break;
//            }
//            Console.ReadLine();

//            Задача 4.Вывести название предмета по введенной первой букве: ф – физика, м – математика, и – история, г – география, б – биология.

//            Console.Write("Введите первую букву предмета - ");
//            string sbj = Console.ReadLine();
//            switch (sbj)
//            {
//                case "ф":
//                    Console.Write("Физика");
//                    break;
//                case "м":
//                    Console.Write("Математика");
//                    break;
//                case "и":
//                    Console.Write("История");
//                    break;
//                case "г":
//                    Console.Write("География");
//                    break;
//                case "б":
//                    Console.Write("Биология");
//                    break;
//                default:
//                    Console.Write("Предмет введён неправильно");
//                    break;
//            }
//            Console.ReadLine();
//        }
//    }
//}

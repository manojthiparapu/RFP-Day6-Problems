﻿using System;

namespace DayOfWeek
{
    public class Util
    {
        public static int year, y0, m0, month, x, d0, day;
        public static void dayOfWeek(int month, int day , int year)
        {
            y0 = year - (14 - month) / 12;
            x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            m0 = month + 12 * ((14 - month) / 12) - 2;
            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Given Month Value Is Not Valid");
                    break;
            }
            d0 = (day + x + 31 * m0 / 12) % 7;
            switch (d0)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                    case 7:
                    Console.WriteLine("Sunday");
                    break;
                case 8:
                    Console.WriteLine("Monday");
                    break;
                case 9:
                    Console.WriteLine("Tuesday");
                    break;
                case 10:
                    Console.WriteLine("Wednesday");
                    break;
                case 11:
                    Console.WriteLine("Thursday");
                    break;
                case 12:
                    Console.WriteLine("Friday");
                    break;
                case 13:
                    Console.WriteLine("Saturday");
                    break;
                case 14:
                    Console.WriteLine("Sunday");
                    break;
                case 15:
                    Console.WriteLine("Monday");
                    break;
                case 16:
                    Console.WriteLine("Tuesday");
                    break;
                case 17:
                    Console.WriteLine("Wednesday");
                    break;
                case 18:
                    Console.WriteLine("Thursday");
                    break;
                case 19:
                    Console.WriteLine("Friday");
                    break;
                case 20:
                    Console.WriteLine("Saturday");
                    break;
                case 21:
                    Console.WriteLine("Sunday");
                    break;
                case 22:
                    Console.WriteLine("Monday");
                    break;
                case 23:
                    Console.WriteLine("Tuesday");
                    break;
                case 24:
                    Console.WriteLine("Wednesday");
                    break;
                case 25:
                    Console.WriteLine("Thursday");
                    break;
                case 26:
                    Console.WriteLine("Friday");
                    break;
                case 27:
                    Console.WriteLine("Saturday");
                    break;
                case 28:
                    Console.WriteLine("Sunday");
                    break;
                case 29:
                    Console.WriteLine("Monday");
                    break;
                case 30:
                    Console.WriteLine("Tuesday");
                    break;
                case 31:
                    Console.WriteLine("Wednesday");
                    break;
                default :
                    Console.WriteLine("Given Day Is Not Valid");
                    break;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Month, Day, Year");
            int month=Convert.ToInt32(Console.ReadLine());
            int day =Convert.ToInt32(Console.ReadLine());
            int year=Convert.ToInt32(Console.ReadLine());
            Util.dayOfWeek(month,day,year);
        }
    }
}

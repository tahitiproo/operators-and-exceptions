using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Laba3
{                                                                           
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 4.1");
            Console.WriteLine("Ввндите число от 1 до 365: ");
            UInt16 a = UInt16.Parse(Console.ReadLine());
            DateTime data = DateTime.Parse("31.12.2021");
            data = data.AddDays(a);
            Console.WriteLine(data.ToString("Дата: d MMMM"));

            Console.WriteLine("Упражнение 4.2");
            Console.WriteLine("Введите число в интервале от 1 до 365: ");
            try
            {
                ushort b = ushort.Parse(Console.ReadLine());
                if ((b < 1) | (b > 365))
                {
                    string prov = ($"Нет {b} дня в невисокосном году");
                    throw new ArgumentOutOfRangeException(prov);
                }
                DateTime data1 = DateTime.Parse("31.12.2021");
                data1 = data1.AddDays(b);
                Console.WriteLine(data1.ToString("Дата: d MMMM"));
            }
            catch(Exception l)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("Упражнение 4.3");
            try
            {
                Console.WriteLine("Введите год: ");
                UInt16 y = ushort.Parse(Console.ReadLine());
                if (DateTime.IsLeapYear(y))
                {
                    Console.WriteLine("Введите число");
                    ushort c = UInt16.Parse(Console.ReadLine());
                    if ((c < 1) | (c > 366))
                    {
                        string prov = ($"Нет {c} дня в високосном году");
                        throw new ArgumentOutOfRangeException(prov);
                    }
                    if (c == 60)
                    {
                        DateTime leapDay = new DateTime(y, 2, 29);
                        Console.WriteLine(leapDay.ToString("Дата: d MMMM yyyy"));
                    }

                    else if (c > 60)
                    {
                        DateTime data2 = DateTime.Parse("01.01.0001");
                        data2 = data2.AddDays(c-2).AddYears(y-2);
                        Console.WriteLine(data2.ToString("Дата: d MMMM yyyy"));
                    }
                }
                else
                {
                    Console.WriteLine("Введите число");
                    ushort c = UInt16.Parse(Console.ReadLine());
                    if ((c < 1) | (c > 365))
                    {
                        string prov = ($"Нет {c} дня в невисокосном году");
                        throw new ArgumentOutOfRangeException(prov);
                    }
                    DateTime data2 = DateTime.Parse("01.01.0001");
                    data2 = data2.AddDays(c-1).AddYears(y - 1);
                    Console.WriteLine(data2.ToString("Дата: d MMMM yyyy"));
                }
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

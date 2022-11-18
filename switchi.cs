using System;
using System.Linq;

namespace switchi_and_goto__rofel_
{
    internal class Switchi
    {
        public static int[] BubbleSort(int[] mass)
        {
            for (int i = 1; i < mass.Length; i++)
                for (int j = 0; j < mass.Length - i; j++)
                {
                    if (mass[j] > mass[j + 1])
                    {
                        SwapInArray(ref mass[j], ref mass[j + 1]);
                    }
                }
            return mass;
        }
        static void SwapInArray(ref int s1, ref int s2)
        {
            int temp = s1;
            s1 = s2;
            s2 = temp;
        }
        enum Cartishki
        {
            Shestyorka = 6,
            Semyorka,
            Vosbmyorka,
            Devyatka,
            Desyatka,
            Jack,
            Lady,
            King,
            Ace
        }
        enum Dninedeli
        {
            Ponedelbnik = 1,
            Vtornik,
            Sreda,
            Chetvepr,
            Pyatnizcha,
            Sybbota,
            Voskrecenbe
        }
        static void Main(string[] args)
        {


            Console.WriteLine("Упражнение 1");
            Console.Write("Введите параметры форточки в два числа через пробел: ");
            try
            {
                float[] a = Console.ReadLine().Split().Select(x => float.Parse(x)).ToArray();
                Console.WriteLine("Введите диаметр кругоголового Васи: ");
                float d = float.Parse(Console.ReadLine());
                if ((d + 1 <= a[0]) & (d + 1 <= a[1]))
                {
                    Console.WriteLine("Вася сможет просунуть голову");
                }
                else
                {
                    Console.WriteLine("Васе нужен спортзал");
                }
            }
            catch (Exception fatal)
            {
                Console.WriteLine(fatal);
            }
            Console.WriteLine("Упражнение 2");
            byte n = byte.Parse(Console.ReadLine());
            for (byte i = 1; i < 10; i++)
            {
                Console.WriteLine($"{i} x {n} = " + i * n);
            }

            Console.WriteLine("Упражнение 3");
            long b = Int64.Parse(Console.ReadLine());
            Console.WriteLine(b % 15 == 0 ? "BangBoom" : b % 3 == 0 ? "Bang" : b % 5 == 0 ? "Boom" : "Мимо");

            Console.WriteLine("Упражнение 4");
            Console.WriteLine("Введите символы для проверки");
            string[] s = Console.ReadLine().Split();
            string s1 = "";
            int c = 0;
            for (int i = 0; i < s.Length; i++)
            {
                s1 += s[i];
                for (int j = 0; j < s[i].Length; j++)
                {
                    if (Char.IsUpper(s[i], j))
                        c++;
                }
            }
            if (s1.Length == c)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);

            Console.WriteLine("Упражнение 5");
            Console.WriteLine("Введите натуральное число");
            byte o = byte.Parse(Console.ReadLine());
            for (int i = 1; i <= o; i++)
            {
                Console.Write($"{i} овца... ");
            }

            Console.WriteLine("Упражнение 6");
            UInt64 cymma = 0;
            string fail = "";
            try
            {
                Console.WriteLine("Введите неотрицательные числа с отрицательным числом на конце через пробел");
                Int64[] czh = Console.ReadLine().Split(' ').Select(x => Int64.Parse(x)).ToArray();
                for (int i = 0; i < czh.Length; i++)
                {
                    if ((czh[i] > 0) & (i != czh.Length - 1))
                        cymma += (ulong)czh[i];
                    else if ((czh[i] < 0) & (i != czh.Length - 1))
                    {
                        fail = czh[i] + " is not a positive number and is not a correct subsequence";
                        i = czh.Length;
                    }
                    else if ((czh[i] > 0) & (i == czh.Length - 1))
                    {
                        fail = czh[i] + " is not a negative number and is not a correct subsequence";
                        i = czh.Length;
                    }
                }
            }
            catch (FormatException fak)
            {
                Console.WriteLine(fak);
            }
            catch (InvalidCastException fak)
            {
                Console.WriteLine(fak);
            }
            catch (ArgumentOutOfRangeException fak)
            {
                Console.WriteLine(fak);
            }
            catch (OutOfMemoryException fak)
            {
                Console.WriteLine(fak);
            }
            catch (OverflowException fak)
            {
                Console.WriteLine(fak);
            }
            catch (SystemException fak)
            {
                Console.WriteLine(fak);
            }
            finally
            {
                if (fail != "")
                    throw new Exception(fail);
                else
                    Console.WriteLine(cymma);
            }

            Console.WriteLine("Упражнение 7");
            byte k = 0;
            try
            {
                Console.Write("Введите число от 6 до 14 включительно: ");
                k = byte.Parse(Console.ReadLine());
                switch (k)
                {
                    case 6:
                        Console.WriteLine((Cartishki)Enum.GetValues(typeof(Cartishki)).GetValue(0));
                        break;
                    case 7:
                        Console.WriteLine((Cartishki)Enum.GetValues(typeof(Cartishki)).GetValue(1));
                        break;
                    case 8:
                        Console.WriteLine((Cartishki)Enum.GetValues(typeof(Cartishki)).GetValue(2));
                        break;
                    case 9:
                        Console.WriteLine((Cartishki)Enum.GetValues(typeof(Cartishki)).GetValue(3));
                        break;
                    case 10:
                        Console.WriteLine((Cartishki)Enum.GetValues(typeof(Cartishki)).GetValue(4));
                        break;
                    case 11:
                        Console.WriteLine((Cartishki)Enum.GetValues(typeof(Cartishki)).GetValue(5));
                        break;
                    case 12:
                        Console.WriteLine((Cartishki)Enum.GetValues(typeof(Cartishki)).GetValue(6));
                        break;
                    case 13:
                        Console.WriteLine((Cartishki)Enum.GetValues(typeof(Cartishki)).GetValue(7));
                        break;
                    case 14:
                        Console.WriteLine((Cartishki)Enum.GetValues(typeof(Cartishki)).GetValue(8));
                        break;
                    default:
                        string fuk = ($"Не существует карты с порядковым номером {k}");
                        throw new ArgumentOutOfRangeException(fuk);
                }

            }
            catch (Exception fuk)
            {
                Console.WriteLine(fuk);
            }

            Console.WriteLine("Упражнение 8");
            Console.WriteLine("Введите названия кукол");
            string[] kukli = Console.ReadLine().Split(' ');
            byte bag = 0;
            string value = "";
            foreach (string vesch in kukli)
            {
                if (Equals(vesch, "Hello") | Equals(vesch, "Barbie"))
                    value = vesch;
                Console.WriteLine($"{value} {vesch}");
                if (Equals($"{value} {vesch}", "Hello Kitty") | Equals($"{value} {vesch}", "Barbie doll"))
                    bag += 1;
            }
            Console.WriteLine(bag);

            Console.WriteLine("Упражнение 9");
            Console.Write("Введите порядок дня недели: ");
            byte day = byte.Parse(Console.ReadLine());
            if (day < 1 | day > 7)
            {
                string proval = ($"{day}-ый день недели? с башкой норм?");
                throw new ArgumentOutOfRangeException(proval);
            }
            Console.WriteLine((Dninedeli)day);

            Console.WriteLine("Упражнение 10");
            Console.WriteLine("Введите массив через пробел");
            int[] mass = Console.ReadLine().Split().Select(z => int.Parse(z)).ToArray();
            Console.WriteLine("{0}", string.Join("", BubbleSort(mass)));
            Array.Sort(mass);
            foreach (byte i in mass)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            var orArray = mass.OrderBy(N => N);
            foreach (byte i in orArray)
                Console.Write($"{i} ");

            Console.WriteLine("Упражнение 11");
            Console.WriteLine("Введите 10 чисел: ");
            int[] ar = Console.ReadLine().Split().Select(w => int.Parse(w)).ToArray();
            int el1 = ar[0];
            int con = 0;
            foreach (int elem in ar)
            {
                con += 1;
                if (elem < el1)
                {
                    Console.WriteLine(con);
                    break;
                }
                el1 = elem;
            }
        }
    }
}

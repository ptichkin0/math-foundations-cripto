using System;
using System.Collections.Generic;

namespace Lab_1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            mark: 
            Console.WriteLine("Выберите режим: ");
            Console.WriteLine("1)   Алгоритм Евклида нахождения НОД двух чисел;");
            Console.WriteLine("2)   Алгоритм построения подходящих дробей;");
            Console.WriteLine("3)   Алгоритм Эратосфена построения простых чисел не превосходящих N;");
            Console.WriteLine("4)   Нахождение канонического разложения числа;");
            Console.WriteLine("5)   Нахождение значения функции Эйлера;");
            Console.WriteLine("6)   Закрыть");
            int tipeAlg = int.Parse(Console.ReadLine());
            if (tipeAlg == 1)
            {
                Console.Clear();
                NOD();

                    Console.WriteLine("Выберите:");
                    Console.WriteLine("1) Вернуться в главное меню");
                    Console.WriteLine("2) Выйти");
                    int funcComd = int.Parse(Console.ReadLine());
                    if (funcComd == 1)
                    {
                        Console.Clear();
                        goto mark;

                    }
                    else if (funcComd == 2)
                    {
                        Console.WriteLine("Press Esc to exit");
                        do
                        {
                            // ваши действия
                        } while (Console.ReadKey().Key != ConsoleKey.Escape);
                    }
                    else
                    {

                    Console.WriteLine("Error. Введены не корректные данные. Попробуйте еще раз...");
                    goto mark;
                    }

            }
            else if (tipeAlg == 2)
            {
                Console.Clear();
                Drob();
                Console.WriteLine("Выберите:");
                Console.WriteLine("1) Вернуться в главное меню");
                Console.WriteLine("2) Выйти");
                int funcComd = int.Parse(Console.ReadLine());
                if (funcComd == 1)
                {
                    Console.Clear();
                    goto mark;

                }
                else if (funcComd == 2)
                {
                    Console.WriteLine("Press Esc to exit");
                    do
                    {
                        // ваши действия
                    } while (Console.ReadKey().Key != ConsoleKey.Escape);
                }
                else
                {

                    Console.WriteLine("Error. Введены не корректные данные. Попробуйте еще раз...");
                    goto mark;
                }
            }
            else if (tipeAlg == 3)
            {
                Console.Clear();
                Erat();
                Console.WriteLine("Выберите:");
                Console.WriteLine("1) Вернуться в главное меню");
                Console.WriteLine("2) Выйти");
                int funcComd = int.Parse(Console.ReadLine());
                if (funcComd == 1)
                {
                    Console.Clear();
                    goto mark;

                }
                else if (funcComd == 2)
                {
                    Console.WriteLine("Press Esc to exit");
                    do
                    {
                        // ваши действия
                    } while (Console.ReadKey().Key != ConsoleKey.Escape);
                }
                else
                {

                    Console.WriteLine("Error. Введены не корректные данные. Попробуйте еще раз...");
                    goto mark;
                }
            }
            else if (tipeAlg == 4)
            {
                Console.Clear();
                Kanon();
                Console.WriteLine("Выберите:");
                Console.WriteLine("1) Вернуться в главное меню");
                Console.WriteLine("2) Выйти");
                int funcComd = int.Parse(Console.ReadLine());
                if (funcComd == 1)
                {
                    Console.Clear();
                    goto mark;

                }
                else if (funcComd == 2)
                {
                    Console.WriteLine("Press Esc to exit");
                    do
                    {
                        // ваши действия
                    } while (Console.ReadKey().Key != ConsoleKey.Escape);
                }
                else
                {

                    Console.WriteLine("Error. Введены не корректные данные. Попробуйте еще раз...");
                    goto mark;
                }
            }
            else if (tipeAlg == 5)
            {
                Console.Clear();
                EylerVoid();
                Console.WriteLine("Выберите:");
                Console.WriteLine("1) Вернуться в главное меню");
                Console.WriteLine("2) Выйти");
                int funcComd = int.Parse(Console.ReadLine());
                if (funcComd == 1)
                {
                    Console.Clear();
                    goto mark;

                }
                else if (funcComd == 2)
                {
                    Console.WriteLine("Press Esc to exit");
                    do
                    {
                        // ваши действия
                    } while (Console.ReadKey().Key != ConsoleKey.Escape);
                }
                else
                {

                    Console.WriteLine("Error. Введены не корректные данные. Попробуйте еще раз...");
                    goto mark;
                }
            }
            else if (tipeAlg == 6)
            {
                Console.WriteLine("Press Esc to exit");
                do
                {
                    // ваши действия
                } while (Console.ReadKey().Key != ConsoleKey.Escape);
            }
            else
            {
                
                Console.WriteLine("Error. Введены не корректные данные. Попробуйте еще раз...");
                goto mark;
            }
             void NOD()
            {
                Console.WriteLine("Введите первое число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int ost;


                Console.WriteLine("Рассчеты:");

                ost = a % b;
                int x = (a - ost) / b;
                Console.WriteLine(a + " = " + b + " * " + x + " + " + ost);

                int firstElement = x;

                List<int> iksi = new List<int>();
                iksi.Add(x);


                int Avremenno = a;
                int Bvremenno = b;
                int promej;
                while (ost != 0)
                {
                    Avremenno = ost;
                    ost = Bvremenno % Avremenno;
                    x = (Bvremenno - ost) / Avremenno;
                    Console.WriteLine(Bvremenno + " = " + Avremenno + " * " + x + " + " + ost);
                    iksi.Add(x);
                    promej = Avremenno;
                    Bvremenno = Avremenno;
                }

                {
                    while (a != 0 && b != 0)
                    {


                        if (a > b)
                        {
                            a = a % b;
                        }
                        else
                        {
                            b = b % a;
                        }


                    }
                    Console.WriteLine();
                    int nod = a + b;
                    Console.WriteLine("НОД: " + nod);
                }
            }
             void Drob()
            {
                Console.WriteLine("Введите первое число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int ost;


                Console.WriteLine("Рассчеты:");

                ost = a % b;
                int x = (a - ost) / b;
                Console.WriteLine(a + " = " + b + " * " + x + " + " + ost);
                List<int> iksi = new List<int>();
                iksi.Add(x);


                int Avremenno = a;
                int Bvremenno = b;
                while (ost != 0)
                {
                    Avremenno = ost;
                    ost = Bvremenno % Avremenno;
                    x = (Bvremenno - ost) / Avremenno;
                    Console.WriteLine(Bvremenno + " = " + Avremenno + " * " + x + " + " + ost);
                    iksi.Add(x);
                    Bvremenno = Avremenno;
                }

                Console.WriteLine("_____________________________");
                Console.Write("     ");
                for (int i = 0; i < iksi.Count; i++)
                {
                    Console.Write(" ");
                    Console.Write(iksi[i] + "");
                    Console.Write(" ");
                }
                Console.WriteLine();
                int razmer = iksi.Count + 2;
                int[] masFirstString = new int[razmer];
                int[] masSecondString = new int[razmer];
                masFirstString[0] = 0;
                masFirstString[1] = 1;
                masSecondString[0] = 1;
                masSecondString[1] = 0;
                Console.Write("P| 1");
                for (int i = 0; i < iksi.Count; i++)
                {
                    masFirstString[i + 2] = iksi[i] * masFirstString[i + 1] + masFirstString[i];

                    Console.Write("  " + masFirstString[i + 2] + "");
                }
                Console.Write("|");
                Console.WriteLine();
                Console.Write("Q| 0");
                for (int i = 0; i < iksi.Count; i++)
                {
                    masSecondString[i + 2] = iksi[i] * masSecondString[i + 1] + masSecondString[i];
                    Console.Write("  " + masSecondString[i + 2] + "");

                }
                Console.Write("|");
                Console.WriteLine();
                Console.WriteLine("_____________________________");

            }
            void Erat()
            {
                static List<uint> SpisokEratosthenes(uint n)
                {
                    var numbers = new List<uint>();
                    //заполнение списка числами от 2 до n-1
                    for (var i = 2u; i < n; i++)
                    {
                        numbers.Add(i);
                    }
                    for (var i = 0; i < numbers.Count; i++)
                    {
                        for (var j = 2u; j < n; j++)
                        {
                            //удаляем кратные числа из списка
                            numbers.Remove(numbers[i] * j);
                        }
                    }

                    return numbers;
                }

                    Console.Write("Введите вверхнюю границу: ");
                    var n = Convert.ToUInt32(Console.ReadLine());
                    var primeNumbers = SpisokEratosthenes(n);
                    Console.WriteLine("Простые числа:", n);
                    Console.WriteLine(string.Join(", ", primeNumbers));
            }
            void Kanon()
            {
                Console.WriteLine("Введите число : ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Решение: ");
                Console.Write("{0} = 1", n);
                for (int i = 0; n % 2 == 0; n /= 2)
                {
                    Console.Write(" * {0}", 2);
                }
                for (int i = 3; i <= n;)
                {
                    if (n % i == 0)
                    {
                        Console.Write(" * {0}", i);
                        n /= i;
                    }
                    else
                    {
                        i += 2;
                    }
                }
                Console.WriteLine("");
            }
            void EylerVoid()
            {
                ulong Eyler(ulong n)
                {                                                          
                    ulong res = n, en = Convert.ToUInt64(Math.Sqrt(n) + 1);
                    for (ulong i = 2; i <= en; i++)//перебор множителей
                        if ((n % i) == 0)//              если делится без остатка, то
                        {
                            while ((n % i) == 0)//           пока не появится остаток
                                n /= i;//                       делим на выбранный множитель и получаем число без этих множителей в переменной n
                            res -= (res / i);//              убираем не всзаимопростые с этим числом 
                        }
                    if (n > 1) res -= (res / n);// если число простое
                    return res;
                }
                Console.WriteLine("Введите число : ");
                ulong num = Convert.ToUInt64(Console.ReadLine());
                Console.WriteLine("Решение: ");
                Console.WriteLine(Eyler(num));
            }
 
        }
    }
}

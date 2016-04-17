using System;

namespace KETZ
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random r = new Random();
            int max = 0;
            int[] a;
            int[] b;
            Console.WriteLine("Введите число:");

            try
            {
                var n = Console.ReadLine();
                int er = Convert.ToInt32(n);
                a = new int[er];
                Console.WriteLine("Массив из " + n + " элементов:");
                int i;
                
                for (i = 0; i < er; i++)
                {
                    a[i] = r.Next(1, 10);
                    Console.Write(a[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Удвоенные четные элементы массива стоящие на нечетных местах:");
                bool pr = false;
                for (i = 0; i < er; i++)
                {
                    if ((i + 1)  %2 == 1)
                    {
                        if (a[i] % 2 == 0)
                        {
                            pr = true;
                            a[i] = a[i]*2;
                            Console.Write(a[i] + " "); 
                        }
                    }
                }
                
                if (pr == false)
                {
                    Console.WriteLine("В массиве не оказалось ни одного четного элемента стоящего на нечетном месте.");
                }
                Console.WriteLine();
                Console.WriteLine("Максимальное значение из нечетных элементов стоящих на четных местах:");

                for (i = 0; i < er; i++)
                {
                    if ((i + 1)%2 == 0)
                    {
                        if (a[i]%2 == 1)
                        {
                            
                            if (max < a[i])
                            {
                                max = a[i];
                            }
                            
                        }
                    }
                }
                if (max == 0)
                {
                    Console.WriteLine("В массиве не оказалось ни одного нечетного элемента стоящего на четном месте.");
                }
                else
                {
                    Console.Write(max);
                }
            }

            catch
            {
                Console.WriteLine("Некорректный ввод, попробуйте воспользоваться клавишами с цифрами");
                Program.Main(null);
            }



            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forC_
{
    public class Some
    {
       public static int Divide(int first, int second)
       {
            try
            {
                return first / second;
            }
            catch
            {

                throw new Exception("Попытка деления на нуль");
            }
       }

    }
  /* public class CharachtersInfo
    {
        public static void Info(string name, string surname)
        {
            try
            {
                Console.WriteLine(name + " " + surname);
            }
            catch (Exception)
            {

                throw new Exception("Нет фамилии");
            }
        }
    }*/
    internal class Program
    {
        static void Main(string[] args)
        {
            /*try //ok
            {
                Console.WriteLine(args[0]);

            }
            catch //not ok
            {
                throw new Exception("Нет аргументов командной строки");

            }*/

            
            

            int firstNum, secondNum;
            try
            {
                Console.WriteLine("\nВведите 1 число: ");
                firstNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите 2 число: ");
                secondNum = int.Parse(Console.ReadLine());
                Console.WriteLine($"{firstNum} // {secondNum} " +
                    $" = {Some.Divide(firstNum, secondNum)}");
            }
            catch (Exception ex001)
            {
                if (ex001.HResult == -2146233033)
                {
                    Console.WriteLine($"{ex001.Message} Вы ввели не цифру");
                }
                if (ex001.HResult == -2147352558)
                {
                    Console.WriteLine($"{ex001.Message} Делить на ноль нельзя!");
                }
                Console.WriteLine(ex001.Message);
                //Console.WriteLine(ex001.Message); //выводик краткое соо об ощибке
                //Console.WriteLine(ex001.Message + " " + ex001.HResult);


            }
            finally { Console.WriteLine("Этот код выполнится в любом случае"); }
            

           /* foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }*/


            Console.ReadKey();

        }
    }
}

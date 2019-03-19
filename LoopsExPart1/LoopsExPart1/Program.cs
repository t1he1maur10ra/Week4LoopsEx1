using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            int start = 3;
            int finish = 7;
            /*Headings*/
            Console.WriteLine("I\tI*10\tI*100\ti*1000");
            Console.WriteLine("-\t----\t-----\t------");

            
            /*Task 1*/
            Console.WriteLine(">>> for loop <<<");
            /*For loop*/
            for(int i = start; i <= finish; i++)
            {
                Console.WriteLine($"{i}\t{i*10}\t{i*100}\t{i*1000}");
            }
            Console.WriteLine("\n>>> while loop <<<");
            //int counter1 = start;
            /*While loop*/
            while(start<=finish)
            {
                Console.WriteLine($"{start}\t{start * 10}\t{start * 100}\t{start * 1000}");
                start++;
            }
            Console.WriteLine("\n>>> do while loop <<<");
            start = 3;
            /*do while loop*/
            do
            {
                Console.WriteLine($"{start}\t{start * 10}\t{start * 100}\t{start * 1000}");
                start++;
            } while (start <= finish) ;
            Console.WriteLine("Task 1 complete - press ENTER to continue...");
            Console.ReadLine();



            /*Task 2*/
            Console.Clear();
            int number = 7;//change this to change the times table produced
            Console.WriteLine("7 times table:");
            Console.WriteLine("--------------");
            Console.WriteLine(">>> for loop <<<");
            /*for loop*/
            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {number} = {i*number}");
            }
            Console.WriteLine("\n>>> while loop <<<");
            int counter = 1;
            /*while loop*/
            while (counter <= 12)
            {
                Console.WriteLine($"{counter} x {number} = {counter * number}");
                counter++;
            }
            Console.WriteLine("\n>>> do while loop <<<");
            /*while loop*/
            counter = 1;
            do
            {
                Console.WriteLine($"{counter} x {number} = {counter * number}");
                counter++;
            } while (counter <= 12) ;

                Console.WriteLine("Task 2 complete - press ENTER to continue...");
            Console.ReadLine();
            
            
            
            /*Task 3*/
            Console.Clear();
            Console.WriteLine("Number\tSquare\tCube");
            Console.WriteLine("------\t------\t----");
            /*for loop*/
            Console.WriteLine(">>> for loop <<<");
            for (int i=0;i<=10;i++)
            {
                Console.WriteLine($"{i}\t{i*i}\t{i*i*i}");
            }
            /*while loop*/
            Console.WriteLine("\n>>> while loop <<<");
            int task3Counter = 0;
            while (task3Counter <= 12)
            {
                Console.WriteLine($"{task3Counter}\t{task3Counter * task3Counter}\t{task3Counter * task3Counter * task3Counter}");
                task3Counter++;
            }
            /*do while loop*/
            Console.WriteLine("\n>>> do while loop <<<");
            task3Counter = 0;
            do
            {
                Console.WriteLine($"{task3Counter}\t{task3Counter * task3Counter}\t{task3Counter * task3Counter * task3Counter}");
                task3Counter++;
            } while (task3Counter <= 12) ;
                Console.WriteLine("Task 3 complete - press ENTER to exit the program...");
            Console.ReadLine();


        }
    }
}

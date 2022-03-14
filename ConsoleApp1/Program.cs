using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string input = Console.ReadLine();
            int inputInt = int.Parse(input);
            if (inputInt % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if (inputInt % 2 == 0 && inputInt >= 2 && inputInt <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (inputInt % 2 == 0 && inputInt >= 6 && inputInt <= 20)
            {
                Console.WriteLine("Weird");
            }
            else if (inputInt %2 == 0 )
            {
                Console.WriteLine("Not Weird");
            }*/

            int[] studentNo = { 1, 2, 3, 4, 5 };
            string[] studentName = { "Jack", "Mary", "Tom", "Grace", "Alice" };
            int[] computerScore = { 80, 65, 100, 98, 83 };
            int[] progarmScore = { 75, 67, 93, 25, 82 };
            int[] movieScore = { 60, 62, 91, 50, 87 };

            while (true)
            {
                Console.WriteLine("請輸入座號(1~5):");
                var input = Console.ReadLine();
                int inputStudentNo = int.Parse(input);
                int arrayIndex = Array.IndexOf(studentNo, inputStudentNo);
                if (arrayIndex > -1)
                {
                    Console.WriteLine("姓名:" + studentName[arrayIndex]);
                    Console.WriteLine("電腦概論:" + computerScore[arrayIndex]);
                    Console.WriteLine("程式設計:" + progarmScore[arrayIndex]);
                    Console.WriteLine("動畫設計:" + movieScore[arrayIndex]);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("沒有這個座號..");
                }
            }
        }
    }
}

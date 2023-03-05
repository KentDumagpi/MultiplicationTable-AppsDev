using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable_Dumagpi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter column: ");
            int col = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nYou Entered\n");
            Console.WriteLine("Rows: " + row);
            Console.WriteLine("Column: " + col);


            for (int i = 1; i <= row; i++)
            {

                for (int j = 1; j <= col; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();

            }
        }
    }
}

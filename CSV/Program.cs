using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSV
{
    class Program
    {
        public static string P1Name { get; private set; }
        public static string P2Name { get; private set; }

        public static void Main()
        {
            Console.WriteLine("Enter Name of Player 1");
            P1Name = Console.ReadLine();

            Console.WriteLine("Enter Name of Player 2");
            P2Name = Console.ReadLine();

            //SaveNames.Save();

            ReplaceName.main();

            ReadLine.ReadRow();

            Console.ReadKey();
        }
    }
}

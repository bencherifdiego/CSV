using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSV
{
    class ReplaceName
    {
        public static void main()
        {
            using (StreamReader sr = new StreamReader(SaveNames.path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
	            {
                    string[] parts = line.Split(';');

                    string P1 = parts[0];

                    Console.WriteLine(P1);
	            }
            }
        }
        
    }
}

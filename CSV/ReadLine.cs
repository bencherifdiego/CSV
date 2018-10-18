using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSV
{
    class ReadLine
    {
        public static void ReadRow()
        {
            var reader = new StreamReader(File.OpenRead(SaveNames.path));
            var data = new List<List<string>>();
        
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                data.Add(new List<String> { values[0], values[1]
                });
            }

            //first [x] is row
            //second [x] is collumn
            Console.WriteLine(data[1][0]); //  -> userid1
            Console.WriteLine(data[1][1]); //  -> password1
        }
    }
}

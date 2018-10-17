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

        public static void ChangeRow()
        {
            var reader = new StreamReader(File.OpenRead(SaveNames.path));
            var data = new List<List<string>>();
        
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');
            
                data.Add(new List<String> { values[0], values[1] });
            }

            Console.WriteLine(data[0][0]); //  -> userid1
            Console.WriteLine(data[0][1]); //  -> password1
        }
    }
}

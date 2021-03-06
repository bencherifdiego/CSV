﻿using System;
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
            var reader = new StreamReader(File.OpenRead(SaveNames.path));
            var data = new List<List<string>>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                data.Add(new List<String> { values[0], values[1]
                });
            }
            reader.Close();

            string delimiter = ";";

            string createText = data[0][0] + delimiter + data[0][1] + Environment.NewLine + Program.P1Name + delimiter + Program.P2Name;
            File.WriteAllText(SaveNames.path, createText);
        }
    }
}

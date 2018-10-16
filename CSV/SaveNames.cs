using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSV
{
    class SaveNames
    {
        public static string path = @"Names.csv";
        public static void Save()
        {

            string delimiter = ";";

            if (!File.Exists(path))
            {
                string createText = Program.P1Name + delimiter + Program.P2Name + delimiter + Environment.NewLine;
                File.WriteAllText(path, createText);
            }
            else
            {
                string appendText = Program.P1Name + delimiter + Program.P2Name + delimiter + Environment.NewLine;
                File.AppendAllText(path, appendText);
            }
        }
    }
}

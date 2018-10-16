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
        public void check()
        {
            var csvLines = File.ReadAllLines(SaveNames.path);

            foreach (var line in csvLines)
            {
                var values = line.Split(';');
                if (values[0].Contains(form2value))
                {

                }
            }
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace FilmeSchauspieler.Helper
{
    class CSVReader
    {
        public CSVReader()
        {
            string travelUpTwo = @".." + Path.DirectorySeparatorChar + ".." + Path.DirectorySeparatorChar;
            string path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, travelUpTwo, "Data"));
            System.Console.WriteLine(path);
            string file = Path.Combine(path, "movies.csv");
            if (!File.Exists(file))
            {
                File.Create(file);
            }
        }
    }
}

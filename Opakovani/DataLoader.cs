using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Opakovani
{
    class DataLoader
    {
        public void Load()
        {
            string[] lines = File.ReadAllLines("./names.txt");
            foreach (string line in lines)
                Console.WriteLine(line);
        }
    }
}

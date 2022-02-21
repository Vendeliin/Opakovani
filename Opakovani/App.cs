using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Opakovani
{
    class App
    {
        public void Run()
        {
            DataLoader load = new DataLoader();
            load.Load();
        }
    }
}

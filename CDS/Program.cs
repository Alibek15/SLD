using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace CDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage[] devices = new Storage[3];
            devices[1] = new Flash();
            devices[2] = new Flash();
            devices[3] = new Flash();

            ClassMenu menu = new ClassMenu(devices);
            menu.Handler();
        }
    }
}

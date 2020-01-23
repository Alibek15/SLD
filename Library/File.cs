using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
     public class File 
    {
        private double _size;

        public File()
        {
            Size = 780;
        }

        public File(double size)
        {
            Size = size;
        }

        public double Size
        {
            get { return _size; }
            set { _size = value; }
        }
    }
}

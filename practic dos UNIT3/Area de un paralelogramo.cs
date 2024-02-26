using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic_dos_UNIT3
{
    internal class Area_de_un_paralelogramo
    {
        protected int bas;

        protected int Bas { get => bas; set => bas = value; }

        public Area_de_un_paralelogramo() 
        { 
            bas= 0;
        
        }

        public Area_de_un_paralelogramo(int base_)
        {
            this.bas = base_;
        }
        public int Formula (int formula_)
        {
            return formula_ = bas;
        }

    }
}

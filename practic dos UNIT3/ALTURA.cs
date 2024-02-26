using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic_dos_UNIT3
{
    internal class ALTURA : Area_de_un_paralelogramo
    {
        private int heigth;

        protected int Heigth { get => heigth; set => heigth = value; }

        public ALTURA()
        {
            heigth = 0;
        }

        public ALTURA(int base_, int Heigth_) : base(base_)
        {
            this.heigth = Heigth_;
        }

        public int Formula(int formula_)
        {
            return formula_ = bas * heigth;
        }

        public int Formula()
        {
            return bas * heigth;
        }

        ~ALTURA()
        {
            Console.WriteLine("no esta disponible esa variable");
        }
    }
}

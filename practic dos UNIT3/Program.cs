
using practic_dos_UNIT3;

namespace practica_dos_UNIT3
{
    internal class program
    {
        public static void Main(string[] args)
        {
            ALTURA uno = new ALTURA(5, 12);
            Console.WriteLine(uno.ToString());

            ALTURA dos = new ALTURA();
            dos.Formula();
            Console.WriteLine(dos.ToString());
            Console.ReadKey();

        }

    }
}  
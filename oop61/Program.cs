using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop61
{
    class Nums
    {
        private int NumsOne;
        private int NumsTwo;

        public Nums()
        {

        }

        public Nums(int NumsOnen)
        {
            NumsOne = NumsOnen;
        }

        public Nums(int NumsOnen, int NumsTwon)
        {
            NumsOne = NumsOnen;
            NumsTwo = NumsTwon;
        }

        public void Display()
        {
            Console.WriteLine($"{NumsOne} {NumsTwo}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Nums num = new Nums();
            num.Display();
            Nums NumsOnen = new Nums(1);
            NumsOnen.Display();
            Nums NumsTwon = new Nums(2, 3);
            NumsTwon.Display();

            Console.ReadLine();
        }
    }
}

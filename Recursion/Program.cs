using System;

namespace Recursion
{
    class Program
    {
        public int Recursion_NaturalNo(int val, int nth)
        {
            if(nth<1)
            {
                return val;
            }
            nth--;
            Console.WriteLine(val);

            return Recursion_NaturalNo(val+1,nth);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Print first 10 natural no.s ");
            obj.Recursion_NaturalNo(1, 10);
        }
    }
}


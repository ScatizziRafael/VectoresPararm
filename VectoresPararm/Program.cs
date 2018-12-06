using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectoresPararm
{
    class Program
    {
        const int MAX = 10;
        static void Main(string[] args)
        {
            int[] x = new int[MAX];
            Leer(x);
            Imprimir(x);
            Console.ReadKey();
        }
        public static void Leer(int [] x)
        {
            for (int i=0;i<MAX;i++)
            {
                Console.WriteLine("\nIngrese el elemento {0}", i + 1);
                x[i] = Int32.Parse(Console.ReadLine());
            }
        }
        public static void Imprimir(int [] x)
        {
            foreach(int num in x)
            {
                Console.WriteLine("\nElemento {0}",num);
            }
        }
    }
}

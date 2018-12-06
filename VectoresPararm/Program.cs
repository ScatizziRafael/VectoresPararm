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
            if (Buscar(x, 3) == true)
                Console.WriteLine("\n3 Encontrado");
            else
                Console.WriteLine("\n3 NO Exisite");
            if (Buscar2(x, 10) == true)
                Console.WriteLine("\n10 Encontrado");
            else
                Console.WriteLine("\n10 NO EXISTE");

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
        public static bool Buscar(int[] x, int y)
        {
            bool encontrado = false;
            foreach(int num in x)
            {
                if(num==y)
                {
                    encontrado = true;
                    break;
                }
            }
            return encontrado;
        }
        public static bool Buscar2(int []x, int y)
        {
            bool encontrado = false;
            int i = 0;
            while(i<MAX && encontrado==false)
            {
                if (x[i] == y)
                    encontrado = true;
                i++;
            }
            return encontrado;
        }
    }
}

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
            string[] Nombres = new string[MAX];

            Leer(x);
            Imprimir(x);

            Ordenar(x);
            Console.WriteLine("\nVector Ordenado: ");
            Imprimir(x);

            if (Buscar(x, 3) == true)
                Console.WriteLine("\n3 Encontrado");
            else
                Console.WriteLine("\n3 NO Exisite");
            if (Buscar2(x, 10) == true)
                Console.WriteLine("\n10 Encontrado");
            else
                Console.WriteLine("\n10 NO EXISTE");
            //TRABAJANDO CON EL VECTOR DE CADENA DE VECTORES
            Console.Write("\nIngrese los nombres");
            LeerNombres(Nombres);
            ImprimirNombre(Nombres);

            Console.ReadKey();
        }
        public static void Leer(int [] x)
        {
            for (int i=0;i<MAX;i++)
            {
                Console.Write("\nIngrese el elemento {0}: ", i + 1);
                x[i] = Int32.Parse(Console.ReadLine());
            }
        }
        public static void LeerNombres(string[] x)
        {
            for (int i = 0; i < MAX; i++)
            {
                Console.Write("\nIngrese el Nombre : ", i + 1);
                x[i] = Console.ReadLine();
            }
        }
        public static void Imprimir(int [] x)
        {
            foreach(int num in x)
            {
                Console.Write("\nElemento {0} ",num);
            }
        }
        public static void ImprimirNombre(string[] x)
        {
            foreach (string num in x)
            {
                Console.Write("\nNombre Ordenado: ", num);
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
        public static void Ordenar(int []x)
        {
            int aux = 0;
            for (int i=0; i<x.Length;i++)
                for (int j = i + 1; j < x.Length; j++)
                    if(x[i]>x[j])
                    {
                        aux = x[i];
                        x[i] = x[j];
                        x[j]= aux;
                    }
                

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioconbucle5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TUTORIAL 5|  Encontrar La Suma De Números Impares Entre 1 a N

            int numero, suma = 0;

            Console.WriteLine("Ingrese un Número: ");
            numero=Convert.ToInt32(Console.ReadLine());
            //1+3=4

            for(int i = 1;i <= numero; i += 2)
            {
                suma += i;
            }
            Console.WriteLine("La suma de los numeros impares entre 1 y "+numero + " = "+suma);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_NUMEROS_PRIMOS
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // DE LOS PRIMERO 100 NUMEROS ¿ CUALES SON NUMEROS PRIMOS?

            // SI TUVIERA QUE INGRESAR NUMERO POR NUMERO
            // SUPONIENDO QUE EL NUMERO QUE SE INGRESA ES UN VALOR
            // DEL TIPO NUMERO

            // Console.WriteLine("Ingrese un número: ");
            // string numero = Console.ReadLine();
            // int num = int.Parse(numero);
            
            // SI QUEREMOS HACER UNA LISTA DE LOS 100 NUMEROS          
            List<int> lista = new List<int>();
            for (int e = 1; e <= 100; e++)
            {
                lista.Add(e);
            }           
                
            // LLAMAOS A LA FUNCION MEDIANTE LA HERRAMIENTA FOEACH 
            foreach (var item in lista)
                {

                    if (NumeroPrimo(item))
                    {
                        Console.WriteLine(item + " es un número primo!");
                    }
                    else
                    {
                        // Console.WriteLine(item + " no es un número primo!");
                    }
                }
                Console.Read();

        }

        // FUNCION QUE VERIFICA SI UN NUMERO ES PRIMO
        public static bool NumeroPrimo(int item)
        {
            for (int i = 2; i < item; i++)
            {
                if (item % i == 0)
                {
                    return false;
                }
              
            }
            return true;
        }
    }
}

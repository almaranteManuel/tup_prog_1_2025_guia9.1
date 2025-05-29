using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Numerics;
namespace ejercicio1._1
{
//    Realice un pequeño programa que solicite una cantidad indeterminada de números enteros y los almacene en un vector.
//    Se desconoce la cantidad máxima de valores a procesar en todo momento.Defina un vector para una capacidad máxima de 100 elementos.

//Terminada la carga de datos, procese el vector recorriendo el mismo, calculando y mostrando lo siguiente:
//Imprimir el listado completo de números ingresados, indicando también el orden de cada número.Ejemplo: 0:2  1:23  2:4  3:2 ..
//Promedio de todos los valores cargados en el arreglo.
//Valor Máximo y posición o índice en la que se encontró dicho valor.
//Valor mínimo y posición o índice en la que se encontró dicho valor.

    internal class Program
    {
        static void Main(string[] args)
        {
            #region inciadores
            int[] nums;
            int contador = 0;
            int acumulador = 0;
            double promedio = 0;
            int maximo;
            int minimo;
            nums = new int[100];
            #endregion

            Console.WriteLine("ingrese un numero ");
            int num = Convert.ToInt32(Console.ReadLine());
            maximo = num;
            minimo = num;

            while (num != -1 )
            {
                
               
                Console.WriteLine("ingrese el siguiente numero o -1 para salir  ");
                num = Convert.ToInt32(Console.ReadLine());

                nums[contador] = num;
                contador++;
                
            }

            for (int i = 0; i < contador; i++)
            {
                acumulador += nums[i];

                if (num != -1 && num > maximo)
                {
                    maximo = nums[i];
                }
                if (num != -1 && num < minimo)
                {
                    minimo = nums[i];
                }
            }

            promedio = contador / acumulador;

            Console.WriteLine("el promedio es: " +  promedio);
            Console.WriteLine("el maximo es " + maximo);
            Console.WriteLine("el minimo es " + minimo);
        }
    }
}

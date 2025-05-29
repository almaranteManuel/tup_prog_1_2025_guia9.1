namespace _2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region inciadores
            int[] nums;
            int contador = 0;
            int acumulador = 0;
            nums = new int[100];
            #endregion

            Console.WriteLine("ingrese un numero ");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num != -1 && num < 100)
            {

                nums[contador] = num;
                contador++;

                Console.WriteLine("ingrese el siguiente numero o -1 para salir  ");
                num = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < contador; i++)
            {
                acumulador += nums[i];
                Console.WriteLine(i + ":" + nums[i]);
            }
            for ()
            {
                for () {
                }
            }
        }
    }
}

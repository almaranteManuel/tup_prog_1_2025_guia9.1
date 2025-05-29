namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] espadas;
            espadas = new int[6];
            
            for (int i = 0; i < espadas.Length; i++)
            {
                Console.WriteLine("ingrese el numero de la carta " + i );
                espadas[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int h = 0; h < espadas.Length; h++)
            {
                Console.WriteLine("el numero de  la carta de espadas  es: " + espadas[h]);
            }
        }
    }
}

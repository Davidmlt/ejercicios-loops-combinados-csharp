namespace forxfor;

class Program
{
    static void Main(string[] args)
    {
        //FOR CON FOR

        int n, promedio;

        for (int x = 0; x < 10; x++)
        {
            promedio = 0;
            for (int y = 0; y < 20; y++)
            {
                Console.WriteLine("Ingrese las edades: ");
                n = int.Parse(Console.ReadLine());

                promedio += n;
            }
            promedio /= 20;
            Console.WriteLine("El promedio de edades es de: " + promedio);
        }
    }
}

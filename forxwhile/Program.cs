namespace forxwhile;

class Program
{
    static void Main(string[] args)
    {
        //FOR CON WHILE

        int n, promedio, con = 0;


        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingrese la edad:");
            n = int.Parse(Console.ReadLine());
            promedio = 0;
            con = 0;
            while (n != 0)
            {
                promedio += n;
                con++;

                Console.WriteLine("Ingrese la edad:");
                n = int.Parse(Console.ReadLine());

            }
            promedio /= con;
            Console.WriteLine("El promedio de edades es de: " + promedio);
        }
    }
}

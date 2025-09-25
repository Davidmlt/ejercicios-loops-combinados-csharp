namespace whilexwhile;

class Program
{
    static void Main(string[] args)
    {
        //WHILE CON WHILE

        int n, acu = 0, con = 0, promedio;

        Console.WriteLine("Ingrese la edad: ");
        n = int.Parse(Console.ReadLine());

        while (n > 0)
        {
            acu = 0;
            con = 0;

            while (n != 0)
            {
                acu += n;
                con++;
                Console.WriteLine("Ingrese la edad: ");
                n = int.Parse(Console.ReadLine());
            }
            promedio = acu / con ;

            Console.WriteLine("El promedio de edades es: " + promedio);

            Console.WriteLine("Ingrese 1 para continuar o 0 para terminar");
            n = int.Parse(Console.ReadLine());
        }
    }
}

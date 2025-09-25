namespace whilexfor;

class Program
{
    static void Main(string[] args)
    {
        //WHILE CON FOR

        int n, acu = 0, con = 0, promedio; ;

        Console.WriteLine("Ingrese 1 para ingresar o 0 para terminar");
        n = int.Parse(Console.ReadLine());

        while (n != 0)
        {
            acu = 0;
            con = 0;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese la edad: ");
                n = int.Parse(Console.ReadLine());
                acu += n;
                con++;
            }
            promedio = acu / con;
            Console.WriteLine("El promedio de edades es: " + promedio);

            Console.WriteLine("Ingrese 1 para continuar o 0 para terminar");
            n = int.Parse(Console.ReadLine());
        }
    }
}

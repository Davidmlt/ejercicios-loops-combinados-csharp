namespace ejercicio;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa para ingresar 10 números.
        //  El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

        int n, con = 0, primo = 0;

        for (int x = 0; x < 10; x++)
        {
            con = 0;
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            for (int y = 1; y <= n; y++)
            {
                if (n % y == 0)
                {
                    con++;
                }
            }
            if (con == 2)
            {
                primo++;
            }
        }
        Console.WriteLine("En total hay: " + primo + " numeros primos");
    }
}

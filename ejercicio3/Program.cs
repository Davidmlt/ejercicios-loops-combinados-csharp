namespace ejercicio3;

class Program
{
    static void Main(string[] args)
    {
        //Hacer un programa para recibir listas de números positivos que están separadas 
        // entre sí por un cero. El fin de la carga se notifica con un número negativo. 
        // Luego mostrar cuántos números tiene cada lista.

        int n, conLista = 0, conNumeros;

        Console.WriteLine("Ingrese un numero positivo: ");
        n = int.Parse(Console.ReadLine());

        while (n >= 0)
        {
            conNumeros = 0;
            while (n > 0)
            {
                conNumeros++;
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
            }
            conLista++;
            Console.WriteLine("En la lista numero " + conLista + " hay " + conNumeros + " numeros");
            Console.WriteLine("Ingrese un numero positivo para continuar o un negativo para cortar:");
            n = int.Parse(Console.ReadLine());

        }


    }
}

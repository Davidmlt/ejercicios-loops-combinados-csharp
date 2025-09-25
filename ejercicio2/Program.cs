namespace ejercicio2;

class Program
{
    static void Main(string[] args)
    {
        //Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros.
        //  Se pide determinar e informar:

        //El número de grupo con mayor porcentaje de números impares respecto al total de números
        // que forman el grupo.
        //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

        int n, conImpares, mayor, conNumeros, grupoImpares = 0, grupoMayorMenor = 0;
        double porcentaje, maximo = 0;
        bool  banOk;

        for (int x = 0; x < 5; x++)
        {
            conImpares = 0;
            conNumeros = 0;
            porcentaje = 0;
            banOk = true;
            
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            n = mayor;

            while (n != 0)
            {
                conNumeros++;
                if (n % 2 != 0)
                {
                    conImpares++;
                }
                if (n <= mayor)
                {
                    mayor = n;
                }
                else
                {
                    banOk = false;
                }

                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

            }
            porcentaje = conImpares * 100 / conNumeros;
            if (x == 0)
            {
                maximo = porcentaje;
                grupoImpares = x + 1;
            }
            else if (porcentaje > maximo)
            {
                maximo = porcentaje;
                grupoImpares = x + 1;
            }

            if (banOk == true)
            {
                grupoMayorMenor++;
            }

        }
        Console.WriteLine("El grupo con el porcentaje mayor de numeros impares es el " + grupoImpares);
        Console.WriteLine("Hay " + grupoMayorMenor + " grupos ordenados de mayor a menor");
    }
}

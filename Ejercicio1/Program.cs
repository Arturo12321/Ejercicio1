using System;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("----- Programa para encontrar números primos -----");


            Console.Write("Ingrese un número: ");
            if (int.TryParse(Console.ReadLine(), out int limite))
            {
                if (limite >= 2)
                {
                    Console.WriteLine($"Números primos hasta {limite}:");
                    EncontrarNumerosPrimos(limite);
                }
                else
                {
                    Console.WriteLine("Error: Ingrese un número mayor o igual a 2.");
                }
            }
            else
            {
                Console.WriteLine("Error: Ingrese un número válido.");
            }

            Console.WriteLine("¿Quieres hacer otra consulta? (S/N)");
            string respuesta = Console.ReadLine();

            if (respuesta != null && respuesta.Trim().ToUpper() != "S")
            {
                continuar = false;
            }
        }
    }

    static void EncontrarNumerosPrimos(int limite)
    {
        for (int i = 2; i <= limite; i++)
        {
            if (EsPrimo(i))
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }

    static bool EsPrimo(int numero)
    {
        if (numero < 2) return false;
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}

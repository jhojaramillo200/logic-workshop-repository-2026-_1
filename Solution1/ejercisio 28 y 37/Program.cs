
class Ejercicio28
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la viga: ");

        char viga = Console.ReadKey().KeyChar;  // Lee un solo carácter
        Console.WriteLine(); // Salto de línea

        if (EsValida(viga))
        {
            if (SoportaPeso(viga))
            {
                Console.WriteLine("La viga soporta el peso!");
            }
            else
            {
                Console.WriteLine("La viga no soporta el peso");
            }
        }
        else
        {
            Console.WriteLine("La viga esta mal construida");
        }
    }

    static bool EsValida(char viga)
    {
        // Si es alguno de estos caracteres, no es válida
        if (viga == '*' || viga == 'T' || viga == '=')
        {
            return false;
        }

        return true;
    }

    static bool SoportaPeso(char viga)
    {
        // Ejemplo de condición (puedes modificarla)
        if (viga == 'H')
        {
            return true;
        }

        return false;
    }
}
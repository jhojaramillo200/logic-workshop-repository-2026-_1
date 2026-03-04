static void Main()
{
    Console.WriteLine("Ingrese ubicación de los caballos (Ej: B7,C5,E2,H7,G5,F6):");
    string entrada = Console.ReadLine().ToUpper();

    string[] posiciones = entrada.Split(',');

    // Lista para guardar las posiciones convertidas
    Dictionary<string, (int fila, int columna)> caballos = new Dictionary<string, (int, int)>();

    // Convertir cada posición a coordenadas numéricas
    foreach (string pos in posiciones)
    {
        string p = pos.Trim();
        int columna = p[0] - 'A' + 1; // Convertir letra a número
        int fila = int.Parse(p[1].ToString());
        caballos[p] = (fila, columna);
    }

    Console.WriteLine();

    // Analizar conflictos
    foreach (var caballo1 in caballos)
    {
        Console.Write($"Analizando Caballo en {caballo1.Key} => ");

        bool conflicto = false;

        foreach (var caballo2 in caballos)
        {
            if (caballo1.Key != caballo2.Key)
            {
                if (HayConflicto(caballo1.Value, caballo2.Value))
                {
                    Console.Write($"Conflicto con {caballo2.Key}  ");
                    conflicto = true;
                }
            }
        }

        if (!conflicto)
        {
            Console.Write("Sin conflicto");
        }

        Console.WriteLine();
    }
}

// Método que verifica si dos caballos se atacan
static bool HayConflicto((int fila, int columna) c1, (int fila, int columna) c2)
{
    int difFila = Math.Abs(c1.fila - c2.fila);
    int difCol = Math.Abs(c1.columna - c2.columna);

    return (difFila == 2 && difCol == 1) || (difFila == 1 && difCol == 2);
}

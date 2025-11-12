// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        Console.WriteLine("Números pares del 1 al 20:");

        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        // Mantener la consola abierta
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

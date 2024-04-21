using Ejercicio2;

internal class Program
{
    private static void Main(string[] args)
    {
        ManejadorLista manejador = new ManejadorLista();

        manejador.AgregarElemento(10);
        manejador.AgregarElemento(20);
        manejador.AgregarElemento(30);

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Intentando eliminar elemento {i + 1}");
            manejador.EliminarElemento();
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
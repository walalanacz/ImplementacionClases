// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using ImplementacionClases.Utils;
using ImplementacionClases.DTO;
using ImplementacionClases.DAL;

//Console.WriteLine(ConsoleUtils.Saludar("Matias"));

/* Ejemplo
* Console.BackgroundColor = ConsoleColor.DarkGray;
* Console.ForegroundColor = ConsoleColor.Green;
* Console.Write("Escribe un nombre: ");
* string nombre = Console.ReadLine();
Console.WriteLine($"Ha escrito {nombre}"); */

while (Menu())
{
    
    Console.ReadKey();
}

static bool Menu()
{
    bool continuar = true;

    Console.Clear();
    Console.Title = "Ejercicio Menú + Clases";

    Console.WriteLine("Menú de opciones");
    Console.WriteLine("----------------");
    Console.WriteLine("1) Listar datos");
    Console.WriteLine("2) Agregar datos");
    Console.WriteLine("");
    Console.WriteLine("0) Salir");
    Console.Write("Ingrese su opción: ");
    string opcion = Console.ReadLine().Trim();

    switch (opcion)
    {
        case "1":
            Console.WriteLine("Escogio la opción 1");
            break;
        case "2":
            Console.WriteLine("Escogio la opción 2");
            OpcionInsertar();
            break;
        case "0":
            Console.WriteLine("Saliendo del programa ...");
            continuar = false;
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }
    return continuar;


}

static void OpcionInsertar()
{
    //DatoDTO dato = new DatoDTO();
    /*
     *  private int id;
        private float flujo;
        private float nivel;
        private float temperatura;
        private float voltaje;
     */

    DatoDAL datoDAL = new DatoDAL();

    try
    {
        Console.Write("Ingrese el ID: ");
        int id = Convert.ToInt32(Console.ReadLine().Trim());

        Console.Write("Ingrese valor de flujo: ");
        float flujo = float.Parse(Console.ReadLine().Trim());

        Console.Write("Ingrese valor de nivel: ");
        float nivel = float.Parse(Console.ReadLine().Trim());

        Console.Write("Ingrese valor de la temperatura: ");
        float temperatura = float.Parse(Console.ReadLine().Trim());

        Console.Write("Ingrese valor de voltaje: ");
        float voltaje = float.Parse(Console.ReadLine().Trim());

        DatoDTO nuevoIngresoDato = new DatoDTO()
        {
            Id = id,
            Flujo = flujo,
            Nivel = nivel,
            Temperatura = temperatura,
            Voltaje = voltaje
        };

        if (datoDAL.Insertar(nuevoIngresoDato))
        {
            Console.WriteLine($"Se ha insertado un nuevo dato");
        }
        else
        {
            Console.WriteLine($"No se ha podido insertar el nuevo dato");
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Ingrese correctamente los datos e intente otra vez");
    }
}
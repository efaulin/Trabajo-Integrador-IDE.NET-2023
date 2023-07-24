// See https://aka.ms/new-console-template for more information

using Entidad;

Console.WriteLine("¡Bienvenido al sistema de recepcion de hotel!");
//Usuarios en construccion
Console.Write("Ingrese usuario: ");
string usuario = Console.ReadLine();

Console.Write("Ingrese contraseña: ");
string contra = Console.ReadLine();

ConsoleKeyInfo opc;
do
{
    Console.Clear();
    Console.WriteLine("------------ Menu ------------");
    Console.WriteLine("1. CRUD Habitaciones");
    //Console.WriteLine("2. CRUD Tipos de habitaciones");
    //Console.WriteLine("3. CRUD Servicios");
    //Console.WriteLine("4. CRUD Reserva");
    //Console.WriteLine("5. CRUD Personas");
    Console.WriteLine("0. Salir");
    Console.WriteLine();
    Console.Write("Ingrese una opcion: ");
    opc = Console.ReadKey();

    switch (opc.Key)
    {
        case ConsoleKey.D1: MenuHabitacion(); break;
        case ConsoleKey.D2: break;
        case ConsoleKey.D3: break;
        case ConsoleKey.D4: break;
        case ConsoleKey.D5: break;
    }

} while (opc.Key != ConsoleKey.D0);

#region Funciones Menu
void MenuPersona()
{
    ConsoleKeyInfo opc;
    do
    {
        Console.Clear();
        Console.WriteLine("-------- CRUD Personas --------");
        Console.WriteLine("1. CRUD Clientes");
        Console.WriteLine("2. CRUD Recepcionistas");
        Console.WriteLine("3. CRUD Gerentes");
        Console.WriteLine("0. Salir");
        Console.WriteLine();
        Console.Write("Ingrese una opcion: ");
        opc = Console.ReadKey();

        switch (opc.Key)
        {
            case ConsoleKey.D1: break;
            case ConsoleKey.D2: break;
            case ConsoleKey.D3: break;
        }

    } while (opc.Key != ConsoleKey.D0);
}

void MenuHabitacion()
{
    ConsoleKeyInfo opc;
    do
    {
        Console.Clear();
        Console.WriteLine("-------- CRUD Habitaciones --------");
        Console.WriteLine("1. Ver habitaciones disponibles");
        Console.WriteLine("2. Cargar habitacion");
        Console.WriteLine("3. Eliminar habitacion");
        Console.WriteLine("4. Ver habitaciones dadas de baja");
        Console.WriteLine("0. Salir");
        Console.WriteLine();
        Console.Write("Ingrese una opcion: ");
        opc = Console.ReadKey();

        List<TipoHabitacion> lstTipoHabitaciones;
        List<Habitacion> lstHabitaciones;
        Habitacion habitacion;
        switch (opc.Key)
        {
            case ConsoleKey.D1:
                Console.Clear();
                Console.WriteLine("-------------------------------------------");
                lstHabitaciones = Negocio.Habitacion.getAll();
                foreach (Habitacion hbt in lstHabitaciones)
                {
                    Console.WriteLine("ID: " + hbt.id);
                    Console.WriteLine("nroCamas: " + hbt.numeroCamas);
                    Console.WriteLine("estado: " + hbt.estado);
                    Console.WriteLine("nroHabitacion: " + hbt.numeroHabitacion);
                    Console.WriteLine("pisoHabitacion: " + hbt.pisoHabitacion);
                    Console.WriteLine("tipoHabitacion: " + hbt.tipoHabitacion.descripcion);
                    Console.WriteLine("Precio: " + hbt.Precio());
                    Console.WriteLine("  - Actualizacion de precio: " + hbt.tipoHabitacion.lstTipHab_Precio.Last().fecha.ToString());
                    Console.WriteLine("-------------------------------------------");
                }
                Console.Write("Presione una tecla para volver al menu...");
                Console.ReadKey();
                break;

            case ConsoleKey.D2: 
                Console.Clear();
                Console.WriteLine("Tipos de habitaciones disponibles:");
                lstTipoHabitaciones = Negocio.TipoHabitacion.getAll();
                foreach (TipoHabitacion tpHbt in lstTipoHabitaciones)
                {
                    Console.WriteLine("ID: " + tpHbt.id.ToString() + " - " + tpHbt.descripcion);
                }
                Console.Write("Ingrese ID del tipo de habitacion: ");
                string? idTipHbt = Console.ReadLine();

                Console.Clear();
                TipoHabitacion tipHbt = Negocio.TipoHabitacion.getOne(int.Parse(idTipHbt));
                Console.WriteLine("Tipo de habitacion: " + tipHbt.descripcion.ToString());
                Console.Write("Ingrese cantidad de camas: ");
                int nroCamas = int.Parse(Console.ReadLine());
                Console.Write("Ingrese numero de habitacion: ");
                int nroHbt = int.Parse(Console.ReadLine());
                Console.Write("Ingrese piso de la habitacion: ");
                int pisoHbt = int.Parse(Console.ReadLine());

                Console.Clear();
                habitacion = Negocio.Habitacion.Create(new Habitacion(-1, nroCamas, true, nroHbt, pisoHbt, tipHbt, new List<Reserva>()));
                Console.WriteLine("--- Habitacion cargada ---");
                Console.WriteLine("ID: " + habitacion.id);
                Console.WriteLine("nroCamas: " + habitacion.numeroCamas);
                Console.WriteLine("estado: " + habitacion.estado);
                Console.WriteLine("nroHabitacion: " + habitacion.numeroHabitacion);
                Console.WriteLine("pisoHabitacion: " + habitacion.pisoHabitacion);
                Console.WriteLine("tipoHabitacion: " + habitacion.tipoHabitacion.descripcion);
                Console.WriteLine("Precio: " + habitacion.Precio());
                Console.WriteLine("  - Actualizacion de precio: " + habitacion.tipoHabitacion.lstTipHab_Precio.Last().fecha.ToString());
                Console.WriteLine("-------------------------------------------");
                Console.Write("Presione una tecla para volver al menu...");
                Console.ReadKey();
                break;

            case ConsoleKey.D3:
                Console.Clear();
                Console.WriteLine("Habitaciones disponibles:");
                lstHabitaciones = Negocio.Habitacion.getAll();
                foreach (Habitacion hbt in lstHabitaciones)
                {
                    Console.WriteLine("ID: " + hbt.id.ToString() + " - Piso: " + hbt.pisoHabitacion.ToString() + " Nro: " + hbt.numeroHabitacion.ToString());
                }
                Console.Write("Ingrese ID del tipo de habitacion: ");
                string? idHbt = Console.ReadLine();

                Console.Clear();
                if (Negocio.Habitacion.Delete(int.Parse(idHbt)))
                {
                    Console.WriteLine("Habitacion ID: " + idHbt.ToString() + " eliminada");
                }
                else
                {
                    Console.WriteLine("Error");
                }
                Console.Write("Presione una tecla para volver al menu...");
                Console.ReadKey();
                break;

            case ConsoleKey.D4:
                Console.Clear();
                Console.WriteLine("-------------------------------------------");
                lstHabitaciones = Negocio.Habitacion.getAllDisabled();
                foreach (Habitacion hbt in lstHabitaciones)
                {
                    Console.WriteLine("ID: " + hbt.id);
                    Console.WriteLine("nroCamas: " + hbt.numeroCamas);
                    Console.WriteLine("estado: " + hbt.estado);
                    Console.WriteLine("nroHabitacion: " + hbt.numeroHabitacion);
                    Console.WriteLine("pisoHabitacion: " + hbt.pisoHabitacion);
                    Console.WriteLine("tipoHabitacion: " + hbt.tipoHabitacion.descripcion);
                    Console.WriteLine("Precio: " + hbt.Precio());
                    Console.WriteLine("  - Actualizacion de precio: " + hbt.tipoHabitacion.lstTipHab_Precio.Last().fecha.ToString());
                    Console.WriteLine("-------------------------------------------");
                }
                Console.Write("Presione una tecla para volver al menu...");
                Console.ReadKey();
                break;
        }

    } while (opc.Key != ConsoleKey.D0);
}
#endregion
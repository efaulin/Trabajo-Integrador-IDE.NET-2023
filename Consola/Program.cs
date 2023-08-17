// See https://aka.ms/new-console-template for more information

using Entidad.Models;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

Console.WriteLine("¡Bienvenido al sistema de recepcion de hotel!");
//Usuarios en construccion (manejar excepciones y validacion)
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
    Console.WriteLine("2. CRUD Huespedes");
    Console.WriteLine("3. CRUD Tipos de habitaciones");
    //Console.WriteLine("X. CRUD Servicios");
    //Console.WriteLine("X. CRUD Reserva");
    Console.WriteLine("0. Salir");
    Console.WriteLine();
    Console.Write("Ingrese una opcion: ");
    opc = Console.ReadKey();

    switch (opc.Key)
    {
        case ConsoleKey.D1: MenuHabitacion(); break;
        case ConsoleKey.D2: MenuHuesped(); break;
        case ConsoleKey.D3: MenuTipoHabitacion(); break;
        case ConsoleKey.D4: break;
        case ConsoleKey.D5: break;
    }

} while (opc.Key != ConsoleKey.D0);

#region Funciones Menu
void MenuHuesped()
{
    ConsoleKeyInfo opc;
    do
    {
        Console.Clear();
        Console.WriteLine("-------- CRUD Personas --------");
        Console.WriteLine("1. Ver Huespedes\n2. Crear Huesped\n3. Editar Huesped\n4. Borrar Huesped\n0. Salir\n");
        Console.Write("Ingrese una opcion: ");
        opc = Console.ReadKey();

        List<Huesped> lstHuespedes;
        Huesped hpd;
        string? idHpd;
        switch (opc.Key)
        {
            case ConsoleKey.D1:
                Console.Clear();
                Console.WriteLine("-------------------------------------------");
                lstHuespedes = Negocio.Huesped.getAll();
                if (lstHuespedes.Count == 0){
                    Console.WriteLine("-NO SE HAN ENCONTRADO HUESPEDES REGISTRADOS-");
                }
                else {
                    foreach (Huesped tmpHpd in lstHuespedes)
                    {
                        Console.WriteLine("ID: " + tmpHpd.IdHuesped);
                        Console.WriteLine("nombre: " + tmpHpd.Nombre);
                        Console.WriteLine("apellido: " + tmpHpd.Apellido);
                        Console.WriteLine("nroDocumento: " + tmpHpd.NumeroDocumento);
                        Console.WriteLine("tipoDocumento: " + tmpHpd.TipoDocumento);
                        Console.WriteLine("-------------------------------------------");
                    }
                }
                Console.Write("\nPresione una tecla para volver al menu...");
                Console.ReadKey();
                break;

            case ConsoleKey.D2:
                Console.Clear();
                Console.WriteLine("-------------------------------------------");
                hpd = new Huesped();
                Console.WriteLine("Nuevo Huesped");
                Console.Write("Ingrese nombre: ");
                hpd.Nombre = Console.ReadLine();
                Console.Write("Ingrese apellido: ");
                hpd.Apellido = Console.ReadLine();
                Console.Write("Seleccione tipo de documento: [1.DNI / 2.LC / 3.LE]: ");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1: hpd.TipoDocumento = "DNI"; break;
                    case ConsoleKey.D2: hpd.TipoDocumento = "LC"; break;
                    case ConsoleKey.D3: hpd.TipoDocumento = "LE"; break;
                }
                Console.WriteLine(" -> " + hpd.TipoDocumento);
                Console.Write("Ingrese numero de documento: ");
                hpd.NumeroDocumento = Console.ReadLine();
                Negocio.Huesped.Create(hpd);

                Console.Clear();
                Console.WriteLine("--- Huesped cargado ---");
                Console.WriteLine("ID: " + hpd.IdHuesped);
                Console.WriteLine("nombre: " + hpd.Nombre);
                Console.WriteLine("apellido: " + hpd.Apellido);
                Console.WriteLine("nroDocumento: " + hpd.NumeroDocumento);
                Console.WriteLine("tipoDocumento: " + hpd.TipoDocumento);
                Console.WriteLine("-------------------------------------------");
                Console.Write("\nPresione una tecla para volver al menu...");
                Console.ReadKey();
                break;

            case ConsoleKey.D3:
                Console.Clear();
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Huespedes registrados:");
                lstHuespedes = Negocio.Huesped.getAll();
                if (lstHuespedes.Count == 0){
                    Console.WriteLine("-NO SE HAN ENCONTRADO HUESPEDES REGISTRADOS-");
                }
                else
                {
                    foreach (Huesped tmpHpd in lstHuespedes)
                    {
                        Console.WriteLine("ID: " + tmpHpd.IdHuesped.ToString() + " " + tmpHpd.TipoDocumento + ":" + tmpHpd.NumeroDocumento + " - Nombre: " + tmpHpd.Nombre + " Apellido: " + tmpHpd.Apellido);
                    }
                    Console.Write("Ingrese ID del tipo de habitacion: ");
                    idHpd = Console.ReadLine();
                    hpd = lstHuespedes.Find(delegate (Huesped hpd) { return hpd.IdHuesped == int.Parse(idHpd); });
                    Console.Clear();

                    if (hpd != null)
                    {
                        Console.WriteLine("ID: " + hpd.IdHuesped);
                        Console.Write("Nombre: " + hpd.Nombre + " -> ");
                        hpd.Nombre = Console.ReadLine();
                        Console.Write("Apellido: " + hpd.Apellido + " -> ");
                        hpd.Apellido = Console.ReadLine();
                        Console.Write("Seleccione tipo de documento: [1.DNI / 2.LC / 3.LE]: ");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1: hpd.TipoDocumento = "DNI"; break;
                            case ConsoleKey.D2: hpd.TipoDocumento = "LC"; break;
                            case ConsoleKey.D3: hpd.TipoDocumento = "LE"; break;
                        }
                        Console.WriteLine(" -> " + hpd.TipoDocumento);
                        Console.Write("Numero de documento: " + hpd.NumeroDocumento + " -> ");
                        hpd.NumeroDocumento = Console.ReadLine();
                        Negocio.Huesped.Update(hpd);

                        Console.Clear();
                        Console.WriteLine("--- Huesped editado ---");
                        Console.WriteLine("ID: " + hpd.IdHuesped);
                        Console.WriteLine("nombre: " + hpd.Nombre);
                        Console.WriteLine("apellido: " + hpd.Apellido);
                        Console.WriteLine("nroDocumento: " + hpd.NumeroDocumento);
                        Console.WriteLine("tipoDocumento: " + hpd.TipoDocumento);
                        Console.WriteLine("-------------------------------------------");
                    }
                }               
                Console.Write("\nPresione una tecla para volver al menu...");
                Console.ReadKey();
                break;

            case ConsoleKey.D4:
                Console.Clear();
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Huespedes registrados:");
                lstHuespedes = Negocio.Huesped.getAll();
                if (lstHuespedes.Count == 0)
                {
                    Console.WriteLine("-NO SE HAN ENCONTRADO HUESPEDES REGISTRADOS-");
                }
                else
                {
                    foreach (Huesped tmpHpd in lstHuespedes)
                    {
                        Console.WriteLine("ID: " + tmpHpd.IdHuesped.ToString() + " - Nombre: " + tmpHpd.Nombre.ToString() + " Apellido: " + tmpHpd.Apellido.ToString());
                    }
                    Console.Write("Ingrese ID de huesped: ");
                    idHpd = Console.ReadLine();

                    Console.Clear();
                    if (Negocio.Huesped.Delete(lstHuespedes.Find(delegate (Huesped hpd) { return hpd.IdHuesped == int.Parse(idHpd); })))
                    {
                        Console.WriteLine("Huesped ID: " + idHpd.ToString() + " eliminado");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                Console.Write("\nPresione una tecla para volver al menu...");
                Console.ReadKey();
                break;
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
        Console.WriteLine("1. Ver habitaciones registradas");
        Console.WriteLine("2. Cargar habitacion");
        Console.WriteLine("3. Editar habitacion");
        Console.WriteLine("4. Eliminar habitacion");
        Console.WriteLine("0. Salir");
        Console.WriteLine();
        Console.Write("Ingrese una opcion: ");
        opc = Console.ReadKey();

        List<TipoHabitacion> lstTipoHabitaciones;
        List<Habitacion> lstHabitaciones;
        Habitacion hbt;
        TipoHabitacion tipHbt;
        string? idHbt;
        switch (opc.Key)
        {
            case ConsoleKey.D1:
                Console.Clear();
                Console.WriteLine("-------------------------------------------");
                lstHabitaciones = Negocio.Habitacion.getAll();
                if (lstHabitaciones.Count == 0){
                    Console.WriteLine("-NO SE HAN ENCONTRADO HABITACIONES REGISTRADAS-");
                }
                else
                {
                    foreach (Habitacion tmpHbt in lstHabitaciones)
                    {
                        Console.WriteLine("ID: " + tmpHbt.IdHabitacion);
                        Console.WriteLine("estado: " + tmpHbt.Estado.ToString());
                        Console.WriteLine("nroHabitacion: " + tmpHbt.NumeroHabitacion);
                        Console.WriteLine("pisoHabitacion: " + tmpHbt.PisoHabitacion);
                        Console.WriteLine("tipoHabitacion: " + tmpHbt.IdTipoHabitacionNavigation.Descripcion);
                        //Console.WriteLine("Precio: " + tmpHbt.IdTipoHabitacionNavigation.PrecioTipoHabitacions.Last().PrecioHabitacion.ToString());
                        Console.WriteLine("Precio: " + Negocio.TipoHabitacion.DevPrecioFecha(DateTime.Now, tmpHbt.IdTipoHabitacionNavigation).PrecioHabitacion.ToString());
                        Console.WriteLine("  - Actualizacion de precio: " + Negocio.TipoHabitacion.DevPrecioFecha(DateTime.Now, tmpHbt.IdTipoHabitacionNavigation).FechaPrecio.ToString());
                        Console.WriteLine("-------------------------------------------");
                    }
                }
                Console.Write("\nPresione una tecla para volver al menu...");
                Console.ReadKey();
                break;

            case ConsoleKey.D2: 
                Console.Clear();
                Console.WriteLine("Tipos de habitaciones disponibles:");
                lstTipoHabitaciones = Negocio.TipoHabitacion.getAll();
                if (lstTipoHabitaciones.Count == 0)
                {
                    Console.WriteLine("-NO SE HAN ENCONTRADO TIPO DE HABITACIONES REGISTRADAS-");
                    Console.WriteLine("Es necesario cargar un tipo de habitacion");
                }
                else
                {
                    foreach (TipoHabitacion tpHbt in lstTipoHabitaciones)
                    {
                        Console.WriteLine("ID: " + tpHbt.IdTipoHabitacion.ToString() + " - " + tpHbt.Descripcion);
                    }
                    Console.Write("Ingrese ID del tipo de habitacion: ");
                    string? idTipHbt = Console.ReadLine();

                    Console.Clear();
                    tipHbt = Negocio.TipoHabitacion.getOne(int.Parse(idTipHbt));
                    hbt = new Habitacion();
                    hbt.Estado = true;
                    hbt.IdTipoHabitacion = tipHbt.IdTipoHabitacion;
                    hbt.IdTipoHabitacionNavigation = tipHbt;
                    Console.WriteLine("Tipo de habitacion: " + tipHbt.Descripcion.ToString());
                    Console.Write("Ingrese numero de habitacion: ");
                    int nroHbt = int.Parse(Console.ReadLine());
                    hbt.NumeroHabitacion = nroHbt;
                    Console.Write("Ingrese piso de la habitacion: ");
                    int pisoHbt = int.Parse(Console.ReadLine());
                    hbt.PisoHabitacion = pisoHbt;
                    Negocio.Habitacion.Create(hbt);

                    Console.Clear();
                    Console.WriteLine("--- Habitacion cargada ---");
                    Console.WriteLine("ID: " + hbt.IdHabitacion);
                    Console.WriteLine("estado: " + hbt.Estado);
                    Console.WriteLine("nroHabitacion: " + hbt.NumeroHabitacion);
                    Console.WriteLine("pisoHabitacion: " + hbt.PisoHabitacion);
                    Console.WriteLine("tipoHabitacion: " + hbt.IdTipoHabitacionNavigation.Descripcion);
                    Console.WriteLine("Precio: " + Negocio.TipoHabitacion.DevPrecioFecha(DateTime.Now, hbt.IdTipoHabitacionNavigation).PrecioHabitacion.ToString());
                    Console.WriteLine("  - Actualizacion de precio: " + Negocio.TipoHabitacion.DevPrecioFecha(DateTime.Now, hbt.IdTipoHabitacionNavigation).FechaPrecio.ToString());
                    Console.WriteLine("-------------------------------------------");
                }
                Console.Write("\nPresione una tecla para volver al menu...");
                Console.ReadKey();
                break;

            case ConsoleKey.D3:
                Console.Clear();
                Console.WriteLine("Habitaciones registradas:");
                lstHabitaciones = Negocio.Habitacion.getAll();
                if (lstHabitaciones.Count == 0)
                {
                    Console.WriteLine("-NO SE HAN ENCONTRADO HABITACIONES REGISTRADAS-");
                }
                else
                {
                    foreach (Habitacion tmpHbt in lstHabitaciones)
                    {
                        Console.WriteLine("ID: " + tmpHbt.IdHabitacion.ToString() + " - Piso: " + tmpHbt.PisoHabitacion.ToString() + " Nro: " + tmpHbt.NumeroHabitacion.ToString());
                    }
                    Console.Write("Ingrese ID del tipo de habitacion: ");
                    idHbt = Console.ReadLine();
                    hbt = lstHabitaciones.Find(delegate (Habitacion hbt) { return hbt.IdHabitacion == int.Parse(idHbt); });
                    Console.Clear();

                    if (hbt != null)
                    {
                        Console.WriteLine("ID: " + hbt.IdHabitacion);
                        Console.Write("estado: " + hbt.Estado + " -> [1.True / 2.False]: ");
                        if (Console.ReadKey().Key == ConsoleKey.D1) { hbt.Estado = true; } else { hbt.Estado = false; }
                        Console.Write("\nnroHabitacion: " + hbt.NumeroHabitacion + " -> ");
                        hbt.NumeroHabitacion = int.Parse(Console.ReadLine());
                        Console.Write("\npisoHabitacion: " + hbt.PisoHabitacion + " -> ");
                        hbt.PisoHabitacion = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("tipoHabitacion: " + hbt.IdTipoHabitacionNavigation.Descripcion);
                        Console.WriteLine("Tipos de habitaciones disponibles:");
                        lstTipoHabitaciones = Negocio.TipoHabitacion.getAll();
                        foreach (TipoHabitacion tpHbt in lstTipoHabitaciones)
                        {
                            Console.WriteLine("ID: " + tpHbt.IdTipoHabitacion.ToString() + " - " + tpHbt.Descripcion);
                        }
                        Console.Write("Ingrese ID del tipo de habitacion: ");
                        hbt.IdTipoHabitacion = int.Parse(Console.ReadLine());
                        hbt.IdTipoHabitacionNavigation = Negocio.TipoHabitacion.getOne(hbt.IdTipoHabitacion);
                        Negocio.Habitacion.Update(hbt);

                        Console.Clear();
                        Console.WriteLine("--- Habitacion editada ---");
                        Console.WriteLine("ID: " + hbt.IdHabitacion);
                        Console.WriteLine("estado: " + hbt.Estado);
                        Console.WriteLine("nroHabitacion: " + hbt.NumeroHabitacion);
                        Console.WriteLine("pisoHabitacion: " + hbt.PisoHabitacion);
                        Console.WriteLine("tipoHabitacion: " + hbt.IdTipoHabitacionNavigation.Descripcion);
                        Console.WriteLine("Precio: " + Negocio.TipoHabitacion.DevPrecioFecha(DateTime.Now, hbt.IdTipoHabitacionNavigation).PrecioHabitacion.ToString());
                        Console.WriteLine("  - Actualizacion de precio: " + Negocio.TipoHabitacion.DevPrecioFecha(DateTime.Now, hbt.IdTipoHabitacionNavigation).FechaPrecio.ToString());
                        Console.WriteLine("-------------------------------------------");

                    }
                }
                Console.Write("\nPresione una tecla para volver al menu...");
                Console.ReadKey();
                break;

            case ConsoleKey.D4:
                Console.Clear();
                Console.WriteLine("Habitaciones registradas:");
                lstHabitaciones = Negocio.Habitacion.getAll();
                if (lstHabitaciones.Count == 0)
                {
                    Console.WriteLine("-NO SE HAN ENCONTRADO HABITACIONES REGISTRADAS-");
                }
                else
                {
                    foreach (Habitacion tmpHbt in lstHabitaciones)
                    {
                        Console.WriteLine("ID: " + tmpHbt.IdHabitacion.ToString() + " - Piso: " + tmpHbt.PisoHabitacion.ToString() + " Nro: " + tmpHbt.NumeroHabitacion.ToString());
                    }
                    Console.Write("Ingrese ID de habitacion: ");
                    idHbt = Console.ReadLine();

                    Console.Clear();
                    if (Negocio.Habitacion.Delete(lstHabitaciones.Find(delegate (Habitacion hbt) { return hbt.IdHabitacion == int.Parse(idHbt); })))
                    {
                        Console.WriteLine("Habitacion ID: " + idHbt.ToString() + " eliminada");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                Console.Write("\nPresione una tecla para volver al menu...");
                Console.ReadKey();
                break;
        }

    } while (opc.Key != ConsoleKey.D0);
}

void MenuTipoHabitacion()
{
    ConsoleKeyInfo opc;
    do
    {
        Console.Clear();
        Console.WriteLine("---- CRUD Tipos de habitaciones ----");
        Console.WriteLine("1. Ver Tipos de Habitaciones\n2. Crear Tipo de Habitacion\n3. Editar Tipo de Habitacion\n4. Cambiar precio de Tipo de Habitacion\n5. Borrar Tipo de Habitacion\n0. Salir\n");
        Console.Write("Ingrese una opcion: ");
        opc = Console.ReadKey();

        List<TipoHabitacion> lstTpHbt;
        TipoHabitacion tpHbt;
        PrecioTipoHabitacion prcTpHbt;
        string? idTpHbt;
        switch (opc.Key)
        {
            case ConsoleKey.D1:
                Console.Clear();
                Console.WriteLine("-------------------------------------------");
                lstTpHbt = Negocio.TipoHabitacion.getAll();
                if (lstTpHbt.Count == 0)
                {
                    Console.WriteLine("-NO SE HAN ENCONTRADO TIPOS DE HABITACIONES REGISTRADOS-");
                }
                else
                {
                    foreach (TipoHabitacion tmpTpHbt in lstTpHbt)
                    {
                        Console.WriteLine("ID: " + tmpTpHbt.IdTipoHabitacion);
                        Console.WriteLine("Descripcion: " + tmpTpHbt.Descripcion);
                        Console.WriteLine("nroCamas: " + tmpTpHbt.NumeroCamas);
                        Console.WriteLine("Precio: " + tmpTpHbt.PrecioTipoHabitacions.Last().PrecioHabitacion.ToString());
                        Console.WriteLine("  - Actualizacion de precio: " + tmpTpHbt.PrecioTipoHabitacions.Last().FechaPrecio.ToString());
                        Console.WriteLine("-------------------------------------------");
                    }
                }
                Console.Write("\nPresione una tecla para volver al menu...");
                Console.ReadKey();
                break;

            case ConsoleKey.D2:
                Console.Clear();
                Console.WriteLine("-------------------------------------------");
                tpHbt = new TipoHabitacion();
                Console.WriteLine("Nuevo Tipo de Habitacion");
                Console.Write("Ingrese descripcion: ");
                tpHbt.Descripcion = Console.ReadLine();
                Console.Write("Ingrese numero de camas: ");
                tpHbt.NumeroCamas = int.Parse(Console.ReadLine());
                prcTpHbt = new PrecioTipoHabitacion();
                prcTpHbt.IdTipoHabitacion = tpHbt.IdTipoHabitacion;
                prcTpHbt.IdTipoHabitacionNavigation = tpHbt;
                prcTpHbt.FechaPrecio = DateTime.Now;
                Console.Write("Ingrese precio: ");
                prcTpHbt.PrecioHabitacion = float.Parse(Console.ReadLine());
                tpHbt.PrecioTipoHabitacions.Add(prcTpHbt);
                Negocio.TipoHabitacion.Create(tpHbt);

                Console.Clear();
                Console.WriteLine("--- Tipo de Habitacion cargado ---");
                Console.WriteLine("ID: " + tpHbt.IdTipoHabitacion);
                Console.WriteLine("Descripcion: " + tpHbt.Descripcion);
                Console.WriteLine("nroCamas: " + tpHbt.NumeroCamas);
                Console.WriteLine("Precio: " + tpHbt.PrecioTipoHabitacions.Last().PrecioHabitacion.ToString());
                Console.WriteLine("  - Actualizacion de precio: " + tpHbt.PrecioTipoHabitacions.Last().FechaPrecio.ToString());
                Console.WriteLine("-------------------------------------------");
                Console.Write("\nPresione una tecla para volver al menu...");
                Console.ReadKey();
                break;

            case ConsoleKey.D3:
                Console.Clear();
                Console.WriteLine("Tipos de Habitaciones registradas:");
                lstTpHbt = Negocio.TipoHabitacion.getAll();
                if (lstTpHbt.Count == 0)
                {
                    Console.WriteLine("-NO SE HAN ENCONTRADO TIPOS DE HABITACIONES REGISTRADOS-");
                }
                else
                {
                    foreach (TipoHabitacion tmpTpHbt in lstTpHbt)
                    {
                        Console.WriteLine("ID: " + tmpTpHbt.IdTipoHabitacion.ToString() + " - Descripcion: " + tmpTpHbt.Descripcion + " NroCamas: " + tmpTpHbt.NumeroCamas.ToString());
                    }
                    Console.Write("Ingrese ID del tipo de habitacion: ");
                    idTpHbt = Console.ReadLine();
                    tpHbt = lstTpHbt.Find(delegate (TipoHabitacion tpHbt) { return tpHbt.IdTipoHabitacion == int.Parse(idTpHbt); });
                    Console.Clear();

                    if (tpHbt != null)
                    {
                        Console.WriteLine("ID: " + tpHbt.IdTipoHabitacion);
                        Console.Write("Descripcion: " + tpHbt.Descripcion + " -> ");
                        tpHbt.Descripcion = Console.ReadLine();
                        Console.Write("\nNroCamas: " + tpHbt.NumeroCamas + " -> ");
                        tpHbt.NumeroCamas = int.Parse(Console.ReadLine());
                        Negocio.TipoHabitacion.Update(tpHbt);

                        Console.Clear();
                        Console.WriteLine("--- Tipo de Habitacion editado ---");
                        Console.WriteLine("ID: " + tpHbt.IdTipoHabitacion);
                        Console.WriteLine("Descripcion: " + tpHbt.Descripcion);
                        Console.WriteLine("NroCamas: " + tpHbt.NumeroCamas);
                        Console.WriteLine("-------------------------------------------");
                    }
                }
                Console.Write("\nPresione una tecla para volver al menu...");
                Console.ReadKey();
                break;

            case ConsoleKey.D4:
                Console.Clear();
                Console.WriteLine("Tipos de Habitaciones registradas:");
                lstTpHbt = Negocio.TipoHabitacion.getAll();
                if (lstTpHbt.Count == 0)
                {
                    Console.WriteLine("-NO SE HAN ENCONTRADO TIPOS DE HABITACIONES REGISTRADOS-");
                }
                else
                {
                    foreach (TipoHabitacion tmpTpHbt in lstTpHbt)
                    {
                        Console.WriteLine("ID: " + tmpTpHbt.IdTipoHabitacion.ToString() + " - Descripcion: " + tmpTpHbt.Descripcion + " NroCamas: " + tmpTpHbt.NumeroCamas.ToString());
                    }
                    Console.Write("Ingrese ID del tipo de habitacion: ");
                    idTpHbt = Console.ReadLine();
                    tpHbt = lstTpHbt.Find(delegate (TipoHabitacion tpHbt) { return tpHbt.IdTipoHabitacion == int.Parse(idTpHbt); });
                    Console.Clear();

                    if (tpHbt != null)
                    {
                        prcTpHbt = new PrecioTipoHabitacion();
                        prcTpHbt.IdTipoHabitacion = tpHbt.IdTipoHabitacion;
                        prcTpHbt.IdTipoHabitacionNavigation = tpHbt;
                        prcTpHbt.FechaPrecio = DateTime.Now;
                        Console.WriteLine("ID: " + tpHbt.IdTipoHabitacion);
                        Console.WriteLine("Descripcion: " + tpHbt.Descripcion);
                        Console.WriteLine("nroCamas: " + tpHbt.NumeroCamas);
                        Console.Write("Precio: " + tpHbt.PrecioTipoHabitacions.Last().PrecioHabitacion.ToString() + " -> ");
                        prcTpHbt.PrecioHabitacion = float.Parse(Console.ReadLine());
                        tpHbt.PrecioTipoHabitacions.Add(prcTpHbt);
                        Negocio.TipoHabitacion.Update(tpHbt);

                        Console.Clear();
                        Console.WriteLine("--- Precio del Tipo de Habitacion actualizado ---");
                        Console.WriteLine("ID: " + tpHbt.IdTipoHabitacion);
                        Console.WriteLine("Descripcion: " + tpHbt.Descripcion);
                        Console.WriteLine("nroCamas: " + tpHbt.NumeroCamas);
                        Console.WriteLine("Precio: " + tpHbt.PrecioTipoHabitacions.Last().PrecioHabitacion.ToString());
                        Console.WriteLine("  - Actualizacion de precio: " + tpHbt.PrecioTipoHabitacions.Last().FechaPrecio.ToString());
                        Console.WriteLine("-------------------------------------------");
                    }
                }
                Console.Write("\nPresione una tecla para volver al menu...");
                Console.ReadKey();
                break;

            //Para esta entrega se utilizara un DELETE en cascada para las relaciones de TipoHabitacion con Habitacion y PrecioTipoHabitacion
            case ConsoleKey.D5:
                Console.Clear();
                Console.WriteLine("Tipos de Habitaciones registradas:");
                lstTpHbt = Negocio.TipoHabitacion.getAll();
                if (lstTpHbt.Count == 0)
                {
                    Console.WriteLine("-NO SE HAN ENCONTRADO TIPOS DE HABITACIONES REGISTRADOS-");
                }
                else
                {
                    foreach (TipoHabitacion tmpTpHbt in lstTpHbt)
                    {
                        Console.WriteLine("ID: " + tmpTpHbt.IdTipoHabitacion.ToString() + " - Descripcion: " + tmpTpHbt.Descripcion + " NroCamas: " + tmpTpHbt.NumeroCamas.ToString());
                    }
                    Console.Write("Ingrese ID del tipo de habitacion: ");
                    idTpHbt = Console.ReadLine();

                    Console.Clear();
                    if (Negocio.TipoHabitacion.Delete(lstTpHbt.Find(delegate (TipoHabitacion tpHbt) { return tpHbt.IdTipoHabitacion == int.Parse(idTpHbt); })))
                    {
                        Console.WriteLine("Tipo de Habitacion ID: " + idTpHbt.ToString() + " eliminado");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                Console.Write("\nPresione una tecla para volver al menu...");
                Console.ReadKey();
                break;
        }

    } while (opc.Key != ConsoleKey.D0);
}
#endregion
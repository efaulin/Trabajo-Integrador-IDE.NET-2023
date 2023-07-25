﻿// See https://aka.ms/new-console-template for more information

using Entidad.Models;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

Datos.DBContext dBContext = new Datos.DBContext();

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
    Console.WriteLine("2. CRUD Huespedes");
    //Console.WriteLine("X. CRUD Tipos de habitaciones");
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
        case ConsoleKey.D3: break;
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
                lstHabitaciones = Negocio.Habitacion.getAll(dBContext);
                foreach (Habitacion tmpHbt in lstHabitaciones)
                {
                    Console.WriteLine("ID: " + tmpHbt.IdHabitacion);
                    Console.WriteLine("estado: " + tmpHbt.Estado.ToString());
                    Console.WriteLine("nroHabitacion: " + tmpHbt.NumeroHabitacion);
                    Console.WriteLine("pisoHabitacion: " + tmpHbt.PisoHabitacion);
                    Console.WriteLine("tipoHabitacion: " + tmpHbt.IdTipoHabitacionNavigation.Descripcion);
                    Console.WriteLine("Precio: " + tmpHbt.IdTipoHabitacionNavigation.PrecioTipoHabitacions.Last().PrecioHabitacion.ToString());
                    Console.WriteLine("  - Actualizacion de precio: " + tmpHbt.IdTipoHabitacionNavigation.PrecioTipoHabitacions.Last().FechaPrecio.ToString());
                    Console.WriteLine("-------------------------------------------");
                }
                Console.Write("Presione una tecla para volver al menu...");
                Console.ReadKey();
                break;

            case ConsoleKey.D2: 
                Console.Clear();
                Console.WriteLine("Tipos de habitaciones disponibles:");
                lstTipoHabitaciones = Negocio.TipoHabitacion.getAll(dBContext);
                foreach (TipoHabitacion tpHbt in lstTipoHabitaciones)
                {
                    Console.WriteLine("ID: " + tpHbt.IdTipoHabitacion.ToString() + " - " + tpHbt.Descripcion);
                }
                Console.Write("Ingrese ID del tipo de habitacion: ");
                string? idTipHbt = Console.ReadLine();

                Console.Clear();
                tipHbt = Negocio.TipoHabitacion.getOne(int.Parse(idTipHbt), dBContext);
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
                Negocio.Habitacion.Create(hbt, dBContext);

                Console.Clear();
                Console.WriteLine("--- Habitacion cargada ---");
                Console.WriteLine("ID: " + hbt.IdHabitacion);
                Console.WriteLine("estado: " + hbt.Estado);
                Console.WriteLine("nroHabitacion: " + hbt.NumeroHabitacion);
                Console.WriteLine("pisoHabitacion: " + hbt.PisoHabitacion);
                Console.WriteLine("tipoHabitacion: " + hbt.IdTipoHabitacionNavigation.Descripcion);
                Console.WriteLine("Precio: " + hbt.IdTipoHabitacionNavigation.PrecioTipoHabitacions.Last().PrecioHabitacion.ToString());
                Console.WriteLine("  - Actualizacion de precio: " + hbt.IdTipoHabitacionNavigation.PrecioTipoHabitacions.Last().FechaPrecio.ToString());
                Console.WriteLine("-------------------------------------------");
                Console.Write("Presione una tecla para volver al menu...");
                Console.ReadKey();
                break;

            case ConsoleKey.D3:
                Console.Clear();
                Console.WriteLine("Habitaciones registradas:");
                lstHabitaciones = Negocio.Habitacion.getAll(dBContext);
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
                    lstTipoHabitaciones = Negocio.TipoHabitacion.getAll(dBContext);
                    foreach (TipoHabitacion tpHbt in lstTipoHabitaciones)
                    {
                        Console.WriteLine("ID: " + tpHbt.IdTipoHabitacion.ToString() + " - " + tpHbt.Descripcion);
                    }
                    Console.Write("Ingrese ID del tipo de habitacion: ");
                    hbt.IdTipoHabitacion = int.Parse(Console.ReadLine());
                    hbt.IdTipoHabitacionNavigation = Negocio.TipoHabitacion.getOne(hbt.IdTipoHabitacion, dBContext);
                    Negocio.Habitacion.Update(hbt, dBContext);

                    Console.Clear();
                    Console.WriteLine("--- Habitacion editada ---");
                    Console.WriteLine("ID: " + hbt.IdHabitacion);
                    Console.WriteLine("estado: " + hbt.Estado);
                    Console.WriteLine("nroHabitacion: " + hbt.NumeroHabitacion);
                    Console.WriteLine("pisoHabitacion: " + hbt.PisoHabitacion);
                    Console.WriteLine("tipoHabitacion: " + hbt.IdTipoHabitacionNavigation.Descripcion);
                    Console.WriteLine("Precio: " + hbt.IdTipoHabitacionNavigation.PrecioTipoHabitacions.Last().PrecioHabitacion.ToString());
                    Console.WriteLine("  - Actualizacion de precio: " + hbt.IdTipoHabitacionNavigation.PrecioTipoHabitacions.Last().FechaPrecio.ToString());
                    Console.WriteLine("-------------------------------------------");
                    Console.Write("Presione una tecla para volver al menu...");
                    Console.ReadKey();
                }

                break;

            case ConsoleKey.D4:
                Console.Clear();
                Console.WriteLine("Habitaciones registradas:");
                lstHabitaciones = Negocio.Habitacion.getAll(dBContext);
                foreach (Habitacion tmpHbt in lstHabitaciones)
                {
                    Console.WriteLine("ID: " + tmpHbt.IdHabitacion.ToString() + " - Piso: " + tmpHbt.PisoHabitacion.ToString() + " Nro: " + tmpHbt.NumeroHabitacion.ToString());
                }
                Console.Write("Ingrese ID de habitacion: ");
                idHbt = Console.ReadLine();

                Console.Clear();
                if (Negocio.Habitacion.Delete(lstHabitaciones.Find(delegate (Habitacion hbt) { return hbt.IdHabitacion == int.Parse(idHbt); }), dBContext))
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
        }

    } while (opc.Key != ConsoleKey.D0);
}
#endregion
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Entidad.Models;

namespace Datos;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Habitacion> Habitacions { get; set; }

    public virtual DbSet<Huesped> Huespeds { get; set; }

    public virtual DbSet<PrecioServicio> PrecioServicios { get; set; }

    public virtual DbSet<PrecioTipoHabitacion> PrecioTipoHabitacions { get; set; }

    public virtual DbSet<Reserva> Reservas { get; set; }

    public virtual DbSet<ReservaServicio> ReservaServicios { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<TipoHabitacion> TipoHabitacions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
        optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=TPI2023TM03; user id=net; password=net; Encrypt=false;");
    }
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("PK__Empleado__5295297C43BAC60B");

            entity.ToTable("Empleado");

            entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreUsuario");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.TipoUsuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipoUsuario");
        });

        modelBuilder.Entity<Habitacion>(entity =>
        {
            entity.HasKey(e => e.IdHabitacion).HasName("PK__Habitaci__D9D53BE2C305B6A9");

            entity.ToTable("Habitacion");

            entity.Property(e => e.IdHabitacion).HasColumnName("idHabitacion");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.IdTipoHabitacion).HasColumnName("idTipoHabitacion");
            entity.Property(e => e.NumeroHabitacion).HasColumnName("numeroHabitacion");
            entity.Property(e => e.PisoHabitacion).HasColumnName("pisoHabitacion");

            entity.HasOne(d => d.IdTipoHabitacionNavigation).WithMany(p => p.Habitacions)
                .HasForeignKey(d => d.IdTipoHabitacion)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Habitacio__idTip__2C3393D0");
        });

        modelBuilder.Entity<Huesped>(entity =>
        {
            entity.HasKey(e => e.IdHuesped).HasName("PK__Huesped__4B73CF97FA535F02");

            entity.ToTable("Huesped");

            entity.Property(e => e.IdHuesped).HasColumnName("idHuesped");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numeroDocumento");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tipoDocumento");
        });

        modelBuilder.Entity<PrecioServicio>(entity =>
        {
            entity.HasKey(e => e.IdPrecioServicio).HasName("PK__PrecioSe__1C83616231C925C0");

            entity.ToTable("PrecioServicio");

            entity.Property(e => e.IdPrecioServicio).HasColumnName("idPrecioServicio");
            entity.Property(e => e.FechaPrecio)
                .HasColumnType("date")
                .HasColumnName("fechaPrecio");
            entity.Property(e => e.IdServicio).HasColumnName("idServicio");
            entity.Property(e => e.PrecioServicio1).HasColumnName("precioServicio");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.PrecioServicios)
                .HasForeignKey(d => d.IdServicio)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__PrecioSer__idSer__2F10007B");
        });

        modelBuilder.Entity<PrecioTipoHabitacion>(entity =>
        {
            entity.HasKey(e => e.IdPrecioTipoHabitacion).HasName("PK__PrecioTi__6BCE3FC9630C3AC5");

            entity.ToTable("PrecioTipoHabitacion");

            entity.Property(e => e.IdPrecioTipoHabitacion).HasColumnName("idPrecioTipoHabitacion");
            entity.Property(e => e.FechaPrecio)
                .HasColumnType("date")
                .HasColumnName("fechaPrecio");
            entity.Property(e => e.IdTipoHabitacion).HasColumnName("idTipoHabitacion");
            entity.Property(e => e.PrecioHabitacion).HasColumnName("precioHabitacion");

            entity.HasOne(d => d.IdTipoHabitacionNavigation).WithMany(p => p.PrecioTipoHabitacions)
                .HasForeignKey(d => d.IdTipoHabitacion)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__PrecioTip__idTip__31EC6D26");
        });

        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.IdReserva).HasName("PK__Reserva__94D104C823428A21");

            entity.ToTable("Reserva");

            entity.Property(e => e.IdReserva).HasColumnName("idReserva");
            entity.Property(e => e.CantidadPersonas).HasColumnName("cantidadPersonas");
            entity.Property(e => e.EstadoReserva)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("estadoReserva");
            entity.Property(e => e.FechaFinReserva)
                .HasColumnType("date")
                .HasColumnName("fechaFinReserva");
            entity.Property(e => e.FechaInicioReserva)
                .HasColumnType("date")
                .HasColumnName("fechaInicioReserva");
            entity.Property(e => e.FechaInscripcion)
                .HasColumnType("date")
                .HasColumnName("fechaInscripcion");
            entity.Property(e => e.IdHabitacion).HasColumnName("idHabitacion");
            entity.Property(e => e.IdHuesped).HasColumnName("idHuesped");

            entity.HasOne(d => d.IdHabitacionNavigation).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.IdHabitacion)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Reserva__idHabit__35BCFE0A");

            entity.HasOne(d => d.IdHuespedNavigation).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.IdHuesped)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Reserva__idHuesp__34C8D9D1");
        });

        modelBuilder.Entity<ReservaServicio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Reserva_Servicio");

            entity.Property(e => e.IdReserva).HasColumnName("idReserva");
            entity.Property(e => e.IdServicio).HasColumnName("idServicio");

            entity.HasOne(d => d.IdReservaNavigation).WithMany()
                .HasForeignKey(d => d.IdReserva)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Reserva_S__idRes__37A5467C");

            entity.HasOne(d => d.IdServicioNavigation).WithMany()
                .HasForeignKey(d => d.IdServicio)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Reserva_S__idSer__38996AB5");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.IdServicio).HasName("PK__Servicio__CEB98119BC81600E");

            entity.ToTable("Servicio");

            entity.Property(e => e.IdServicio).HasColumnName("idServicio");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TipoHabitacion>(entity =>
        {
            entity.HasKey(e => e.IdTipoHabitacion).HasName("PK__TipoHabi__64CD3F697225179A");

            entity.ToTable("TipoHabitacion");

            entity.Property(e => e.IdTipoHabitacion).HasColumnName("idTipoHabitacion");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.NumeroCamas).HasColumnName("numeroCamas");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

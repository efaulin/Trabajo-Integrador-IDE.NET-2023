using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Entidad.Models;

namespace Datos;

public partial class DBContext : DbContext
{
    public static DBContext db = new DBContext();
    public static DBContext dBContext { get { return db; } }
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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=TPI2023TM03; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("PK__Empleado__5295297C43BAC60B");

            entity.ToTable("Empleado");

            entity.HasIndex(e => e.NombreUsuario, "IX_Empleado").IsUnique();

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

            entity.HasIndex(e => new { e.PisoHabitacion, e.NumeroHabitacion }, "IX_Habitacion").IsUnique();

            entity.Property(e => e.IdHabitacion).HasColumnName("idHabitacion");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.IdTipoHabitacion).HasColumnName("idTipoHabitacion");
            entity.Property(e => e.NumeroHabitacion).HasColumnName("numeroHabitacion");
            entity.Property(e => e.PisoHabitacion).HasColumnName("pisoHabitacion");

            entity.HasOne(d => d.IdTipoHabitacionNavigation).WithMany(p => p.Habitacions)
                .HasForeignKey(d => d.IdTipoHabitacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Habitacio__idTip__2C3393D0");
        });

        modelBuilder.Entity<Huesped>(entity =>
        {
            entity.HasKey(e => e.IdHuesped).HasName("PK__Huesped__4B73CF97FA535F02");

            entity.ToTable("Huesped");

            entity.HasIndex(e => new { e.NumeroDocumento, e.TipoDocumento }, "IX_Huesped").IsUnique();

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
            entity.HasKey(e => e.IdPrecioServicio).HasName("PK__PrecioSe__1C8361628FCCEFC7");

            entity.ToTable("PrecioServicio");

            entity.Property(e => e.IdPrecioServicio).HasColumnName("idPrecioServicio");
            entity.Property(e => e.FechaPrecio)
                .HasColumnType("datetime")
                .HasColumnName("fechaPrecio");
            entity.Property(e => e.IdServicio).HasColumnName("idServicio");
            entity.Property(e => e.PrecioServicio1).HasColumnName("precioServicio");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.PrecioServicios)
                .HasForeignKey(d => d.IdServicio)
                .HasConstraintName("FK__PrecioSer__idSer__02FC7413");
        });

        modelBuilder.Entity<PrecioTipoHabitacion>(entity =>
        {
            entity.HasKey(e => new { e.IdPrecioTipoHabitacion, e.IdTipoHabitacion }).HasName("PK__PrecioTi__6BCE3FC9630C3AC5");

            entity.ToTable("PrecioTipoHabitacion");

            entity.Property(e => e.IdPrecioTipoHabitacion)
                .ValueGeneratedOnAdd()
                .HasColumnName("idPrecioTipoHabitacion");
            entity.Property(e => e.IdTipoHabitacion).HasColumnName("idTipoHabitacion");
            entity.Property(e => e.FechaPrecio)
                .HasColumnType("datetime")
                .HasColumnName("fechaPrecio");
            entity.Property(e => e.PrecioHabitacion).HasColumnName("precioHabitacion");

            entity.HasOne(d => d.IdTipoHabitacionNavigation).WithMany(p => p.PrecioTipoHabitacions)
                .HasForeignKey(d => d.IdTipoHabitacion)
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
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reserva__idHabit__35BCFE0A");

            entity.HasOne(d => d.IdHuespedNavigation).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.IdHuesped)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reserva__idHuesp__151B244E");
        });

        modelBuilder.Entity<ReservaServicio>(entity =>
        {
            entity.HasKey(e => e.IdReservaServicio);

            entity.ToTable("Reserva_Servicio");

            entity.HasIndex(e => new { e.IdReserva, e.IdServicio }, "IX_Reserva_Servicio").IsUnique();

            entity.Property(e => e.IdReservaServicio).HasColumnName("idReservaServicio");
            entity.Property(e => e.IdReserva).HasColumnName("idReserva");
            entity.Property(e => e.IdServicio).HasColumnName("idServicio");

            entity.HasOne(d => d.IdReservaNavigation).WithMany(p => p.ReservaServicios)
                .HasForeignKey(d => d.IdReserva)
                .HasConstraintName("FK_Reserva_Servicio_Reserva");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.ReservaServicios)
                .HasForeignKey(d => d.IdServicio)
                .HasConstraintName("FK_Reserva_Servicio_Servicio");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.IdServicio).HasName("PK__Servicio__CEB98119BC81600E");

            entity.ToTable("Servicio");

            entity.HasIndex(e => e.Descripcion, "IX_Servicio").IsUnique();

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

            entity.HasIndex(e => e.Descripcion, "IX_TipoHabitacion").IsUnique();

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

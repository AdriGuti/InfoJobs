using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace InfoJobs.DataLayer
{
    public partial class infojobsContext : DbContext
    {
        public infojobsContext()
        {
        }

        public infojobsContext(DbContextOptions<infojobsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Candidatos> Candidatos { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Ofertas> Ofertas { get; set; }
        public virtual DbSet<Oficio> Oficio { get; set; }
        public virtual DbSet<Relacioncandidatosofertas> Relacioncandidatosofertas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;database=infojobs;uid=root", x => x.ServerVersion("10.4.22-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidatos>(entity =>
            {
                entity.HasKey(e => e.Dni)
                    .HasName("PRIMARY");

                entity.ToTable("candidatos");

                entity.HasIndex(e => e.IdOficio)
                    .HasName("ID Oficio_2");

                entity.Property(e => e.Dni)
                    .HasColumnName("DNI")
                    .HasColumnType("varchar(9)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("Fecha Nacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.IdOficio)
                    .HasColumnName("ID Oficio")
                    .HasColumnType("int(3)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdOficioNavigation)
                    .WithMany(p => p.Candidatos)
                    .HasForeignKey(d => d.IdOficio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CandidatoOficio");
            });

            modelBuilder.Entity<Empresas>(entity =>
            {
                entity.HasKey(e => e.Nif)
                    .HasName("PRIMARY");

                entity.ToTable("empresas");

                entity.Property(e => e.Nif)
                    .HasColumnName("NIF")
                    .HasColumnType("varchar(9)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(500)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Sector)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Ofertas>(entity =>
            {
                entity.HasKey(e => e.IdOferta)
                    .HasName("PRIMARY");

                entity.ToTable("ofertas");

                entity.HasIndex(e => e.IdOficio)
                    .HasName("ID Oficio");

                entity.HasIndex(e => e.NifEmpresa)
                    .HasName("NIF Empresa");

                entity.Property(e => e.IdOferta)
                    .HasColumnName("ID Oferta")
                    .HasColumnType("int(3)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(500)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdOficio)
                    .HasColumnName("ID Oficio")
                    .HasColumnType("int(3)");

                entity.Property(e => e.NifEmpresa)
                    .IsRequired()
                    .HasColumnName("NIF Empresa")
                    .HasColumnType("varchar(9)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdOficioNavigation)
                    .WithMany(p => p.Ofertas)
                    .HasForeignKey(d => d.IdOficio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OfertaOficio");

                entity.HasOne(d => d.NifEmpresaNavigation)
                    .WithMany(p => p.Ofertas)
                    .HasForeignKey(d => d.NifEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OfertaEmpresa");
            });

            modelBuilder.Entity<Oficio>(entity =>
            {
                entity.HasKey(e => e.IdOficio)
                    .HasName("PRIMARY");

                entity.ToTable("oficio");

                entity.Property(e => e.IdOficio)
                    .HasColumnName("ID Oficio")
                    .HasColumnType("int(3)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(500)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Relacioncandidatosofertas>(entity =>
            {
                entity.HasKey(e => new { e.DniCandidato, e.IdOferta })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("relacioncandidatosofertas");

                entity.HasIndex(e => e.DniCandidato)
                    .HasName("DNI Candidato");

                entity.HasIndex(e => e.IdOferta)
                    .HasName("ID Oferta");

                entity.Property(e => e.DniCandidato)
                    .HasColumnName("DNI Candidato")
                    .HasColumnType("varchar(9)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdOferta)
                    .HasColumnName("ID Oferta")
                    .HasColumnType("int(3)");

                entity.HasOne(d => d.DniCandidatoNavigation)
                    .WithMany(p => p.Relacioncandidatosofertas)
                    .HasForeignKey(d => d.DniCandidato)
                    .HasConstraintName("relacioncandidatosofertas_ibfk_1");

                entity.HasOne(d => d.IdOfertaNavigation)
                    .WithMany(p => p.Relacioncandidatosofertas)
                    .HasForeignKey(d => d.IdOferta)
                    .HasConstraintName("relacioncandidatosofertas_ibfk_2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

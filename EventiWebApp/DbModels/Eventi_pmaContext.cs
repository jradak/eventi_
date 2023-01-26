using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EventiWebApp.DbModels
{
    public partial class Eventi_pmaContext : DbContext
    {
        public Eventi_pmaContext()
        {
        }

        public Eventi_pmaContext(DbContextOptions<Eventi_pmaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Eventi> Eventis { get; set; }
        public virtual DbSet<Korisnici> Korisnicis { get; set; }
        public virtual DbSet<KorisnikEvent> KorisnikEvents { get; set; }
        public virtual DbSet<Mjestum> Mjesta { get; set; }
        public virtual DbSet<VrsteEventum> VrsteEventa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Eventi_pma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Eventi>(entity =>
            {
                entity.HasKey(e => e.IdEvent)
                    .HasName("PK__Eventi__12A4DF3F914339B0");

                entity.ToTable("Eventi");

                entity.Property(e => e.IdEvent).HasColumnName("ID_Event");

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.Cijena).HasMaxLength(50);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Vrijeme).HasColumnType("datetime");

                entity.HasOne(d => d.MjestoNavigation)
                    .WithMany(p => p.Eventis)
                    .HasForeignKey(d => d.Mjesto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Eventi__Mjesto__2B3F6F97");

                entity.HasOne(d => d.OrganizatorNavigation)
                    .WithMany(p => p.Eventis)
                    .HasForeignKey(d => d.Organizator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Eventi__Organiza__29572725");

                entity.HasOne(d => d.VrstaEventaNavigation)
                    .WithMany(p => p.Eventis)
                    .HasForeignKey(d => d.VrstaEventa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Eventi__VrstaEve__2A4B4B5E");
            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.HasKey(e => e.IdKorisnik)
                    .HasName("PK__Korisnic__F09AFA7B0107169E");

                entity.ToTable("Korisnici");

                entity.Property(e => e.IdKorisnik).HasColumnName("ID_Korisnik");

                entity.Property(e => e.Admin).HasColumnName("Admin_");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Lozinka)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<KorisnikEvent>(entity =>
            {
                entity.HasKey(e => e.IdKorisnikEvent)
                    .HasName("PK__Korisnik__589D98BA54C8B104");

                entity.ToTable("KorisnikEvent");

                entity.Property(e => e.IdKorisnikEvent).HasColumnName("ID_KorisnikEvent");

                entity.Property(e => e.Event).HasColumnName("Event_");

                entity.HasOne(d => d.EventNavigation)
                    .WithMany(p => p.KorisnikEvents)
                    .HasForeignKey(d => d.Event)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KorisnikE__Event__2E1BDC42");

                entity.HasOne(d => d.KorisnikNavigation)
                    .WithMany(p => p.KorisnikEvents)
                    .HasForeignKey(d => d.Korisnik)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KorisnikE__Koris__2F10007B");
            });

            modelBuilder.Entity<Mjestum>(entity =>
            {
                entity.HasKey(e => e.IdMjesto)
                    .HasName("PK__Mjesta__5FBE2FA9BE35CB44");

                entity.Property(e => e.IdMjesto).HasColumnName("ID_Mjesto");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VrsteEventum>(entity =>
            {
                entity.HasKey(e => e.IdVrsta)
                    .HasName("PK__VrsteEve__29C551A51054E104");

                entity.Property(e => e.IdVrsta).HasColumnName("ID_Vrsta");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

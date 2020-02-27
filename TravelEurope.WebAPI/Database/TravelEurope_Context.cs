using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TravelEurope.WebAPI.Database
{
    public partial class TravelEurope_Context : DbContext
    {
 
        public TravelEurope_Context(DbContextOptions<TravelEurope_Context> options)
            : base(options)
        {
        }
        public TravelEurope_Context()
        {
        }

        public virtual DbSet<Administrator> Administrator { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<Drzava> Drzava { get; set; }
        public virtual DbSet<Grad> Grad { get; set; }
        public virtual DbSet<Klijent> Klijent { get; set; }
        public virtual DbSet<Lokacija> Lokacija { get; set; }
        public virtual DbSet<MarkaVozila> MarkaVozila { get; set; }
        public virtual DbSet<NacinPlacanja> NacinPlacanja { get; set; }
        public virtual DbSet<Racun> Racun { get; set; }
        public virtual DbSet<Radnik> Radnik { get; set; }
        public virtual DbSet<Rezervacija> Rezervacija { get; set; }
        public virtual DbSet<StatusVozaca> StatusVozaca { get; set; }
        public virtual DbSet<StatusVozila> StatusVozila { get; set; }
        public virtual DbSet<TipVozila> TipVozila { get; set; }
        public virtual DbSet<TuristickiVodic> TuristickiVodic { get; set; }
        public virtual DbSet<TuristRuta> TuristRuta { get; set; }
        public virtual DbSet<Vozac> Vozac { get; set; }
        public virtual DbSet<Vozilo> Vozilo { get; set; }
        public virtual DbSet<VrstaGoriva> VrstaGoriva { get; set; }
        public virtual DbSet<StraniJezik> StraniJezik { get; set; }
        public virtual DbSet<RuteSlike> RuteSlike { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>(entity =>
            {
                entity.Property(e => e.AdministratorId).ValueGeneratedNever();

                entity.HasOne(d => d.AdministratorNavigation)
                    .WithOne(p => p.Administrator)
                    .HasForeignKey<Administrator>(d => d.AdministratorId);
            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.HasIndex(e => e.GradId);

                entity.Property(e => e.DatumRodjenja).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.Jmbg).HasColumnName("JMBG");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.GradId);
            });


            modelBuilder.Entity<Grad>(entity =>
            {
                entity.HasIndex(e => e.DrzavaId);

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Grad)
                    .HasForeignKey(d => d.DrzavaId);
            });

            modelBuilder.Entity<Klijent>(entity =>
            {
                entity.Property(e => e.KlijentId).ValueGeneratedNever();

                entity.HasOne(d => d.KlijentNavigation)
                    .WithOne(p => p.Klijent)
                    .HasForeignKey<Klijent>(d => d.KlijentId);
            });

            modelBuilder.Entity<Lokacija>(entity =>
            {
                entity.HasIndex(e => e.DrzavaId);

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Lokacija)
                    .HasForeignKey(d => d.DrzavaId);
            });

            modelBuilder.Entity<MarkaVozila>(entity =>
            {
                entity.HasKey(e => e.MarkaId);
            });

            modelBuilder.Entity<Racun>(entity =>
            {
                entity.HasIndex(e => e.NacinPlacanjaId);

                entity.HasIndex(e => e.RezervacijaId);

                entity.Property(e => e.CijenaUslugeSaPdvom).HasColumnName("CijenaUslugeSaPDVom");

                entity.HasOne(d => d.NacinPlacanja)
                    .WithMany(p => p.Racun)
                    .HasForeignKey(d => d.NacinPlacanjaId);

                entity.HasOne(d => d.Rezervacija)
                    .WithMany(p => p.Racun)
                    .HasForeignKey(d => d.RezervacijaId);
            });

            modelBuilder.Entity<Radnik>(entity =>
            {
                entity.Property(e => e.RadnikId).ValueGeneratedNever();

                entity.HasOne(d => d.RadnikNavigation)
                    .WithOne(p => p.Radnik)
                    .HasForeignKey<Radnik>(d => d.RadnikId);
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.HasIndex(e => e.KlijentId);

                entity.HasIndex(e => e.RacunId);

                entity.HasIndex(e => e.RadnikId);

                entity.HasIndex(e => e.TuristRutaId);

                entity.HasIndex(e => e.VozacId);

                entity.HasIndex(e => e.VoziloId);

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Rezervacija)
                    .HasForeignKey(d => d.KlijentId);

                entity.HasOne(d => d.RacunNavigation)
                    .WithMany(p => p.RezervacijaNavigation)
                    .HasForeignKey(d => d.RacunId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Radnik)
                    .WithMany(p => p.Rezervacija)
                    .HasForeignKey(d => d.RadnikId);

                entity.HasOne(d => d.TuristRuta)
                    .WithMany(p => p.Rezervacija)
                    .HasForeignKey(d => d.TuristRutaId);

                entity.HasOne(d => d.Vozac)
                    .WithMany(p => p.Rezervacija)
                    .HasForeignKey(d => d.VozacId);

                entity.HasOne(d => d.Vozilo)
                    .WithMany(p => p.Rezervacija)
                    .HasForeignKey(d => d.VoziloId);
            });

            modelBuilder.Entity<TipVozila>(entity =>
            {
                entity.HasKey(e => e.TipId);
            });

            modelBuilder.Entity<TuristRuta>(entity =>
            {
                entity.HasIndex(e => e.DrzavaId);

                entity.HasIndex(e => e.TuristickiVodicId);

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.TuristRuta)
                    .HasForeignKey(d => d.DrzavaId);

            });

            modelBuilder.Entity<Vozac>(entity =>
            {
                entity.HasIndex(e => e.StatusVozacaId);

                entity.HasOne(d => d.StatusVozaca)
                    .WithMany(p => p.Vozac)
                    .HasForeignKey(d => d.StatusVozacaId);
            });

            modelBuilder.Entity<Vozilo>(entity =>
            {
                entity.HasIndex(e => e.MarkaVozilaId);

                entity.HasIndex(e => e.StatusVozilaId);

                entity.HasIndex(e => e.TipVozilaId);

                entity.HasIndex(e => e.VrstaGorivaId);

                entity.HasOne(d => d.MarkaVozila)
                    .WithMany(p => p.Vozilo)
                    .HasForeignKey(d => d.MarkaVozilaId);

                entity.HasOne(d => d.StatusVozila)
                    .WithMany(p => p.Vozilo)
                    .HasForeignKey(d => d.StatusVozilaId);

                entity.HasOne(d => d.TipVozila)
                    .WithMany(p => p.Vozilo)
                    .HasForeignKey(d => d.TipVozilaId);

                entity.HasOne(d => d.VrstaGoriva)
                    .WithMany(p => p.Vozilo)
                    .HasForeignKey(d => d.VrstaGorivaId);
            });

            modelBuilder.Entity<VrstaGoriva>(entity =>
            {
                entity.HasKey(e => e.GorivoId);
            });
        }
    }
}
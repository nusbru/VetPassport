using Microsoft.EntityFrameworkCore;
using VetPassport.API.Models;

namespace VetPassport.API.Data
{
    public class VetPassportContext : DbContext
    {
        public VetPassportContext(DbContextOptions<VetPassportContext> options)
            : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
        public DbSet<VaccinationHistory> VaccinationHistories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.HasOne(e => e.User)
                      .WithMany(o => o.Pets)
                      .HasForeignKey(e => e.UserId);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Password).IsRequired().HasMaxLength(15);
                entity.HasMany(e => e.Pets)
                    .WithOne(o => o.User)
                    .HasForeignKey(e => e.UserId);

            });

            modelBuilder.Entity<Vaccine>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Date).IsRequired().ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VaccinationHistory>(entity =>
               {
                   entity.HasKey(e => e.Id);
                   entity.Property(e => e.PetId).IsRequired();
                   entity.Property(e => e.VaccineId).IsRequired();
                   entity.HasOne(e => e.Pet)
                         .WithMany(p => p.VaccinationHistory)
                         .HasForeignKey(e => e.PetId);
                   entity.HasMany(e => e.Vaccines)
                         .WithOne()
                         .HasForeignKey(v => v.Id);
               });
        }
    }
}
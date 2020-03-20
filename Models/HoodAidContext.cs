using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoodAid.Models
{
    public class HoodAidContext : DbContext
    {
        public HoodAidContext(DbContextOptions<HoodAidContext> options)
           : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)       
            => options.UseSqlite("Data Source=Data\\hoodaid.db");
        

        public DbSet<User> Users { get; set; }
        public DbSet<ContactPerson> ContactPersons { get; set; }
        public DbSet<DiaryEntry> DiaryEntries { get; set; }
        public DbSet<HealthAuthority> HealthAuthorities { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
            new User() { Id = 1, Nachname="Lelaire",Ort="Kaltenkirchen",Plz="24568" ,Strasse="Rosmarinweg 5",Vorname="Thomas"}
            );
        }

    }

}


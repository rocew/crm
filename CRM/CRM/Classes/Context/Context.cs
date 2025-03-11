using CRM.Classes.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Classes.Context
{
    public class Context : DbContext
    {
        public DbSet<Certificate> certificates { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<DriverLicense> driver_licenses { get; set; }
        public DbSet<Education> educations { get; set; }
        public DbSet<Experience> experiences { get; set; }
        public DbSet<Language> languages { get; set; }
        public DbSet<Portfolio> portfolio { get; set; }
        public DbSet<Recommendation> recommendations { get; set; }
        public DbSet<Relocation> relocations { get; set; }
        public DbSet<Resume> resumes { get; set; }
        public DbSet<Skill> skills { get; set; }
        public DbSet<Specialization> specializations { get; set; }

        public Context()
        {
            Database.EnsureCreated();
            certificates.Load();
            contacts.Load();
            driver_licenses.Load();
            educations.Load();
            experiences.Load();
            languages.Load();
            portfolio.Load();
            recommendations.Load();
            relocations.Load();
            resumes.Load();
            skills.Load();
            specializations.Load();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql(Config.Config.connection);
    }
}

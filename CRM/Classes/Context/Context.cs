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
        public DbSet<CandidateFiles> candidate_files { get; set; }
        public DbSet<Employees> employees { get; set; }
        public DbSet<EmployeeFiles> employee_files { get; set; }
        public DbSet<Departments> departments { get; set; }
        public DbSet<Positions> positions { get; set; }
        public DbSet<Candidates> candidates { get; set; }
        public DbSet<CandidateTestTasks> candidate_test_tasks { get; set; }
        public DbSet<HrCalendar> hr_calendar { get; set; }
        public DbSet<TestTasks> test_tasks { get; set; }


        public Context()
        {
            employees.Load();
            employee_files.Load();
            departments.Load();
            positions.Load();
            candidate_files.Load();
            candidates.Load();
            candidate_test_tasks.Load();
            hr_calendar.Load();
            test_tasks.Load();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Config.Config.connection);
        }
    }
}

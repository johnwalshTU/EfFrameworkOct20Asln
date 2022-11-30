using DatabaseLib.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLib.Repository
{
    public class CollegeContext : DbContext
    {
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Module> Modules { get; set; }

        public CollegeContext() : base("JohnDB")
        {
            Database.SetInitializer<CollegeContext>(new DropCreateDatabaseIfModelChanges<CollegeContext>());
        }
    }
}

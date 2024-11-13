using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentregistreringsprogram_inlämningsuppgift
{
    internal class StudentDBContext : DbContext
    {
        private string dbConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentregDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(dbConnectionString);
        }
    }
}

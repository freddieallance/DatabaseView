using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace 'server', 'user', 'password', and 'database' with your MySQL connection details
            string connectionString = "server=localhost;user=root;password=allance99;database=ela_db;";
            //string connectionString = "server=172.26.80.150;user=rbs;password=rbsdbadmin;database=Ela_DB;";
            //string connectionString = "server=localhost;user=root;password=allance99;database=ela_db;";

            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
        public DbSet<Agency> agency { get; set; }
    }
}

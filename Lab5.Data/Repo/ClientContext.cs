using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Lab5.Data.Repo
{
    public class ClientContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Haircut> Haircuts { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(7, 0, 0));
            optionsBuilder.UseMySql("server=localhost;user=root;password=qwerty;database= haircut_db ", serverVersion);

            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Agenda_de_Activitati.Models
{
    class EF_ApplicationContext: DbContext
    {

        public EF_ApplicationContext()
        {
            try
            {
                Database.Migrate();


            }catch(Exception)
            {
                Console.WriteLine("Tabelele din BD reflecta structura claselor de C#.");
            }

        }

        public  DbSet<EvenimentFirma> evenimente { get; set; }
        public DbSet<ActivitatiFamilie> familie { get; set; }
        public DbSet<ActivitatiFamilie> family { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=Activitati.db");

        }

       
    }
}

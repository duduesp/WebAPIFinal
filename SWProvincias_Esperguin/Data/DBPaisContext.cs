using Microsoft.EntityFrameworkCore;
using SWProvincias_Esperguin.Models;

namespace SWProvincias_Esperguin.Data
{
    public class DBPaisContext : DbContext
    {
        //Constructor
        public DBPaisContext(DbContextOptions<DBPaisContext> options) : base(options) { }

        //Propiedades


        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }


    }
}

using Microsoft.EntityFrameworkCore;
using Entity;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Datos
{
    public class PulsacionesContext : DbContext
    {
        public PulsacionesContext(DbContextOptions options):base(options)
        {
            
        } 
        public DbSet<Persona> Personas { get; set; }
        
    }
}
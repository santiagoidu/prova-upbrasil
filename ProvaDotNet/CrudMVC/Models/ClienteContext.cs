using System.Data.Entity;

namespace CrudMVC.Models
{
    public class ClienteContext : DbContext
    {
        public ClienteContext() : base("Banco")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
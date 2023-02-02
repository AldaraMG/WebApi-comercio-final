using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using WebApi.Models;

namespace WebApi.Models
{
    public class ServiceContext : DbContext// hacemos referencia a la cadena de conexión y especificar las clases que van a participar. Gestiona esta info.

    {

        public ServiceContext()
        {

        }
        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options) //ahora ponemos las clases que van a participar

        { }




        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Client> Client { get; set; }
    


    }
}

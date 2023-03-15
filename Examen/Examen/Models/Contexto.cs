using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Examen.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }



        public DbSet<ProveedoresModelo> Proveedores { get; set; }

        public DbSet<ProductosModelo> Productos { get; set; }

        public DbSet<PedidosModelo> Pedidos { get; set; }

        public DbSet<ProvProdModelo> ProvProd { get; set; }

        public DbSet<PedidosProductosModelo> PedidosProductos { get; set; }

    }
}

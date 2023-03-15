using System.ComponentModel.DataAnnotations.Schema;

namespace Examen.Models
{
    public class PedidosModelo
    {
        public int ID { get; set; }

        public string fechaPedido { get; set; }

        //public ProductosModelo Productos { get; set; }

        public int proveedorID { get; set; }

        [NotMapped]
        public List<int> ProductosSeleccionados { get; set; }

        public List<PedidosProductosModelo> PedidosProductos { get; set; }
    }
}

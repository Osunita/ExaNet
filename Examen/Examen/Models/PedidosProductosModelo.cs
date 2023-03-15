namespace Examen.Models
{
    public class PedidosProductosModelo
    {

        public int ID { get; set; }

        public PedidosModelo Pedido { get; set; }
        public int pedidoID { get; set; }

        public ProductosModelo Producto { get; set; }
        public int productoID { get; set; }
    }
}

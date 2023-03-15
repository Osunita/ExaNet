namespace Examen.Models
{
    public class ProductosModelo
    {

        public int ID { get; set; }

        public string nomProducto { get; set; }

        public List<PedidosModelo> Pedidos { get; set; }
    }
}
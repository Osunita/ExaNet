namespace Examen.Models
{
    public class ProvProdModelo
    {
        public int ID { get; set; }

        public ProveedoresModelo Proveedor { get; set; }
        public int proveedorID { get; set; }

        public ProductosModelo Producto { get; set; }
        public int productoID { get; set; }
    }
}

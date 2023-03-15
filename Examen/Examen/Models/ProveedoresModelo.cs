using System.Drawing.Printing;

namespace Examen.Models
{
    public class ProveedoresModelo
    {
        public int ID { get; set; }

        public string nomProveedor { get; set; }

        public List<ProductosModelo> Productos { get; set; }
    }
}

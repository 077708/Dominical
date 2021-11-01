using Repository.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Productos
{
    public class UnidadDeTrabajo
    {
        public static UnidadDeTrabajo unidadDeTrabajo { get; } = new UnidadDeTrabajo();

        public ProductoRepository productoRepository { get; } = new ProductoRepository();
    }
}

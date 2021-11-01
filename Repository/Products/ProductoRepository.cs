using Domain.Enums;
using Domain.Interfaces;
using Domain.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Products
{
    public class ProductoRepository : BaseColeccion<Pro>, IProducto
    {
        public List<Pro> GetByCodigo(int codigo)
        {
            return (List<Pro>)(from d in coleccion where d.Codigo == codigo select d);
        }

        public List<Pro> GetByMarcas(Marca marca)
        {
            return (List<Pro>)(from d in coleccion where d.Marca == marca select d);
        }

        public List<Pro> GetByName(string names)
        {
            return (List<Pro>)(from d in coleccion where d.Nombre == names select d);
        }

        public List<Pro> GetByPrice(decimal precio)
        {
            return (List<Pro>)(from d in coleccion where d.Precio == precio select d);
        }

        public void OrderByName()
        {
            coleccion.OrderBy(N => N.Nombre);
        }
    }
}

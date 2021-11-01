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
        public Pro GetByCodigo(int codigo)
        {
            return (Pro)coleccion.Where(p => p.Codigo == codigo);
            //return (List<Pro>)(from d in coleccion where d.Codigo == codigo select d);
        }

        public List<Pro> GetByMarcas(Marca marca)
        {
            return (from d in coleccion where d.Marca == marca select d).ToList();
        }

        public List<Pro> GetByName(string names)
        {
            return coleccion.Where(p => p.Nombre == names).ToList();
        }

        public List<Pro> GetByPrice(decimal precio)
        {
            return (from d in coleccion where d.Precio == precio select d).ToList();
        }

        public void OrderByName()
        {
            coleccion.OrderBy(N => N.Nombre);
        }
    }
}

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
            //Se retorna solamente un producto debido a que cada producto tiene un codigo unico
            return (Pro)coleccion.Where(p => p.Codigo == codigo);
            //return (List<Pro>)(from d in coleccion where d.Codigo == codigo select d);
        }

        public List<Pro> GetByMarcas(Marca marca)
        {
            //Seleccionamos todas las marcas de nuestra coleccion
            return (from d in coleccion where d.Marca == marca select d).ToList();
        }

        public List<Pro> GetByName(string names)
        {
            //Seleccionamos todos los elementos con el mismo nombre
            return coleccion.Where(p => p.Nombre == names).ToList();
        }

        public List<Pro> GetByPrice(decimal precio)
        {
            //Seleccionamos todos los precios que el usuario desea
            return (from d in coleccion where d.Precio == precio select d).ToList();
        }

        public List<Pro> OrderByName()
        {
            //Ordenamos por nombre
            return (from word in coleccion orderby word.Nombre select word).ToList();
        }
    }
}

using Domain.Enums;
using Domain.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IProducto : IColeccion<Pro>
    {
        List<Pro> GetByName(string Names);

        Pro GetByCodigo(int Codigo);

        List<Pro> OrderByName();

        List<Pro> GetByPrice(decimal precio);

        List<Pro> GetByMarcas(Marca marca);
     }
}

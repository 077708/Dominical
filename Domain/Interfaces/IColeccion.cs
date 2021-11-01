using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IColeccion <T>
    {
        void Add(T t);

        void Update(T t);

        T[] FindAll();

        void Delete(T t);
    }
}

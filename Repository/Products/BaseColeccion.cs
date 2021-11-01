using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Products
{
    public class BaseColeccion<T> : IColeccion<T>
    { 
        protected List<T> coleccion = new List<T>();

        public void Add(T t)
        {
            coleccion.Add(t);
        }

        public void Delete(T t)
        {
            coleccion.Remove(t);
        }

        public T[] FindAll()
        {
            return coleccion.ToArray();
        }

        public void Update(T t)
        {
            if (t == null)
            {
                throw new Exception("El objeto no puede ser null");
            }

            int index = GetIndex(t);
            coleccion[index] = t;
        }

        private int GetIndex(T t)
        {
            int index = int.MinValue, i = 0;
            int? Codigo = (int)t.GetType().GetProperty("Codigo")?.GetValue(t);

            if (Codigo == null)
            {
                throw new ArgumentException($"El objeto {t.GetType().Name} no contiene la propiedad Id");
            }

            foreach (T e in coleccion)
            {
                int key = (int)t.GetType().GetProperty("Codigo").GetValue(e);
                if (Codigo == key)
                {
                    index = i;
                    break;
                }
                i++;
            }

            return index;


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.DAO
{
    interface IDAO<T>
    {
        void add(T obj);

        void update(T obj);

        void get(T obj);

        List<T> getAll(T obj);
    }
}

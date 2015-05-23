using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Model
{
    interface IModel<T>
    {
        void add();

        void update();

        void delete();

        void get();

        List<T> getAll();        
    }
}

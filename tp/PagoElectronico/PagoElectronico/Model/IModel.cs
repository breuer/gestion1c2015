using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Model
{
    interface IModel<T>
    {
        int add();

        void update();

        void delete();

        int get();

        List<T> getAll();        
    }
}

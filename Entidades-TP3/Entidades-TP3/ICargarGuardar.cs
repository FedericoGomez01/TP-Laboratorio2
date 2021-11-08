using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TP3
{
    interface ICargarGuardar<T>
        where T : class
    {

        public string GuardadArchivo(string info);

        public string CargarArchivo();
        
    }
}

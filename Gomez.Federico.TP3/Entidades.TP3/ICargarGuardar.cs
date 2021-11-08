using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.TP3
{
    public interface ICargarGuardar
    {
        //public void GuardarComo();

        public void Guardar(string nombre);

        public string Leer();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TP3
{
    public class Corredor : Persona
    {
        private bool pilotoPrincipal;

        public Corredor(string nombre, short edad, Sexos sexo, bool pilotoPrincipal) : base(nombre, edad, sexo)
        {
            this.pilotoPrincipal = pilotoPrincipal;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--- Corredor ---");
            sb.AppendLine(base.Mostrar());
            return sb.ToString();
        }
    }
}

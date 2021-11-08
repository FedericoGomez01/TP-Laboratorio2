using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TP3
{
    public class Votante : Persona
    {
        public enum Escuderias { Mercedes, Ferrari ,Red_Bull, Alpine, Hass, McLaren, Alfa_Romeo, Aston_Martin, Alphatauri, Williams}
        private string pais;
        private Escuderias escuderia;
        
        public Votante(string nombre, short edad, Sexos sexo, string pais, Escuderias escuderia) : base(nombre, edad, sexo)
        {
            this.pais = pais;
            this.escuderia = escuderia;
        }

        public string Pais 
        { 
            get { return this.pais; } 
            
            set 
            { 
                if(value != null)
                    this.pais = value; 
            } 
        }
        public Escuderias Escuderia { get { return this.escuderia; }

            set
            {
                    this.escuderia = value;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--- Votante ---");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Escuderia: " + this.Escuderia);
            sb.AppendLine("Localidad: " + this.Pais);
            return sb.ToString();
        }

        public static bool operator ==(Votante v1, Votante v2)
        {
            return v1.Id == v2.Id;
        }
        public static bool operator !=(Votante v1, Votante v2)
        {
            return !(v1 == v2);
        }

    }
}

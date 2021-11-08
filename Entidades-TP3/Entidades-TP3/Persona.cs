using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TP3
{
    
    public abstract class Persona
    {
        public enum Sexos { Hombre, Mujer, NoBinario };
        private string nombre;
        private short edad;
        private short id;
        private Sexos sexo;

        public Persona(string nombre, short edad, Sexos sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public string Nombre {   
            get { return this.nombre; }
            set
            {
                //if(value != null)
                //{
                    this.nombre = value;
                //}
            }
        }

        public short Edad { get { return this.edad; }
            set
            {
                if (value == 0)
                {
                    this.edad = value;
                }
            }
        }

        public Sexos Sexo { get { return this.sexo; }
            set
            {
                this.sexo = value;
            }
        }

        public int Id { get{ return this.id; } }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Edad: " + this.Edad);
            sb.AppendLine("Sexo: " + this.Sexo);
            return sb.ToString();
        }


    }
}

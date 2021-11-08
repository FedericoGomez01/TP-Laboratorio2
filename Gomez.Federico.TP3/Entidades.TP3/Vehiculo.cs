using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.TP3
{
    public class Vehiculo
    {
        private string nombre;
        private string patente;
        private int anio;
        private string tipo;

        public Vehiculo() { }
        public Vehiculo(string nombre, string patente, int anio, string tipo)
        {
            this.nombre = nombre;
            this.patente = patente;
            this.anio = anio;
            this.tipo = tipo;
        }


        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Patente { get { return this.patente; } set { this.patente = value; } }
        public int Anio { get { return this.anio; } set { this.anio = value; } }
        public string Tipo { get { return this.tipo; } set { this.tipo = value; } }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {

            return v1.patente == v2.patente;
            
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Patente: " + this.Patente);
            sb.AppendLine("Año: " + this.Anio);
            sb.AppendLine("Tipo: " + this.Tipo);
            return sb.ToString();
        }
    }
}

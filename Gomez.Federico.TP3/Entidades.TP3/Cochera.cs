using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.TP3
{
    public class Cochera
    {
        private List<Vehiculo> vehiculos;

        public Cochera()
        {
            this.vehiculos = new List<Vehiculo>();

        }

        public List<Vehiculo> Vehiculos { get { return this.vehiculos; } set { this.vehiculos = value; } }

        public static Cochera operator +(Cochera cochera, Vehiculo vehiculo)
        {
            bool estaEnCochera = false;
            foreach (Vehiculo v in cochera.vehiculos)
            {
                if(v == vehiculo)
                {
                    estaEnCochera = true;
                }
            }
            if(!estaEnCochera)
            {
                cochera.vehiculos.Add(vehiculo);
            }
            return cochera;
        }


        public static Cochera operator -(Cochera cochera, Vehiculo vehiculo)
        {
            bool noEstaEnCochera = true;
            foreach (Vehiculo v in cochera.vehiculos)
            {
                if (v == vehiculo)
                {
                    noEstaEnCochera = false;
                }
            }
            if (!noEstaEnCochera)
            {
                cochera.vehiculos.Remove(vehiculo);
            }
            return cochera;
        }

    }
}

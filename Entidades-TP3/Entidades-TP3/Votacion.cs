using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TP3
{
    public class Votacion
    {
        private string nombre;
        private List<Votante> votadores;

        private Votacion()
        {
            votadores = new List<Votante>();
        }
        public Votacion(string nombre)
        {
            this.nombre = nombre;
        }

        List<Votante> Votadores { get { return this.votadores; } }
        string Nombre { get { return this.nombre; } }


        public static List<Votante> operator +(Votacion votantes, Votante votador)
        {
            bool agregarALista = true;
            foreach (Votante v in votantes.votadores) 
            {
                if(v == votador)
                {
                    agregarALista = false;
                    break;
                }
            }

            if(agregarALista)
            {
                votantes.votadores.Add(votador);
            }
            return votantes.votadores;
        }
    }
}

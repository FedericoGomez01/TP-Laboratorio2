using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades_TP3
{
    public class GestorDeArchivos : ICargarGuardar<Votante>
    {
        private string path;
        public GestorDeArchivos(string path)
        {
            this.path = path;
        }

        public string CargarArchivo()
        {
            using (StreamReader sr = new StreamReader(this.path))
            {
                try
                {
                    return sr.ReadToEnd();
                }
                catch (Exception ex)
                {
                    return $"Exception: {ex.Message.ToString()}";
                } 
            }
        }

        public string GuardadArchivo(string informacion)
        {
            using (StreamWriter sw = new StreamWriter(this.path, true))
            {
                try
                {
                   sw.WriteLine(informacion);
                    return "true";
                }
                catch (Exception ex)
                {
                   return $"Exception: {ex.Message.ToString()}";
                }
            }
        }
    }
}

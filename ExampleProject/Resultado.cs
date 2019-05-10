using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleProject
{
    public class Resultado
    {
        public Resultado()
        {
            mensajes = new List<string>();
        }

        public Resultado(bool resultado, string mensaje)
        {
            this.resultado = resultado;
            mensajes = new List<string>();
            mensajes.Add(mensaje);
        }

        public bool resultado { get; set; }
        public List<string> mensajes { get; set; }
        public dynamic datos { get; set; }

        public int codigo { get; set; }
    }
}
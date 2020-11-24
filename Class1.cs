using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    public class Sala
    {
        public String nombre_evento { get; set; }
        public String hora { get; set; }
        public List<Asiento> asientos { get; set; }

        public Sala(string nombre_evento, string hora, List<Asiento> asientos)
        {
            this.nombre_evento = nombre_evento;
            this.hora = hora;
            this.asientos = asientos;
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}

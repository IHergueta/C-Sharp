using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Persona
    {

        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string dni { get; set; }
        public string fecha { get; set; }
        public int altura { get; set; }
        public int peso { get; set; }

        public Persona(string nombre, string apellidos, string dni, string fecha, int altura, int peso)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.fecha = fecha;
            this.altura = altura;
            this.peso = peso;
        }

        public override string ToString()
        {
            return "Dni -> " + this.dni + " ,Nombre -> " + this.nombre + " ,Apellidos -> " + this.apellidos + " ,Fecha -> " + this.fecha + " ,Altura -> " + this.altura + " ,Peso -> " + this.peso;
        }
    }
}

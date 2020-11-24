using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Practica4
{
    public class Asiento
    {
        public int fila;
        public int columna;
        public string estado;
        

        public Asiento(int fila, int columna, string estado)
        {
            this.fila = fila;
            this.columna = columna;
            this.estado = estado;
           
        }

        public void toString()
        {

            MessageBox.Show("El asiento " + fila + ":" + columna + " esta " + estado);

        }
    }
}

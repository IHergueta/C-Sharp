using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form6 : Form
    {
        List<Persona> referencialista6;
        Form1 f1;
        public Form6(List<Persona> personas6,Form1 f1)
        {
            InitializeComponent();
            this.referencialista6 = personas6;
            this.f1 = f1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            f1.Show();
        }

        private void btn_mostrarnombreslargos_Click(object sender, EventArgs e)
        {
            foreach(Persona p in referencialista6)
            {
                if(p.nombre.Equals("") || p.apellidos.Equals("") || p.dni.Equals("") || p.fecha.Equals(""))
                {

                    listBox1.Items.Add(p);
                }
            }
        }
    }
}

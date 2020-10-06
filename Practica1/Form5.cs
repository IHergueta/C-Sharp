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
    public partial class Form5 : Form
    {
        List<Persona> refrencialista5;
        Form1 f1;
        public Form5(List<Persona> personas5,Form1 f1)
        {
            InitializeComponent();
            this.refrencialista5 = personas5;
            this.f1 = f1;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btn_mostrarnombreslargos_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //encuentra el nombre mas largo
            int cont = 0;
            int cont2 = 0;
            int cont3 = 0;
            string p1="";
            string p2 = "";
            string p3 = "";

            foreach (Persona p in refrencialista5)
            {
                
                if (p.nombre.Length > cont)
                {
                    cont = p.nombre.Length;
                    //nombre mas largo
                    p1 = p.nombre;
    
                }

                if (p.nombre.Length > cont2 && p.nombre != p1)
                {
                    cont2 = p.nombre.Length;
                    //nombre mas largo excluyendo la persona 1
                    p2 = p.nombre;
                }

                if (p.nombre.Length > cont3 && p.nombre != p1 && p.nombre != p2)
                {
                    cont3 = p.nombre.Length;
                    //nombre mas largo excluyendo la persona 1 y dos
                    p3 = p.nombre;
                }

            }
            listBox1.Items.Add(p1);
            listBox1.Items.Add(p2);
            listBox1.Items.Add(p3);




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            f1.Show();
        }
    }
}

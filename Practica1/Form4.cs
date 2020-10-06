using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form4 : Form
    {
        List<Persona> referencialista4;
        Form1 f1;
        public Form4(List<Persona> personas4,Form1 f1)
        {
            InitializeComponent();
            this.referencialista4 = personas4;
            this.f1 = f1;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            bool encontrado=false;
            foreach(Persona p in referencialista4)
            {
               
               if (txt_dniconsulta.Text.Equals(p.dni))
                {
                    listBox1.Items.Add(p);
                    encontrado = true;
                    break;  
                }
                else
                {
                     encontrado = false;
                }
               
             
            }
             if(encontrado ==false)
            {
                MessageBox.Show("ERROR! Persona inexsistente");
                
            }
        }

        private void btn_volver4_Click(object sender, EventArgs e)
        {
            this.Hide();

            f1.Show();
        }
    }
}

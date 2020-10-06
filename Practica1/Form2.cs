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
    public partial class Form2 : Form
    {
        List<Persona> referencialista;
        Form1 f1;
        public Form2(List<Persona> personas,Form1 f1)
        {
            InitializeComponent();
            this.referencialista = personas;
            this.f1 = f1;
        }

        private void Registro_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            for(int i=0;i < referencialista.Count();i++)
            {
                if (txt_dni.Text == referencialista[i].dni)
                {
                    MessageBox.Show("ERROR!,PERSONA DUPLICADA");
                    f1.Show();
                    this.Hide();
                    referencialista.Remove(referencialista[i]);
                }
            }
            
            int altura = int.Parse(txt_altura.Text);
            int peso = int.Parse(txt_peso.Text);

           
            referencialista.Add(new Persona(txt_nombre.Text, txt_apellidos.Text, txt_dni.Text, txt_fecha.Text, altura, peso));

            this.Hide();

            f1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();

            f1.Show();
        }
    }
}

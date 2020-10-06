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
    public partial class Form1 : Form
    {

        List<Persona> lista = new List<Persona>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 f2 = new Form2(lista,this);

            f2.Show();
        }

        private void btn_listado_Click(object sender, EventArgs e)
        { 
            this.Hide();

            Form3 f3 = new Form3(lista,this);

            f3.Show();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form4 f4 = new Form4(lista,this);

            f4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista.Add(new Persona("Cristiano", "Ronaldo", "123456789C", "12-4-1999", 185, 80));
            lista.Add(new Persona("Lionel", "Messi", "987654321M", "12-4-1999", 170, 70));
            lista.Add(new Persona("Joao", "Felix", "653895725R", "12-4-1999", 180, 76));
            lista.Add(new Persona("Ferreira", "Carrasco", "892310957L", "12-4-1999", 170, 76));
            lista.Add(new Persona("", "Mbappe", "874635790P", "12-4-1999", 170, 76));

            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_consultanombres_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form5 f5 = new Form5(lista,this);

            f5.Show();
        }

        private void btn_nodatos_Click(object sender, EventArgs e)
        {

            this.Hide();

            Form6 f6 = new Form6(lista, this);

            f6.Show();
        }

        
    }
}

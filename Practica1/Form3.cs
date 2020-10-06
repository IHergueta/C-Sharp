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
    public partial class Form3 : Form
    {
        List<Persona> referencialista3;
        Form1 f1;
        public Form3(List<Persona> personas,Form1 f1)
        {
            InitializeComponent();
            this.referencialista3 = personas;
            this.f1 = f1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = referencialista3;
           
            //instacio num para que sea string el numero y poder enseñarlo en el texbox
            string num = "" + referencialista3.Count();
            txt_num.Text= num;
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();

            f1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}

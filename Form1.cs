using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Form1 : Form
    {
        //creo esto para arreglar el problema de hacer todo en un mismo formulario, voy a decir que si es false no pueda pulsar la celda
        Boolean validacion;
        public Form1()
        {
            InitializeComponent();

        }

        private void agendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
             
        }

        private void agendaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void btn_crearagenda_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2(false);

            this.Hide();

            f2.Show();
        }

        private void btn_nuevatarea_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(0,false);

            this.Hide();

            f3.Show();
        }

        private void btn_modificartarea_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(0,false);

            this.Hide();

            f3.Show();
        }

        private void btn_borrartarea_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(0,false);

            this.Hide();

            f3.Show();
        }

        private void btn_tareasagenda_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(true);

            this.Hide();

            f2.Show();
        }

    
    }
}

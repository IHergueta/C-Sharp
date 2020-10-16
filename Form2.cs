using Practica2.miagendaDataSetTableAdapters;
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
    public partial class Form2 : Form
    {
        Boolean validacion;
        int dia;
        public Form2(Boolean validacion)
        {
            InitializeComponent();
            this.validacion = validacion;
        }

        private void agendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.miagendaDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet.agenda' Puede moverla o quitarla según sea necesario.
            this.agendaTableAdapter.Fill(this.miagendaDataSet.agenda);

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            this.Hide();

            f1.Show();
        }

        private void agendaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //como validacion es igual a true entrara y se podra seleccionar la celda para ir a vere la tareas, pero si 
            //es igual a false no entra y dejara crear una agenda
            if (validacion == true)
            {

                int id = (int)agendaDataGridView.Rows[e.RowIndex].Cells[0].Value;

                this.Hide();

                //le paso el true por que aqui quiero que pueda selecionar celdas
                Form3 f3 = new Form3(id, true);

                f3.Show();
            }
           

        }
    }
}

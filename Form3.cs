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
    public partial class Form3 : Form
    {
        //creo una variable para poder utilizar el mismo formulario para modificar,crear,eliminar tares y hacer el filtro de busqueda
        Boolean visible;
        int id_agenda;
        public Form3(int id,Boolean visible)
        {
            InitializeComponent();
            this.id_agenda = id;
            this.visible = visible;

        }

        private void tareaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tareaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.miagendaDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet.tarea' Puede moverla o quitarla según sea necesario.
            this.tareaTableAdapter.Fill(this.miagendaDataSet.tarea);
            
            //si visible es true hago que se enseñe la busqueda
            if (visible == true)
            {
                lab_id.Visible = true;
                txt_id.Visible = true;
                btn_enviar.Visible = true;

                this.tareaTableAdapter.FillBy(this.miagendaDataSet.tarea,id_agenda);

            }
            //si no lo esconda para que no pueda buscar en la parte de crear,modificar y elminiar tareas
            else if(visible == false)
            {
                lab_id.Visible = false;
                txt_id.Visible = false;
                btn_enviar.Visible = false;
            }
            

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            this.Hide();

            f1.Show();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            //parseo el dai por que es un text y lo paso a int para que pueda hacer bien la busqueda
            int dia = Int32.Parse(txt_id.Text);
            this.tareaTableAdapter.FillBy1(this.miagendaDataSet.tarea,id_agenda, dia);

            //refesco la pantalla
            Refresh();

        }
    }
}

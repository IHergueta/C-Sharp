namespace Practica1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_insertar = new System.Windows.Forms.Button();
            this.btn_listado = new System.Windows.Forms.Button();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_consultanombres = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_nodatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_insertar
            // 
            this.btn_insertar.BackColor = System.Drawing.Color.Black;
            this.btn_insertar.ForeColor = System.Drawing.Color.Pink;
            this.btn_insertar.Location = new System.Drawing.Point(3, 0);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(142, 68);
            this.btn_insertar.TabIndex = 0;
            this.btn_insertar.Text = "Insetar Persona";
            this.btn_insertar.UseVisualStyleBackColor = false;
            this.btn_insertar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_listado
            // 
            this.btn_listado.BackColor = System.Drawing.Color.Black;
            this.btn_listado.ForeColor = System.Drawing.Color.Pink;
            this.btn_listado.Location = new System.Drawing.Point(3, 64);
            this.btn_listado.Name = "btn_listado";
            this.btn_listado.Size = new System.Drawing.Size(142, 74);
            this.btn_listado.TabIndex = 1;
            this.btn_listado.Text = "Listar Personas";
            this.btn_listado.UseVisualStyleBackColor = false;
            this.btn_listado.Click += new System.EventHandler(this.btn_listado_Click);
            // 
            // btn_consulta
            // 
            this.btn_consulta.BackColor = System.Drawing.Color.Black;
            this.btn_consulta.ForeColor = System.Drawing.Color.Pink;
            this.btn_consulta.Location = new System.Drawing.Point(3, 133);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(142, 65);
            this.btn_consulta.TabIndex = 2;
            this.btn_consulta.Text = "Consulta por Dni";
            this.btn_consulta.UseVisualStyleBackColor = false;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // btn_consultanombres
            // 
            this.btn_consultanombres.BackColor = System.Drawing.Color.Black;
            this.btn_consultanombres.ForeColor = System.Drawing.Color.Pink;
            this.btn_consultanombres.Location = new System.Drawing.Point(3, 195);
            this.btn_consultanombres.Name = "btn_consultanombres";
            this.btn_consultanombres.Size = new System.Drawing.Size(142, 74);
            this.btn_consultanombres.TabIndex = 3;
            this.btn_consultanombres.Text = "Consulta nombre mas largos";
            this.btn_consultanombres.UseVisualStyleBackColor = false;
            this.btn_consultanombres.Click += new System.EventHandler(this.btn_consultanombres_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Black;
            this.btn_salir.ForeColor = System.Drawing.Color.Pink;
            this.btn_salir.Location = new System.Drawing.Point(3, 336);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(142, 101);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_nodatos
            // 
            this.btn_nodatos.BackColor = System.Drawing.Color.Black;
            this.btn_nodatos.ForeColor = System.Drawing.Color.Pink;
            this.btn_nodatos.Location = new System.Drawing.Point(3, 266);
            this.btn_nodatos.Name = "btn_nodatos";
            this.btn_nodatos.Size = new System.Drawing.Size(142, 74);
            this.btn_nodatos.TabIndex = 5;
            this.btn_nodatos.Text = "Mostrar persona que no tengas datos";
            this.btn_nodatos.UseVisualStyleBackColor = false;
            this.btn_nodatos.Click += new System.EventHandler(this.btn_nodatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btn_nodatos);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_consultanombres);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.btn_listado);
            this.Controls.Add(this.btn_insertar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.Button btn_listado;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_consultanombres;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_nodatos;
    }
}


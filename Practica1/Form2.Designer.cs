namespace Practica1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lab_registro = new System.Windows.Forms.Label();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(130, 75);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 26);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.Text = "Nombre";
            // 
            // lab_registro
            // 
            this.lab_registro.AutoSize = true;
            this.lab_registro.Location = new System.Drawing.Point(356, 28);
            this.lab_registro.Name = "lab_registro";
            this.lab_registro.Size = new System.Drawing.Size(69, 20);
            this.lab_registro.TabIndex = 1;
            this.lab_registro.Text = "Registro";
            this.lab_registro.Click += new System.EventHandler(this.Registro_Click);
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(130, 171);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(100, 26);
            this.txt_apellidos.TabIndex = 2;
            this.txt_apellidos.Text = "Apellidos";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(130, 274);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(100, 26);
            this.txt_dni.TabIndex = 3;
            this.txt_dni.Text = "Dni";
            this.txt_dni.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(544, 75);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(100, 26);
            this.txt_fecha.TabIndex = 4;
            this.txt_fecha.Text = "Fecha de nacimiento";
            this.txt_fecha.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(544, 171);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(100, 26);
            this.txt_altura.TabIndex = 5;
            this.txt_altura.Text = "Altura";
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(544, 274);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(100, 26);
            this.txt_peso.TabIndex = 6;
            this.txt_peso.Text = "Peso";
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(299, 354);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(75, 39);
            this.btn_enviar.TabIndex = 7;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(405, 354);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(79, 37);
            this.btn_volver.TabIndex = 8;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.txt_apellidos);
            this.Controls.Add(this.lab_registro);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lab_registro;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Button btn_volver;
    }
}
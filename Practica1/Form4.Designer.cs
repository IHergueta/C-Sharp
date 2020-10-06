namespace Practica1
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.txt_dniconsulta = new System.Windows.Forms.TextBox();
            this.lab_dni = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_volver4 = new System.Windows.Forms.Button();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(298, 69);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(75, 35);
            this.btn_mostrar.TabIndex = 0;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // txt_dniconsulta
            // 
            this.txt_dniconsulta.Location = new System.Drawing.Point(436, 28);
            this.txt_dniconsulta.Name = "txt_dniconsulta";
            this.txt_dniconsulta.Size = new System.Drawing.Size(98, 26);
            this.txt_dniconsulta.TabIndex = 1;
            // 
            // lab_dni
            // 
            this.lab_dni.AutoSize = true;
            this.lab_dni.Location = new System.Drawing.Point(316, 28);
            this.lab_dni.Name = "lab_dni";
            this.lab_dni.Size = new System.Drawing.Size(33, 20);
            this.lab_dni.TabIndex = 2;
            this.lab_dni.Text = "Dni";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(110, 130);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(575, 264);
            this.listBox1.TabIndex = 3;
            // 
            // btn_volver4
            // 
            this.btn_volver4.Location = new System.Drawing.Point(450, 69);
            this.btn_volver4.Name = "btn_volver4";
            this.btn_volver4.Size = new System.Drawing.Size(75, 35);
            this.btn_volver4.TabIndex = 4;
            this.btn_volver4.Text = "Volver";
            this.btn_volver4.UseVisualStyleBackColor = true;
            this.btn_volver4.Click += new System.EventHandler(this.btn_volver4_Click);
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataSource = typeof(Practica1.Persona);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_volver4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lab_dni);
            this.Controls.Add(this.txt_dniconsulta);
            this.Controls.Add(this.btn_mostrar);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.TextBox txt_dniconsulta;
        private System.Windows.Forms.Label lab_dni;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_volver4;
        private System.Windows.Forms.BindingSource personaBindingSource;
    }
}
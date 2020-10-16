namespace Practica2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_crearagenda = new System.Windows.Forms.Button();
            this.btn_nuevatarea = new System.Windows.Forms.Button();
            this.btn_modificartarea = new System.Windows.Forms.Button();
            this.btn_borrartarea = new System.Windows.Forms.Button();
            this.btn_tareasagenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(425, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_crearagenda
            // 
            this.btn_crearagenda.BackColor = System.Drawing.Color.Black;
            this.btn_crearagenda.ForeColor = System.Drawing.Color.Pink;
            this.btn_crearagenda.Location = new System.Drawing.Point(86, 12);
            this.btn_crearagenda.Name = "btn_crearagenda";
            this.btn_crearagenda.Size = new System.Drawing.Size(234, 50);
            this.btn_crearagenda.TabIndex = 1;
            this.btn_crearagenda.Text = "Crear Agenda";
            this.btn_crearagenda.UseVisualStyleBackColor = false;
            this.btn_crearagenda.Click += new System.EventHandler(this.btn_crearagenda_Click);
            // 
            // btn_nuevatarea
            // 
            this.btn_nuevatarea.BackColor = System.Drawing.Color.Black;
            this.btn_nuevatarea.ForeColor = System.Drawing.Color.Pink;
            this.btn_nuevatarea.Location = new System.Drawing.Point(86, 88);
            this.btn_nuevatarea.Name = "btn_nuevatarea";
            this.btn_nuevatarea.Size = new System.Drawing.Size(234, 50);
            this.btn_nuevatarea.TabIndex = 2;
            this.btn_nuevatarea.Text = "Nueva Tarea";
            this.btn_nuevatarea.UseVisualStyleBackColor = false;
            this.btn_nuevatarea.Click += new System.EventHandler(this.btn_nuevatarea_Click);
            // 
            // btn_modificartarea
            // 
            this.btn_modificartarea.BackColor = System.Drawing.Color.Black;
            this.btn_modificartarea.ForeColor = System.Drawing.Color.Pink;
            this.btn_modificartarea.Location = new System.Drawing.Point(86, 162);
            this.btn_modificartarea.Name = "btn_modificartarea";
            this.btn_modificartarea.Size = new System.Drawing.Size(234, 50);
            this.btn_modificartarea.TabIndex = 3;
            this.btn_modificartarea.Text = "Modificar Tarea";
            this.btn_modificartarea.UseVisualStyleBackColor = false;
            this.btn_modificartarea.Click += new System.EventHandler(this.btn_modificartarea_Click);
            // 
            // btn_borrartarea
            // 
            this.btn_borrartarea.BackColor = System.Drawing.Color.Black;
            this.btn_borrartarea.ForeColor = System.Drawing.Color.Pink;
            this.btn_borrartarea.Location = new System.Drawing.Point(86, 242);
            this.btn_borrartarea.Name = "btn_borrartarea";
            this.btn_borrartarea.Size = new System.Drawing.Size(234, 50);
            this.btn_borrartarea.TabIndex = 4;
            this.btn_borrartarea.Text = "Borrar Tarea";
            this.btn_borrartarea.UseVisualStyleBackColor = false;
            this.btn_borrartarea.Click += new System.EventHandler(this.btn_borrartarea_Click);
            // 
            // btn_tareasagenda
            // 
            this.btn_tareasagenda.BackColor = System.Drawing.Color.Black;
            this.btn_tareasagenda.ForeColor = System.Drawing.Color.Pink;
            this.btn_tareasagenda.Location = new System.Drawing.Point(86, 327);
            this.btn_tareasagenda.Name = "btn_tareasagenda";
            this.btn_tareasagenda.Size = new System.Drawing.Size(234, 50);
            this.btn_tareasagenda.TabIndex = 5;
            this.btn_tareasagenda.Text = "Mostrar Tareas de una Agenda";
            this.btn_tareasagenda.UseVisualStyleBackColor = false;
            this.btn_tareasagenda.Click += new System.EventHandler(this.btn_tareasagenda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.btn_tareasagenda);
            this.Controls.Add(this.btn_borrartarea);
            this.Controls.Add(this.btn_modificartarea);
            this.Controls.Add(this.btn_nuevatarea);
            this.Controls.Add(this.btn_crearagenda);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_crearagenda;
        private System.Windows.Forms.Button btn_nuevatarea;
        private System.Windows.Forms.Button btn_modificartarea;
        private System.Windows.Forms.Button btn_borrartarea;
        private System.Windows.Forms.Button btn_tareasagenda;
    }
}


﻿namespace Practica1
{
    partial class Form5
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_mostrarnombreslargos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(83, 64);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(356, 199);
            this.listBox1.TabIndex = 0;
            // 
            // btn_mostrarnombreslargos
            // 
            this.btn_mostrarnombreslargos.Location = new System.Drawing.Point(193, 30);
            this.btn_mostrarnombreslargos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_mostrarnombreslargos.Name = "btn_mostrarnombreslargos";
            this.btn_mostrarnombreslargos.Size = new System.Drawing.Size(50, 27);
            this.btn_mostrarnombreslargos.TabIndex = 1;
            this.btn_mostrarnombreslargos.Text = "Mostrar";
            this.btn_mostrarnombreslargos.UseVisualStyleBackColor = true;
            this.btn_mostrarnombreslargos.Click += new System.EventHandler(this.btn_mostrarnombreslargos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_mostrarnombreslargos);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_mostrarnombreslargos;
        private System.Windows.Forms.Button button1;
    }
}
﻿
namespace Ejemplo1_Clases
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.centroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeCentrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centroToolStripMenuItem,
            this.profesorToolStripMenuItem,
            this.estudianteToolStripMenuItem,
            this.personalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // centroToolStripMenuItem
            // 
            this.centroToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.centroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.listaDeCentrosToolStripMenuItem});
            this.centroToolStripMenuItem.Name = "centroToolStripMenuItem";
            this.centroToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
            this.centroToolStripMenuItem.Text = "Centro";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // listaDeCentrosToolStripMenuItem
            // 
            this.listaDeCentrosToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.listaDeCentrosToolStripMenuItem.Name = "listaDeCentrosToolStripMenuItem";
            this.listaDeCentrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeCentrosToolStripMenuItem.Text = "Lista de Centros";
            this.listaDeCentrosToolStripMenuItem.Click += new System.EventHandler(this.listaDeCentrosToolStripMenuItem_Click);
            // 
            // profesorToolStripMenuItem
            // 
            this.profesorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.profesorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.listaDeProfesoresToolStripMenuItem});
            this.profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            this.profesorToolStripMenuItem.Size = new System.Drawing.Size(63, 22);
            this.profesorToolStripMenuItem.Text = "Profesor";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.BackColor = System.Drawing.Color.Silver;
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // listaDeProfesoresToolStripMenuItem
            // 
            this.listaDeProfesoresToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.listaDeProfesoresToolStripMenuItem.Name = "listaDeProfesoresToolStripMenuItem";
            this.listaDeProfesoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeProfesoresToolStripMenuItem.Text = "Lista de Profesores";
            this.listaDeProfesoresToolStripMenuItem.Click += new System.EventHandler(this.listaDeProfesoresToolStripMenuItem_Click);
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.estudianteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem2,
            this.listaDeEstudiantesToolStripMenuItem});
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            this.estudianteToolStripMenuItem.Text = "Estudiante";
            // 
            // agregarToolStripMenuItem2
            // 
            this.agregarToolStripMenuItem2.BackColor = System.Drawing.Color.Silver;
            this.agregarToolStripMenuItem2.Name = "agregarToolStripMenuItem2";
            this.agregarToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem2.Text = "Agregar";
            this.agregarToolStripMenuItem2.Click += new System.EventHandler(this.agregarToolStripMenuItem2_Click);
            // 
            // listaDeEstudiantesToolStripMenuItem
            // 
            this.listaDeEstudiantesToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.listaDeEstudiantesToolStripMenuItem.Name = "listaDeEstudiantesToolStripMenuItem";
            this.listaDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeEstudiantesToolStripMenuItem.Text = "Lista de Estudiantes";
            this.listaDeEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.listaDeEstudiantesToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.personalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem3,
            this.listaDePersonalToolStripMenuItem});
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.personalToolStripMenuItem.Text = "Personal";
            // 
            // agregarToolStripMenuItem3
            // 
            this.agregarToolStripMenuItem3.BackColor = System.Drawing.Color.Silver;
            this.agregarToolStripMenuItem3.Name = "agregarToolStripMenuItem3";
            this.agregarToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem3.Text = "Agregar";
            this.agregarToolStripMenuItem3.Click += new System.EventHandler(this.agregarToolStripMenuItem3_Click);
            // 
            // listaDePersonalToolStripMenuItem
            // 
            this.listaDePersonalToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.listaDePersonalToolStripMenuItem.Name = "listaDePersonalToolStripMenuItem";
            this.listaDePersonalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDePersonalToolStripMenuItem.Text = "Lista de Personal";
            this.listaDePersonalToolStripMenuItem.Click += new System.EventHandler(this.listaDePersonalToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem centroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeCentrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaDeProfesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listaDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem listaDePersonalToolStripMenuItem;
    }
}
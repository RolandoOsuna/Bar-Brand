
namespace WTFBarber
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.Barra_Titulo = new System.Windows.Forms.Panel();
            this.btn_Maximizar = new System.Windows.Forms.PictureBox();
            this.bnt_Cerrar = new System.Windows.Forms.PictureBox();
            this.btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.btn_Restaurar = new System.Windows.Forms.PictureBox();
            this.Barra_Lateral = new System.Windows.Forms.Panel();
            this.lbl_CerrarSesion = new System.Windows.Forms.Label();
            this.btn_CerrarSesion = new System.Windows.Forms.PictureBox();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.btn_Nominas = new System.Windows.Forms.Button();
            this.btn_CorteCaja = new System.Windows.Forms.Button();
            this.btn_Cobro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelformulario = new System.Windows.Forms.Panel();
            this.Barra_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restaurar)).BeginInit();
            this.Barra_Lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CerrarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelformulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // Barra_Titulo
            // 
            this.Barra_Titulo.BackColor = System.Drawing.Color.Black;
            this.Barra_Titulo.Controls.Add(this.btn_Maximizar);
            this.Barra_Titulo.Controls.Add(this.bnt_Cerrar);
            this.Barra_Titulo.Controls.Add(this.btn_Minimizar);
            this.Barra_Titulo.Controls.Add(this.btn_Restaurar);
            this.Barra_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Barra_Titulo.Name = "Barra_Titulo";
            this.Barra_Titulo.Size = new System.Drawing.Size(1000, 32);
            this.Barra_Titulo.TabIndex = 0;
            this.Barra_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barra_Titulo_MouseDown);
            // 
            // btn_Maximizar
            // 
            this.btn_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Maximizar.BackgroundImage")));
            this.btn_Maximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Maximizar.Location = new System.Drawing.Point(931, 0);
            this.btn_Maximizar.Name = "btn_Maximizar";
            this.btn_Maximizar.Size = new System.Drawing.Size(36, 32);
            this.btn_Maximizar.TabIndex = 3;
            this.btn_Maximizar.TabStop = false;
            this.btn_Maximizar.Click += new System.EventHandler(this.btn_Maximizar_Click);
            // 
            // bnt_Cerrar
            // 
            this.bnt_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnt_Cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnt_Cerrar.BackgroundImage")));
            this.bnt_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bnt_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_Cerrar.Location = new System.Drawing.Point(964, 0);
            this.bnt_Cerrar.Name = "bnt_Cerrar";
            this.bnt_Cerrar.Size = new System.Drawing.Size(36, 32);
            this.bnt_Cerrar.TabIndex = 1;
            this.bnt_Cerrar.TabStop = false;
            this.bnt_Cerrar.Click += new System.EventHandler(this.bnt_Cerrar_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Minimizar.BackgroundImage")));
            this.btn_Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimizar.Location = new System.Drawing.Point(898, 0);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(36, 32);
            this.btn_Minimizar.TabIndex = 0;
            this.btn_Minimizar.TabStop = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // btn_Restaurar
            // 
            this.btn_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Restaurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Restaurar.BackgroundImage")));
            this.btn_Restaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Restaurar.Location = new System.Drawing.Point(931, 0);
            this.btn_Restaurar.Name = "btn_Restaurar";
            this.btn_Restaurar.Size = new System.Drawing.Size(36, 32);
            this.btn_Restaurar.TabIndex = 2;
            this.btn_Restaurar.TabStop = false;
            this.btn_Restaurar.Visible = false;
            this.btn_Restaurar.Click += new System.EventHandler(this.btn_Restaurar_Click);
            // 
            // Barra_Lateral
            // 
            this.Barra_Lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Barra_Lateral.Controls.Add(this.lbl_CerrarSesion);
            this.Barra_Lateral.Controls.Add(this.btn_CerrarSesion);
            this.Barra_Lateral.Controls.Add(this.btn_Reportes);
            this.Barra_Lateral.Controls.Add(this.btn_Nominas);
            this.Barra_Lateral.Controls.Add(this.btn_CorteCaja);
            this.Barra_Lateral.Controls.Add(this.btn_Cobro);
            this.Barra_Lateral.Controls.Add(this.button1);
            this.Barra_Lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.Barra_Lateral.Location = new System.Drawing.Point(0, 32);
            this.Barra_Lateral.Name = "Barra_Lateral";
            this.Barra_Lateral.Size = new System.Drawing.Size(228, 518);
            this.Barra_Lateral.TabIndex = 1;
            // 
            // lbl_CerrarSesion
            // 
            this.lbl_CerrarSesion.AutoSize = true;
            this.lbl_CerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_CerrarSesion.Location = new System.Drawing.Point(67, 466);
            this.lbl_CerrarSesion.Name = "lbl_CerrarSesion";
            this.lbl_CerrarSesion.Size = new System.Drawing.Size(76, 15);
            this.lbl_CerrarSesion.TabIndex = 3;
            this.lbl_CerrarSesion.Text = "Cerrar Sesión";
            this.lbl_CerrarSesion.Click += new System.EventHandler(this.lbl_CerrarSesion_Click);
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CerrarSesion.BackgroundImage")));
            this.btn_CerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_CerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CerrarSesion.Location = new System.Drawing.Point(12, 466);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(49, 40);
            this.btn_CerrarSesion.TabIndex = 3;
            this.btn_CerrarSesion.TabStop = false;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click);
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.BackColor = System.Drawing.Color.Black;
            this.btn_Reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reportes.FlatAppearance.BorderSize = 0;
            this.btn_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reportes.Font = new System.Drawing.Font("Perpetua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Reportes.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_Reportes.Location = new System.Drawing.Point(29, 323);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Size = new System.Drawing.Size(159, 51);
            this.btn_Reportes.TabIndex = 6;
            this.btn_Reportes.Text = "Reportes";
            this.btn_Reportes.UseVisualStyleBackColor = false;
            this.btn_Reportes.Click += new System.EventHandler(this.btn_Reportes_Click);
            // 
            // btn_Nominas
            // 
            this.btn_Nominas.BackColor = System.Drawing.Color.Black;
            this.btn_Nominas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nominas.FlatAppearance.BorderSize = 0;
            this.btn_Nominas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nominas.Font = new System.Drawing.Font("Perpetua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Nominas.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_Nominas.Location = new System.Drawing.Point(29, 257);
            this.btn_Nominas.Name = "btn_Nominas";
            this.btn_Nominas.Size = new System.Drawing.Size(159, 51);
            this.btn_Nominas.TabIndex = 5;
            this.btn_Nominas.Text = "Nóminas";
            this.btn_Nominas.UseVisualStyleBackColor = false;
            this.btn_Nominas.Click += new System.EventHandler(this.btn_Nominas_Click);
            // 
            // btn_CorteCaja
            // 
            this.btn_CorteCaja.BackColor = System.Drawing.Color.Black;
            this.btn_CorteCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CorteCaja.FlatAppearance.BorderSize = 0;
            this.btn_CorteCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CorteCaja.Font = new System.Drawing.Font("Perpetua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CorteCaja.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_CorteCaja.Location = new System.Drawing.Point(29, 190);
            this.btn_CorteCaja.Name = "btn_CorteCaja";
            this.btn_CorteCaja.Size = new System.Drawing.Size(159, 51);
            this.btn_CorteCaja.TabIndex = 4;
            this.btn_CorteCaja.Text = "Corte de Caja";
            this.btn_CorteCaja.UseVisualStyleBackColor = false;
            this.btn_CorteCaja.Click += new System.EventHandler(this.btn_CorteCaja_Click);
            // 
            // btn_Cobro
            // 
            this.btn_Cobro.BackColor = System.Drawing.Color.Black;
            this.btn_Cobro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cobro.FlatAppearance.BorderSize = 0;
            this.btn_Cobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cobro.Font = new System.Drawing.Font("Perpetua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cobro.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btn_Cobro.Location = new System.Drawing.Point(29, 127);
            this.btn_Cobro.Name = "btn_Cobro";
            this.btn_Cobro.Size = new System.Drawing.Size(159, 51);
            this.btn_Cobro.TabIndex = 3;
            this.btn_Cobro.Text = "Cobro";
            this.btn_Cobro.UseVisualStyleBackColor = false;
            this.btn_Cobro.Click += new System.EventHandler(this.btn_Cobro_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(-160, -164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(191, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelformulario
            // 
            this.panelformulario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelformulario.Controls.Add(this.pictureBox1);
            this.panelformulario.Location = new System.Drawing.Point(226, 32);
            this.panelformulario.Name = "panelformulario";
            this.panelformulario.Size = new System.Drawing.Size(773, 517);
            this.panelformulario.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panelformulario);
            this.Controls.Add(this.Barra_Lateral);
            this.Controls.Add(this.Barra_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Barra_Titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restaurar)).EndInit();
            this.Barra_Lateral.ResumeLayout(false);
            this.Barra_Lateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CerrarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelformulario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Barra_Titulo;
        private System.Windows.Forms.PictureBox btn_Restaurar;
        private System.Windows.Forms.PictureBox bnt_Cerrar;
        private System.Windows.Forms.PictureBox btn_Minimizar;
        private System.Windows.Forms.Panel Barra_Lateral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_Maximizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Cobro;
        private System.Windows.Forms.Button btn_Reportes;
        private System.Windows.Forms.Button btn_Nominas;
        private System.Windows.Forms.Button btn_CorteCaja;
        private System.Windows.Forms.Label lbl_CerrarSesion;
        private System.Windows.Forms.PictureBox btn_CerrarSesion;
        private System.Windows.Forms.Panel panelformulario;
    }
}
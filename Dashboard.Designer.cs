
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
            this.btn_iconoReportes = new FontAwesome.Sharp.IconButton();
            this.btn_iconoNomina = new FontAwesome.Sharp.IconButton();
            this.btn_iconoCorteCaja = new FontAwesome.Sharp.IconButton();
            this.btn_iconoCobro = new FontAwesome.Sharp.IconButton();
            this.lbl_CerrarSesion = new System.Windows.Forms.Label();
            this.btn_CerrarSesion = new System.Windows.Forms.PictureBox();
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
            this.Barra_Lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Barra_Lateral.Controls.Add(this.btn_iconoReportes);
            this.Barra_Lateral.Controls.Add(this.btn_iconoNomina);
            this.Barra_Lateral.Controls.Add(this.btn_iconoCorteCaja);
            this.Barra_Lateral.Controls.Add(this.btn_iconoCobro);
            this.Barra_Lateral.Controls.Add(this.lbl_CerrarSesion);
            this.Barra_Lateral.Controls.Add(this.btn_CerrarSesion);
            this.Barra_Lateral.Controls.Add(this.button1);
            this.Barra_Lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.Barra_Lateral.Location = new System.Drawing.Point(0, 32);
            this.Barra_Lateral.Name = "Barra_Lateral";
            this.Barra_Lateral.Size = new System.Drawing.Size(228, 518);
            this.Barra_Lateral.TabIndex = 1;
            // 
            // btn_iconoReportes
            // 
            this.btn_iconoReportes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_iconoReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_iconoReportes.FlatAppearance.BorderSize = 0;
            this.btn_iconoReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iconoReportes.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_iconoReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_iconoReportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btn_iconoReportes.IconColor = System.Drawing.Color.Red;
            this.btn_iconoReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_iconoReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iconoReportes.Location = new System.Drawing.Point(0, 290);
            this.btn_iconoReportes.Name = "btn_iconoReportes";
            this.btn_iconoReportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_iconoReportes.Size = new System.Drawing.Size(228, 48);
            this.btn_iconoReportes.TabIndex = 10;
            this.btn_iconoReportes.Text = "Reportes";
            this.btn_iconoReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iconoReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_iconoReportes.UseVisualStyleBackColor = false;
            this.btn_iconoReportes.Click += new System.EventHandler(this.btn_iconoReportes_Click);
            // 
            // btn_iconoNomina
            // 
            this.btn_iconoNomina.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_iconoNomina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_iconoNomina.FlatAppearance.BorderSize = 0;
            this.btn_iconoNomina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iconoNomina.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_iconoNomina.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_iconoNomina.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.btn_iconoNomina.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(160)))), ((int)(((byte)(8)))));
            this.btn_iconoNomina.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_iconoNomina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iconoNomina.Location = new System.Drawing.Point(0, 236);
            this.btn_iconoNomina.Name = "btn_iconoNomina";
            this.btn_iconoNomina.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_iconoNomina.Size = new System.Drawing.Size(228, 48);
            this.btn_iconoNomina.TabIndex = 9;
            this.btn_iconoNomina.Text = "Nómina";
            this.btn_iconoNomina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iconoNomina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_iconoNomina.UseVisualStyleBackColor = false;
            this.btn_iconoNomina.Click += new System.EventHandler(this.btn_iconoNomina_Click);
            // 
            // btn_iconoCorteCaja
            // 
            this.btn_iconoCorteCaja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_iconoCorteCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_iconoCorteCaja.FlatAppearance.BorderSize = 0;
            this.btn_iconoCorteCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iconoCorteCaja.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_iconoCorteCaja.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_iconoCorteCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btn_iconoCorteCaja.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.btn_iconoCorteCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_iconoCorteCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iconoCorteCaja.Location = new System.Drawing.Point(0, 182);
            this.btn_iconoCorteCaja.Name = "btn_iconoCorteCaja";
            this.btn_iconoCorteCaja.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_iconoCorteCaja.Size = new System.Drawing.Size(228, 48);
            this.btn_iconoCorteCaja.TabIndex = 8;
            this.btn_iconoCorteCaja.Text = "Corte  Caja";
            this.btn_iconoCorteCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iconoCorteCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_iconoCorteCaja.UseVisualStyleBackColor = false;
            this.btn_iconoCorteCaja.Click += new System.EventHandler(this.btn_iconoCorteCaja_Click);
            // 
            // btn_iconoCobro
            // 
            this.btn_iconoCobro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_iconoCobro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_iconoCobro.FlatAppearance.BorderSize = 0;
            this.btn_iconoCobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iconoCobro.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_iconoCobro.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_iconoCobro.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btn_iconoCobro.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(22)))), ((int)(((byte)(186)))));
            this.btn_iconoCobro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_iconoCobro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iconoCobro.Location = new System.Drawing.Point(0, 128);
            this.btn_iconoCobro.Name = "btn_iconoCobro";
            this.btn_iconoCobro.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_iconoCobro.Size = new System.Drawing.Size(228, 48);
            this.btn_iconoCobro.TabIndex = 7;
            this.btn_iconoCobro.Text = "Cobro";
            this.btn_iconoCobro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iconoCobro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_iconoCobro.UseVisualStyleBackColor = false;
            this.btn_iconoCobro.Click += new System.EventHandler(this.btn_iconoCobro_Click);
            // 
            // lbl_CerrarSesion
            // 
            this.lbl_CerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.btn_CerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(191, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelformulario
            // 
            this.panelformulario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelformulario.Controls.Add(this.pictureBox1);
            this.panelformulario.Location = new System.Drawing.Point(228, 32);
            this.panelformulario.Name = "panelformulario";
            this.panelformulario.Size = new System.Drawing.Size(773, 518);
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
        private System.Windows.Forms.Label lbl_CerrarSesion;
        private System.Windows.Forms.PictureBox btn_CerrarSesion;
        private System.Windows.Forms.Panel panelformulario;
        private FontAwesome.Sharp.IconButton btn_iconoCobro;
        private FontAwesome.Sharp.IconButton btn_iconoReportes;
        private FontAwesome.Sharp.IconButton btn_iconoNomina;
        private FontAwesome.Sharp.IconButton btn_iconoCorteCaja;
    }
}

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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_iconoCatalogo = new FontAwesome.Sharp.IconButton();
            this.btn_iconoGastos = new FontAwesome.Sharp.IconButton();
            this.btn_iconoCitas = new FontAwesome.Sharp.IconButton();
            this.btn_iconoReportes = new FontAwesome.Sharp.IconButton();
            this.btn_iconoNomina = new FontAwesome.Sharp.IconButton();
            this.btn_iconoCorteCaja = new FontAwesome.Sharp.IconButton();
            this.btn_iconoCobro = new FontAwesome.Sharp.IconButton();
            this.lbl_CerrarSesion = new System.Windows.Forms.Label();
            this.btn_CerrarSesion = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelformulario = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Barra_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restaurar)).BeginInit();
            this.Barra_Lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CerrarSesion)).BeginInit();
            this.panelformulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Barra_Titulo
            // 
            this.Barra_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(134)))));
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
            this.Barra_Lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.Barra_Lateral.Controls.Add(this.pictureBox2);
            this.Barra_Lateral.Controls.Add(this.btn_iconoCatalogo);
            this.Barra_Lateral.Controls.Add(this.btn_iconoGastos);
            this.Barra_Lateral.Controls.Add(this.btn_iconoCitas);
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
            this.Barra_Lateral.Size = new System.Drawing.Size(228, 628);
            this.Barra_Lateral.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WTFBarber.Properties.Resources.Logo2;
            this.pictureBox2.Location = new System.Drawing.Point(1, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btn_iconoCatalogo
            // 
            this.btn_iconoCatalogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_iconoCatalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.btn_iconoCatalogo.FlatAppearance.BorderSize = 0;
            this.btn_iconoCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iconoCatalogo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_iconoCatalogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(134)))));
            this.btn_iconoCatalogo.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btn_iconoCatalogo.IconColor = System.Drawing.Color.Chocolate;
            this.btn_iconoCatalogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_iconoCatalogo.IconSize = 40;
            this.btn_iconoCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iconoCatalogo.Location = new System.Drawing.Point(0, 462);
            this.btn_iconoCatalogo.Name = "btn_iconoCatalogo";
            this.btn_iconoCatalogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_iconoCatalogo.Size = new System.Drawing.Size(228, 48);
            this.btn_iconoCatalogo.TabIndex = 13;
            this.btn_iconoCatalogo.Text = "Catálogo";
            this.btn_iconoCatalogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_iconoCatalogo.UseVisualStyleBackColor = false;
            this.btn_iconoCatalogo.Click += new System.EventHandler(this.btn_iconoCatalogo_Click);
            // 
            // btn_iconoGastos
            // 
            this.btn_iconoGastos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_iconoGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.btn_iconoGastos.FlatAppearance.BorderSize = 0;
            this.btn_iconoGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iconoGastos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_iconoGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(134)))));
            this.btn_iconoGastos.IconChar = FontAwesome.Sharp.IconChar.CommentDollar;
            this.btn_iconoGastos.IconColor = System.Drawing.Color.Gray;
            this.btn_iconoGastos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_iconoGastos.IconSize = 40;
            this.btn_iconoGastos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iconoGastos.Location = new System.Drawing.Point(0, 354);
            this.btn_iconoGastos.Name = "btn_iconoGastos";
            this.btn_iconoGastos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_iconoGastos.Size = new System.Drawing.Size(228, 48);
            this.btn_iconoGastos.TabIndex = 12;
            this.btn_iconoGastos.Text = "Gastos";
            this.btn_iconoGastos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iconoGastos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_iconoGastos.UseVisualStyleBackColor = false;
            this.btn_iconoGastos.Click += new System.EventHandler(this.btn_iconoGastos_Click);
            // 
            // btn_iconoCitas
            // 
            this.btn_iconoCitas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_iconoCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.btn_iconoCitas.FlatAppearance.BorderSize = 0;
            this.btn_iconoCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iconoCitas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_iconoCitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(134)))));
            this.btn_iconoCitas.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btn_iconoCitas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btn_iconoCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_iconoCitas.IconSize = 40;
            this.btn_iconoCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iconoCitas.Location = new System.Drawing.Point(0, 192);
            this.btn_iconoCitas.Name = "btn_iconoCitas";
            this.btn_iconoCitas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_iconoCitas.Size = new System.Drawing.Size(228, 48);
            this.btn_iconoCitas.TabIndex = 11;
            this.btn_iconoCitas.Text = "Citas";
            this.btn_iconoCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iconoCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_iconoCitas.UseVisualStyleBackColor = false;
            this.btn_iconoCitas.Click += new System.EventHandler(this.btn_iconoCitas_Click);
            // 
            // btn_iconoReportes
            // 
            this.btn_iconoReportes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_iconoReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.btn_iconoReportes.FlatAppearance.BorderSize = 0;
            this.btn_iconoReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iconoReportes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_iconoReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(134)))));
            this.btn_iconoReportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btn_iconoReportes.IconColor = System.Drawing.Color.Red;
            this.btn_iconoReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_iconoReportes.IconSize = 40;
            this.btn_iconoReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iconoReportes.Location = new System.Drawing.Point(0, 408);
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
            this.btn_iconoNomina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.btn_iconoNomina.FlatAppearance.BorderSize = 0;
            this.btn_iconoNomina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iconoNomina.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_iconoNomina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(134)))));
            this.btn_iconoNomina.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.btn_iconoNomina.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(160)))), ((int)(((byte)(8)))));
            this.btn_iconoNomina.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_iconoNomina.IconSize = 40;
            this.btn_iconoNomina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iconoNomina.Location = new System.Drawing.Point(0, 300);
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
            this.btn_iconoCorteCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.btn_iconoCorteCaja.FlatAppearance.BorderSize = 0;
            this.btn_iconoCorteCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iconoCorteCaja.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_iconoCorteCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(134)))));
            this.btn_iconoCorteCaja.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btn_iconoCorteCaja.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.btn_iconoCorteCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_iconoCorteCaja.IconSize = 40;
            this.btn_iconoCorteCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iconoCorteCaja.Location = new System.Drawing.Point(0, 246);
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
            this.btn_iconoCobro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.btn_iconoCobro.FlatAppearance.BorderSize = 0;
            this.btn_iconoCobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iconoCobro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_iconoCobro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(134)))));
            this.btn_iconoCobro.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btn_iconoCobro.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(22)))), ((int)(((byte)(186)))));
            this.btn_iconoCobro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_iconoCobro.IconSize = 40;
            this.btn_iconoCobro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iconoCobro.Location = new System.Drawing.Point(0, 138);
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
            this.lbl_CerrarSesion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CerrarSesion.Location = new System.Drawing.Point(53, 581);
            this.lbl_CerrarSesion.Name = "lbl_CerrarSesion";
            this.lbl_CerrarSesion.Size = new System.Drawing.Size(86, 17);
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
            this.btn_CerrarSesion.Location = new System.Drawing.Point(12, 581);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(35, 35);
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
            // panelformulario
            // 
            this.panelformulario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelformulario.BackColor = System.Drawing.SystemColors.Window;
            this.panelformulario.Controls.Add(this.button2);
            this.panelformulario.Controls.Add(this.pictureBox1);
            this.panelformulario.Location = new System.Drawing.Point(228, 32);
            this.panelformulario.Name = "panelformulario";
            this.panelformulario.Size = new System.Drawing.Size(773, 628);
            this.panelformulario.TabIndex = 3;
            this.panelformulario.Paint += new System.Windows.Forms.PaintEventHandler(this.panelformulario_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WTFBarber.Properties.Resources.Logo_Rosa;
            this.pictureBox1.Location = new System.Drawing.Point(221, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WTFBarber.Properties.Resources.icons8_carro_favorito_48;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(87, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.panelformulario);
            this.Controls.Add(this.Barra_Lateral);
            this.Controls.Add(this.Barra_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Barra_Titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restaurar)).EndInit();
            this.Barra_Lateral.ResumeLayout(false);
            this.Barra_Lateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CerrarSesion)).EndInit();
            this.panelformulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Barra_Titulo;
        private System.Windows.Forms.PictureBox btn_Restaurar;
        private System.Windows.Forms.PictureBox bnt_Cerrar;
        private System.Windows.Forms.PictureBox btn_Minimizar;
        private System.Windows.Forms.Panel Barra_Lateral;
        private System.Windows.Forms.PictureBox btn_Maximizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_CerrarSesion;
        private System.Windows.Forms.PictureBox btn_CerrarSesion;
        private System.Windows.Forms.Panel panelformulario;
        private FontAwesome.Sharp.IconButton btn_iconoCobro;
        private FontAwesome.Sharp.IconButton btn_iconoReportes;
        private FontAwesome.Sharp.IconButton btn_iconoNomina;
        private FontAwesome.Sharp.IconButton btn_iconoCorteCaja;
        private FontAwesome.Sharp.IconButton btn_iconoGastos;
        private FontAwesome.Sharp.IconButton btn_iconoCitas;
        private FontAwesome.Sharp.IconButton btn_iconoCatalogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}
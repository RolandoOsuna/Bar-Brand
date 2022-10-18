
namespace WTFBarber
{
    partial class CorteCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorteCaja));
            this.lbl_CorteCaja = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.lbl_Ganancia = new System.Windows.Forms.Label();
            this.txt_Ganancia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TotalVentas = new System.Windows.Forms.TextBox();
            this.lbl_ProductosVendidos = new System.Windows.Forms.Label();
            this.txt_ProductosVendidos = new System.Windows.Forms.TextBox();
            this.lbl_Comisiones = new System.Windows.Forms.Label();
            this.txt_Comisiones = new System.Windows.Forms.TextBox();
            this.btn_MostrarDatos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CorteCaja
            // 
            this.lbl_CorteCaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CorteCaja.AutoSize = true;
            this.lbl_CorteCaja.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CorteCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.lbl_CorteCaja.Location = new System.Drawing.Point(261, 9);
            this.lbl_CorteCaja.Name = "lbl_CorteCaja";
            this.lbl_CorteCaja.Size = new System.Drawing.Size(295, 47);
            this.lbl_CorteCaja.TabIndex = 11;
            this.lbl_CorteCaja.Text = "Corte de Caja";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Cancelar.Font = new System.Drawing.Font("Caviar Dreams", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Red;
            this.btn_Cancelar.Location = new System.Drawing.Point(261, 377);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(118, 35);
            this.btn_Cancelar.TabIndex = 21;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Aceptar.Font = new System.Drawing.Font("Caviar Dreams", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Aceptar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Aceptar.Location = new System.Drawing.Point(385, 377);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(118, 35);
            this.btn_Aceptar.TabIndex = 20;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click_1);
            // 
            // lbl_Ganancia
            // 
            this.lbl_Ganancia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Ganancia.AutoSize = true;
            this.lbl_Ganancia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ganancia.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Ganancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.lbl_Ganancia.Location = new System.Drawing.Point(25, 271);
            this.lbl_Ganancia.Name = "lbl_Ganancia";
            this.lbl_Ganancia.Size = new System.Drawing.Size(116, 25);
            this.lbl_Ganancia.TabIndex = 15;
            this.lbl_Ganancia.Text = "Ganancia";
            // 
            // txt_Ganancia
            // 
            this.txt_Ganancia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Ganancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.txt_Ganancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Ganancia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Ganancia.Enabled = false;
            this.txt_Ganancia.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Ganancia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Ganancia.Location = new System.Drawing.Point(25, 297);
            this.txt_Ganancia.Name = "txt_Ganancia";
            this.txt_Ganancia.PlaceholderText = "$";
            this.txt_Ganancia.Size = new System.Drawing.Size(200, 26);
            this.txt_Ganancia.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(25, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Total de Ventas";
            // 
            // txt_TotalVentas
            // 
            this.txt_TotalVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TotalVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.txt_TotalVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TotalVentas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TotalVentas.Enabled = false;
            this.txt_TotalVentas.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TotalVentas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_TotalVentas.Location = new System.Drawing.Point(25, 226);
            this.txt_TotalVentas.Name = "txt_TotalVentas";
            this.txt_TotalVentas.PlaceholderText = "$";
            this.txt_TotalVentas.Size = new System.Drawing.Size(200, 26);
            this.txt_TotalVentas.TabIndex = 22;
            // 
            // lbl_ProductosVendidos
            // 
            this.lbl_ProductosVendidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ProductosVendidos.AutoSize = true;
            this.lbl_ProductosVendidos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ProductosVendidos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ProductosVendidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.lbl_ProductosVendidos.Location = new System.Drawing.Point(20, 133);
            this.lbl_ProductosVendidos.Name = "lbl_ProductosVendidos";
            this.lbl_ProductosVendidos.Size = new System.Drawing.Size(214, 25);
            this.lbl_ProductosVendidos.TabIndex = 25;
            this.lbl_ProductosVendidos.Text = "Productos Vendidos";
            // 
            // txt_ProductosVendidos
            // 
            this.txt_ProductosVendidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ProductosVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.txt_ProductosVendidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProductosVendidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ProductosVendidos.Enabled = false;
            this.txt_ProductosVendidos.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ProductosVendidos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ProductosVendidos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_ProductosVendidos.Location = new System.Drawing.Point(25, 159);
            this.txt_ProductosVendidos.Name = "txt_ProductosVendidos";
            this.txt_ProductosVendidos.Size = new System.Drawing.Size(200, 26);
            this.txt_ProductosVendidos.TabIndex = 24;
            // 
            // lbl_Comisiones
            // 
            this.lbl_Comisiones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Comisiones.AutoSize = true;
            this.lbl_Comisiones.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Comisiones.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Comisiones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.lbl_Comisiones.Location = new System.Drawing.Point(511, 315);
            this.lbl_Comisiones.Name = "lbl_Comisiones";
            this.lbl_Comisiones.Size = new System.Drawing.Size(128, 25);
            this.lbl_Comisiones.TabIndex = 27;
            this.lbl_Comisiones.Text = "Comisiones";
            // 
            // txt_Comisiones
            // 
            this.txt_Comisiones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Comisiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.txt_Comisiones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Comisiones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Comisiones.Enabled = false;
            this.txt_Comisiones.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Comisiones.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Comisiones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Comisiones.Location = new System.Drawing.Point(511, 341);
            this.txt_Comisiones.Name = "txt_Comisiones";
            this.txt_Comisiones.PlaceholderText = "%";
            this.txt_Comisiones.Size = new System.Drawing.Size(200, 26);
            this.txt_Comisiones.TabIndex = 26;
            // 
            // btn_MostrarDatos
            // 
            this.btn_MostrarDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_MostrarDatos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_MostrarDatos.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_MostrarDatos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_MostrarDatos.Location = new System.Drawing.Point(342, 82);
            this.btn_MostrarDatos.Name = "btn_MostrarDatos";
            this.btn_MostrarDatos.Size = new System.Drawing.Size(118, 40);
            this.btn_MostrarDatos.TabIndex = 28;
            this.btn_MostrarDatos.Text = "Mostrar Datos";
            this.btn_MostrarDatos.UseVisualStyleBackColor = true;
            this.btn_MostrarDatos.Click += new System.EventHandler(this.btn_MostrarDatos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WTFBarber.Properties.Resources.Logo_Bar_Brand;
            this.pictureBox1.Location = new System.Drawing.Point(12, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Imprimir.Font = new System.Drawing.Font("Caviar Dreams", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Imprimir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Imprimir.Location = new System.Drawing.Point(342, 418);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(90, 35);
            this.btn_Imprimir.TabIndex = 36;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // dgv
            // 
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(239, 133);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(497, 166);
            this.dgv.TabIndex = 37;
            // 
            // dtp
            // 
            this.dtp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtp.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtp.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtp.Checked = false;
            this.dtp.CustomFormat = "dd/MM/yyyy";
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(36, 82);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(90, 23);
            this.dtp.TabIndex = 38;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 386);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(593, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(176, 152);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // CorteCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_MostrarDatos);
            this.Controls.Add(this.txt_Ganancia);
            this.Controls.Add(this.lbl_Comisiones);
            this.Controls.Add(this.txt_Comisiones);
            this.Controls.Add(this.lbl_ProductosVendidos);
            this.Controls.Add(this.txt_ProductosVendidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TotalVentas);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lbl_Ganancia);
            this.Controls.Add(this.lbl_CorteCaja);
            this.Name = "CorteCaja";
            this.Text = "CorteCaja";
            this.Load += new System.EventHandler(this.CorteCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CorteCaja;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label lbl_Ganancia;
        private System.Windows.Forms.TextBox txt_Ganancia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TotalVentas;
        private System.Windows.Forms.Label lbl_ProductosVendidos;
        private System.Windows.Forms.TextBox txt_ProductosVendidos;
        private System.Windows.Forms.Label lbl_Comisiones;
        private System.Windows.Forms.TextBox txt_Comisiones;
        private System.Windows.Forms.Button btn_MostrarDatos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
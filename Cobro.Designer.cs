﻿
namespace WTFBarber
{
    partial class Cobro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cobro));
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.lbl_Empleado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cobrar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_Cobro = new System.Windows.Forms.Label();
            this.cmb_Producto = new System.Windows.Forms.ComboBox();
            this.cmb_Empleado = new System.Windows.Forms.ComboBox();
            this.txt_Comision = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Producto.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.lbl_Producto.Location = new System.Drawing.Point(166, 156);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(82, 19);
            this.lbl_Producto.TabIndex = 1;
            this.lbl_Producto.Text = "Producto";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Precio.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Precio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.lbl_Precio.Location = new System.Drawing.Point(454, 157);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(61, 19);
            this.lbl_Precio.TabIndex = 3;
            this.lbl_Precio.Text = "Precio";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.txt_Precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Precio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Precio.Enabled = false;
            this.txt_Precio.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Precio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Precio.Location = new System.Drawing.Point(454, 183);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.PlaceholderText = "$";
            this.txt_Precio.ShortcutsEnabled = false;
            this.txt_Precio.Size = new System.Drawing.Size(200, 26);
            this.txt_Precio.TabIndex = 2;
            this.txt_Precio.TextChanged += new System.EventHandler(this.txt_Precio_TextChanged);
            this.txt_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Precio_KeyPress);
            // 
            // lbl_Empleado
            // 
            this.lbl_Empleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Empleado.AutoSize = true;
            this.lbl_Empleado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Empleado.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Empleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.lbl_Empleado.Location = new System.Drawing.Point(166, 268);
            this.lbl_Empleado.Name = "lbl_Empleado";
            this.lbl_Empleado.Size = new System.Drawing.Size(93, 19);
            this.lbl_Empleado.TabIndex = 5;
            this.lbl_Empleado.Text = "Empleado";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.label3.Location = new System.Drawing.Point(454, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Comisión";
            // 
            // btn_Cobrar
            // 
            this.btn_Cobrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cobrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Cobrar.Font = new System.Drawing.Font("Caviar Dreams", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cobrar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Cobrar.Location = new System.Drawing.Point(429, 415);
            this.btn_Cobrar.Name = "btn_Cobrar";
            this.btn_Cobrar.Size = new System.Drawing.Size(145, 35);
            this.btn_Cobrar.TabIndex = 8;
            this.btn_Cobrar.Text = "Cobrar";
            this.btn_Cobrar.UseVisualStyleBackColor = true;
            this.btn_Cobrar.Click += new System.EventHandler(this.btn_Cobrar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Cancelar.Font = new System.Drawing.Font("Caviar Dreams", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Red;
            this.btn_Cancelar.Location = new System.Drawing.Point(221, 415);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(145, 35);
            this.btn_Cancelar.TabIndex = 9;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click_1);
            // 
            // lbl_Cobro
            // 
            this.lbl_Cobro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Cobro.AutoSize = true;
            this.lbl_Cobro.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cobro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.lbl_Cobro.Location = new System.Drawing.Point(345, 41);
            this.lbl_Cobro.Name = "lbl_Cobro";
            this.lbl_Cobro.Size = new System.Drawing.Size(170, 56);
            this.lbl_Cobro.TabIndex = 10;
            this.lbl_Cobro.Text = "Cobro";
            // 
            // cmb_Producto
            // 
            this.cmb_Producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.cmb_Producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Producto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Producto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_Producto.FormattingEnabled = true;
            this.cmb_Producto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_Producto.Items.AddRange(new object[] {
            "Corte de Cabello",
            "Corte de Niño",
            "Barba Completa",
            "Barba Media",
            "Tinte de Cabello",
            "Tinte de Barba",
            "Perfilado de Ceja",
            "Mascarilla Negra",
            "Facial Exfoliante",
            "Facial Hidratante",
            "Paquete Premium",
            "Paquete Elite"});
            this.cmb_Producto.Location = new System.Drawing.Point(166, 182);
            this.cmb_Producto.Name = "cmb_Producto";
            this.cmb_Producto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_Producto.Size = new System.Drawing.Size(200, 27);
            this.cmb_Producto.TabIndex = 11;
            this.cmb_Producto.SelectedIndexChanged += new System.EventHandler(this.cmb_Producto_SelectedIndexChanged);
            // 
            // cmb_Empleado
            // 
            this.cmb_Empleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.cmb_Empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Empleado.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Empleado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_Empleado.FormattingEnabled = true;
            this.cmb_Empleado.Items.AddRange(new object[] {
            "Saul",
            "Eduardo",
            "Jazmin",
            "Hadamari"});
            this.cmb_Empleado.Location = new System.Drawing.Point(166, 294);
            this.cmb_Empleado.Name = "cmb_Empleado";
            this.cmb_Empleado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_Empleado.Size = new System.Drawing.Size(200, 27);
            this.cmb_Empleado.TabIndex = 12;
            this.cmb_Empleado.SelectedIndexChanged += new System.EventHandler(this.cmb_Empleado_SelectedIndexChanged);
            // 
            // txt_Comision
            // 
            this.txt_Comision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Comision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.txt_Comision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Comision.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Comision.Enabled = false;
            this.txt_Comision.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Comision.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Comision.Location = new System.Drawing.Point(454, 295);
            this.txt_Comision.Name = "txt_Comision";
            this.txt_Comision.PlaceholderText = "%";
            this.txt_Comision.Size = new System.Drawing.Size(200, 26);
            this.txt_Comision.TabIndex = 15;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // lbl
            // 
            this.lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(654, 391);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 19);
            this.lbl.TabIndex = 33;
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 365);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::WTFBarber.Properties.Resources.Logo_Bar_Brand;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(590, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(176, 152);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // Cobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txt_Comision);
            this.Controls.Add(this.cmb_Empleado);
            this.Controls.Add(this.cmb_Producto);
            this.Controls.Add(this.lbl_Cobro);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Cobrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Empleado);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.lbl_Producto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Cobro";
            this.Text = "Prueba";
            this.Load += new System.EventHandler(this.Cobro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label lbl_Empleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cobrar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_Cobro;
        private System.Windows.Forms.ComboBox cmb_Producto;
        private System.Windows.Forms.ComboBox cmb_Empleado;
        private System.Windows.Forms.TextBox txt_Comision;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
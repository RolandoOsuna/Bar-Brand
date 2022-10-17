
namespace WTFBarber
{
    partial class Catalogo_Ventas
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
            this.dgv_CatalogoVentas = new System.Windows.Forms.DataGridView();
            this.dtp_CatalogoVentasDesde = new System.Windows.Forms.DateTimePicker();
            this.btn_MostrarDatos = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.dtp_CatalogoVentasHasta = new System.Windows.Forms.DateTimePicker();
            this.lbl_Hasta = new System.Windows.Forms.Label();
            this.lbl_Desde = new System.Windows.Forms.Label();
            this.txt_Comision = new System.Windows.Forms.TextBox();
            this.cmb_Empleado = new System.Windows.Forms.ComboBox();
            this.cmb_Producto = new System.Windows.Forms.ComboBox();
            this.lbl_Comision = new System.Windows.Forms.Label();
            this.lbl_Empleado = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.btn_CancelarModificacion = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.lbl_Catalogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CatalogoVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_CatalogoVentas
            // 
            this.dgv_CatalogoVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_CatalogoVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(204)))), ((int)(((byte)(168)))));
            this.dgv_CatalogoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CatalogoVentas.Location = new System.Drawing.Point(76, 160);
            this.dgv_CatalogoVentas.MultiSelect = false;
            this.dgv_CatalogoVentas.Name = "dgv_CatalogoVentas";
            this.dgv_CatalogoVentas.ReadOnly = true;
            this.dgv_CatalogoVentas.RowTemplate.Height = 25;
            this.dgv_CatalogoVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CatalogoVentas.Size = new System.Drawing.Size(551, 173);
            this.dgv_CatalogoVentas.TabIndex = 0;
            // 
            // dtp_CatalogoVentasDesde
            // 
            this.dtp_CatalogoVentasDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_CatalogoVentasDesde.CustomFormat = "dd/MM/yyyy HH:MM";
            this.dtp_CatalogoVentasDesde.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_CatalogoVentasDesde.Location = new System.Drawing.Point(76, 54);
            this.dtp_CatalogoVentasDesde.Name = "dtp_CatalogoVentasDesde";
            this.dtp_CatalogoVentasDesde.Size = new System.Drawing.Size(120, 23);
            this.dtp_CatalogoVentasDesde.TabIndex = 1;
            this.dtp_CatalogoVentasDesde.Value = new System.DateTime(2022, 8, 10, 21, 21, 54, 0);
            this.dtp_CatalogoVentasDesde.ValueChanged += new System.EventHandler(this.dtp_CatalogoVentas_ValueChanged);
            // 
            // btn_MostrarDatos
            // 
            this.btn_MostrarDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_MostrarDatos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_MostrarDatos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MostrarDatos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_MostrarDatos.Location = new System.Drawing.Point(12, 112);
            this.btn_MostrarDatos.Name = "btn_MostrarDatos";
            this.btn_MostrarDatos.Size = new System.Drawing.Size(98, 27);
            this.btn_MostrarDatos.TabIndex = 32;
            this.btn_MostrarDatos.Text = "Mostrar Datos";
            this.btn_MostrarDatos.UseVisualStyleBackColor = true;
            this.btn_MostrarDatos.Click += new System.EventHandler(this.btn_MostrarDatos_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Modificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Modificar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Modificar.Location = new System.Drawing.Point(214, 339);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(118, 27);
            this.btn_Modificar.TabIndex = 33;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Cancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Cancelar.Location = new System.Drawing.Point(78, 339);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(118, 27);
            this.btn_Cancelar.TabIndex = 34;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // dtp_CatalogoVentasHasta
            // 
            this.dtp_CatalogoVentasHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_CatalogoVentasHasta.CustomFormat = "dd/MM/yyyy HH:MM";
            this.dtp_CatalogoVentasHasta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_CatalogoVentasHasta.Location = new System.Drawing.Point(76, 83);
            this.dtp_CatalogoVentasHasta.Name = "dtp_CatalogoVentasHasta";
            this.dtp_CatalogoVentasHasta.Size = new System.Drawing.Size(120, 23);
            this.dtp_CatalogoVentasHasta.TabIndex = 35;
            this.dtp_CatalogoVentasHasta.Value = new System.DateTime(2022, 8, 10, 21, 21, 54, 0);
            // 
            // lbl_Hasta
            // 
            this.lbl_Hasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Hasta.AutoSize = true;
            this.lbl_Hasta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hasta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Hasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.lbl_Hasta.Location = new System.Drawing.Point(17, 85);
            this.lbl_Hasta.Name = "lbl_Hasta";
            this.lbl_Hasta.Size = new System.Drawing.Size(52, 19);
            this.lbl_Hasta.TabIndex = 37;
            this.lbl_Hasta.Text = "Hasta";
            // 
            // lbl_Desde
            // 
            this.lbl_Desde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Desde.AutoSize = true;
            this.lbl_Desde.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Desde.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Desde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.lbl_Desde.Location = new System.Drawing.Point(17, 58);
            this.lbl_Desde.Name = "lbl_Desde";
            this.lbl_Desde.Size = new System.Drawing.Size(57, 19);
            this.lbl_Desde.TabIndex = 36;
            this.lbl_Desde.Text = "Desde";
            // 
            // txt_Comision
            // 
            this.txt_Comision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Comision.BackColor = System.Drawing.Color.White;
            this.txt_Comision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Comision.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Comision.Enabled = false;
            this.txt_Comision.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Comision.ForeColor = System.Drawing.Color.Black;
            this.txt_Comision.Location = new System.Drawing.Point(435, 125);
            this.txt_Comision.Name = "txt_Comision";
            this.txt_Comision.PlaceholderText = "%";
            this.txt_Comision.Size = new System.Drawing.Size(150, 24);
            this.txt_Comision.TabIndex = 45;
            // 
            // cmb_Empleado
            // 
            this.cmb_Empleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Empleado.BackColor = System.Drawing.Color.White;
            this.cmb_Empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Empleado.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Empleado.ForeColor = System.Drawing.Color.Black;
            this.cmb_Empleado.FormattingEnabled = true;
            this.cmb_Empleado.Items.AddRange(new object[] {
            "Saul",
            "Eduardo",
            "Jazmin",
            "Hadamari"});
            this.cmb_Empleado.Location = new System.Drawing.Point(279, 124);
            this.cmb_Empleado.Name = "cmb_Empleado";
            this.cmb_Empleado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_Empleado.Size = new System.Drawing.Size(150, 25);
            this.cmb_Empleado.TabIndex = 44;
            this.cmb_Empleado.SelectedIndexChanged += new System.EventHandler(this.cmb_Empleado_SelectedIndexChanged_1);
            // 
            // cmb_Producto
            // 
            this.cmb_Producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Producto.BackColor = System.Drawing.Color.White;
            this.cmb_Producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Producto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Producto.ForeColor = System.Drawing.Color.Black;
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
            this.cmb_Producto.Location = new System.Drawing.Point(279, 77);
            this.cmb_Producto.Name = "cmb_Producto";
            this.cmb_Producto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_Producto.Size = new System.Drawing.Size(150, 25);
            this.cmb_Producto.TabIndex = 43;
            this.cmb_Producto.SelectedIndexChanged += new System.EventHandler(this.cmb_Producto_SelectedIndexChanged_1);
            // 
            // lbl_Comision
            // 
            this.lbl_Comision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Comision.AutoSize = true;
            this.lbl_Comision.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Comision.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Comision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.lbl_Comision.Location = new System.Drawing.Point(435, 103);
            this.lbl_Comision.Name = "lbl_Comision";
            this.lbl_Comision.Size = new System.Drawing.Size(81, 19);
            this.lbl_Comision.TabIndex = 42;
            this.lbl_Comision.Text = "Comisión";
            // 
            // lbl_Empleado
            // 
            this.lbl_Empleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Empleado.AutoSize = true;
            this.lbl_Empleado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Empleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.lbl_Empleado.Location = new System.Drawing.Point(279, 105);
            this.lbl_Empleado.Name = "lbl_Empleado";
            this.lbl_Empleado.Size = new System.Drawing.Size(90, 19);
            this.lbl_Empleado.TabIndex = 41;
            this.lbl_Empleado.Text = "Empleado";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Precio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Precio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.lbl_Precio.Location = new System.Drawing.Point(440, 55);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(57, 19);
            this.lbl_Precio.TabIndex = 40;
            this.lbl_Precio.Text = "Precio";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Precio.BackColor = System.Drawing.Color.White;
            this.txt_Precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Precio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Precio.Enabled = false;
            this.txt_Precio.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Precio.ForeColor = System.Drawing.Color.Black;
            this.txt_Precio.Location = new System.Drawing.Point(435, 77);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.PlaceholderText = "$";
            this.txt_Precio.ShortcutsEnabled = false;
            this.txt_Precio.Size = new System.Drawing.Size(150, 24);
            this.txt_Precio.TabIndex = 39;
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.lbl_Producto.Location = new System.Drawing.Point(279, 55);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(78, 19);
            this.lbl_Producto.TabIndex = 38;
            this.lbl_Producto.Text = "Producto";
            // 
            // btn_CancelarModificacion
            // 
            this.btn_CancelarModificacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CancelarModificacion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_CancelarModificacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CancelarModificacion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_CancelarModificacion.Location = new System.Drawing.Point(596, 74);
            this.btn_CancelarModificacion.Name = "btn_CancelarModificacion";
            this.btn_CancelarModificacion.Size = new System.Drawing.Size(106, 44);
            this.btn_CancelarModificacion.TabIndex = 46;
            this.btn_CancelarModificacion.Text = "Cancelar Modificacion";
            this.btn_CancelarModificacion.UseVisualStyleBackColor = true;
            this.btn_CancelarModificacion.Click += new System.EventHandler(this.btn_CancelarModificacion_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Guardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Guardar.Location = new System.Drawing.Point(613, 124);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(73, 30);
            this.btn_Guardar.TabIndex = 47;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lbl_Catalogo
            // 
            this.lbl_Catalogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Catalogo.AutoSize = true;
            this.lbl_Catalogo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Catalogo.ForeColor = System.Drawing.Color.White;
            this.lbl_Catalogo.Location = new System.Drawing.Point(179, 9);
            this.lbl_Catalogo.Name = "lbl_Catalogo";
            this.lbl_Catalogo.Size = new System.Drawing.Size(357, 41);
            this.lbl_Catalogo.TabIndex = 48;
            this.lbl_Catalogo.Text = "Catálogo de Ventas";
            // 
            // Catalogo_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(714, 374);
            this.Controls.Add(this.lbl_Catalogo);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_CancelarModificacion);
            this.Controls.Add(this.txt_Comision);
            this.Controls.Add(this.cmb_Empleado);
            this.Controls.Add(this.cmb_Producto);
            this.Controls.Add(this.lbl_Comision);
            this.Controls.Add(this.lbl_Empleado);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.lbl_Producto);
            this.Controls.Add(this.lbl_Hasta);
            this.Controls.Add(this.lbl_Desde);
            this.Controls.Add(this.dtp_CatalogoVentasHasta);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_MostrarDatos);
            this.Controls.Add(this.dtp_CatalogoVentasDesde);
            this.Controls.Add(this.dgv_CatalogoVentas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Catalogo_Ventas";
            this.Text = "Catalogo_Ventas";
            this.Load += new System.EventHandler(this.Catalogo_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CatalogoVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_CatalogoVentas;
        private System.Windows.Forms.DateTimePicker dtp_CatalogoVentasDesde;
        private System.Windows.Forms.Button btn_MostrarDatos;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DateTimePicker dtp_CatalogoVentasHasta;
        private System.Windows.Forms.Label lbl_Hasta;
        private System.Windows.Forms.Label lbl_Desde;
        private System.Windows.Forms.TextBox txt_Comision;
        private System.Windows.Forms.ComboBox cmb_Empleado;
        private System.Windows.Forms.ComboBox cmb_Producto;
        private System.Windows.Forms.Label lbl_Comision;
        private System.Windows.Forms.Label lbl_Empleado;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.Button btn_CancelarModificacion;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label lbl_Catalogo;
    }
}

namespace WTFBarber
{
    partial class Catalogo_Gastos
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
            this.lbl_Catalogo = new System.Windows.Forms.Label();
            this.lbl_Hasta = new System.Windows.Forms.Label();
            this.lbl_Desde = new System.Windows.Forms.Label();
            this.dtp_CatalogoGastosHasta = new System.Windows.Forms.DateTimePicker();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_MostrarDatos = new System.Windows.Forms.Button();
            this.dtp_CatalogoGastosDesde = new System.Windows.Forms.DateTimePicker();
            this.dgv_CatalogoGastos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CatalogoGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Catalogo
            // 
            this.lbl_Catalogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Catalogo.AutoSize = true;
<<<<<<< HEAD
            this.lbl_Catalogo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Catalogo.ForeColor = System.Drawing.Color.White;
            this.lbl_Catalogo.Location = new System.Drawing.Point(214, 9);
=======
            this.lbl_Catalogo.Font = new System.Drawing.Font("Perpetua Titling MT", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Catalogo.Location = new System.Drawing.Point(127, 9);
>>>>>>> parent of 4824c6f (Catalogo Venta-Usuarios-Gastos Terminado)
            this.lbl_Catalogo.Name = "lbl_Catalogo";
            this.lbl_Catalogo.Size = new System.Drawing.Size(355, 41);
            this.lbl_Catalogo.TabIndex = 49;
            this.lbl_Catalogo.Text = "Catálogo de Gastos";
            // 
            // lbl_Hasta
            // 
            this.lbl_Hasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Hasta.AutoSize = true;
            this.lbl_Hasta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hasta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
<<<<<<< HEAD
            this.lbl_Hasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.lbl_Hasta.Location = new System.Drawing.Point(10, 100);
=======
            this.lbl_Hasta.Location = new System.Drawing.Point(218, 58);
>>>>>>> parent of 4824c6f (Catalogo Venta-Usuarios-Gastos Terminado)
            this.lbl_Hasta.Name = "lbl_Hasta";
            this.lbl_Hasta.Size = new System.Drawing.Size(52, 19);
            this.lbl_Hasta.TabIndex = 56;
            this.lbl_Hasta.Text = "Hasta";
            this.lbl_Hasta.Click += new System.EventHandler(this.lbl_Hasta_Click);
            // 
            // lbl_Desde
            // 
            this.lbl_Desde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Desde.AutoSize = true;
            this.lbl_Desde.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Desde.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
<<<<<<< HEAD
            this.lbl_Desde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.lbl_Desde.Location = new System.Drawing.Point(10, 73);
=======
            this.lbl_Desde.Location = new System.Drawing.Point(22, 58);
>>>>>>> parent of 4824c6f (Catalogo Venta-Usuarios-Gastos Terminado)
            this.lbl_Desde.Name = "lbl_Desde";
            this.lbl_Desde.Size = new System.Drawing.Size(57, 19);
            this.lbl_Desde.TabIndex = 55;
            this.lbl_Desde.Text = "Desde";
            this.lbl_Desde.Click += new System.EventHandler(this.lbl_Desde_Click);
            // 
            // dtp_CatalogoGastosHasta
            // 
            this.dtp_CatalogoGastosHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_CatalogoGastosHasta.CustomFormat = "dd/MM/yyyy HH:MM";
            this.dtp_CatalogoGastosHasta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_CatalogoGastosHasta.Location = new System.Drawing.Point(277, 56);
            this.dtp_CatalogoGastosHasta.Name = "dtp_CatalogoGastosHasta";
            this.dtp_CatalogoGastosHasta.Size = new System.Drawing.Size(120, 23);
            this.dtp_CatalogoGastosHasta.TabIndex = 54;
            this.dtp_CatalogoGastosHasta.Value = new System.DateTime(2022, 8, 10, 21, 21, 54, 0);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Cancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Cancelar.Location = new System.Drawing.Point(43, 330);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(118, 27);
            this.btn_Cancelar.TabIndex = 53;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_MostrarDatos
            // 
            this.btn_MostrarDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_MostrarDatos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_MostrarDatos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MostrarDatos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_MostrarDatos.Location = new System.Drawing.Point(30, 93);
            this.btn_MostrarDatos.Name = "btn_MostrarDatos";
            this.btn_MostrarDatos.Size = new System.Drawing.Size(98, 27);
            this.btn_MostrarDatos.TabIndex = 52;
            this.btn_MostrarDatos.Text = "Mostrar Datos";
            this.btn_MostrarDatos.UseVisualStyleBackColor = true;
            this.btn_MostrarDatos.Click += new System.EventHandler(this.btn_MostrarDatos_Click);
            // 
            // dtp_CatalogoGastosDesde
            // 
            this.dtp_CatalogoGastosDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_CatalogoGastosDesde.CustomFormat = "dd/MM/yyyy HH:MM";
            this.dtp_CatalogoGastosDesde.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_CatalogoGastosDesde.Location = new System.Drawing.Point(81, 54);
            this.dtp_CatalogoGastosDesde.Name = "dtp_CatalogoGastosDesde";
            this.dtp_CatalogoGastosDesde.Size = new System.Drawing.Size(120, 23);
            this.dtp_CatalogoGastosDesde.TabIndex = 51;
            this.dtp_CatalogoGastosDesde.Value = new System.DateTime(2022, 8, 10, 21, 21, 54, 0);
            // 
            // dgv_CatalogoGastos
            // 
            this.dgv_CatalogoGastos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_CatalogoGastos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(204)))), ((int)(((byte)(168)))));
            this.dgv_CatalogoGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CatalogoGastos.Location = new System.Drawing.Point(43, 141);
            this.dgv_CatalogoGastos.MultiSelect = false;
            this.dgv_CatalogoGastos.Name = "dgv_CatalogoGastos";
            this.dgv_CatalogoGastos.ReadOnly = true;
            this.dgv_CatalogoGastos.RowTemplate.Height = 25;
            this.dgv_CatalogoGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CatalogoGastos.Size = new System.Drawing.Size(551, 173);
            this.dgv_CatalogoGastos.TabIndex = 50;
            // 
<<<<<<< HEAD
            // btn_CancelarModificacion
            // 
            this.btn_CancelarModificacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CancelarModificacion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_CancelarModificacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CancelarModificacion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_CancelarModificacion.Location = new System.Drawing.Point(642, 193);
            this.btn_CancelarModificacion.Name = "btn_CancelarModificacion";
            this.btn_CancelarModificacion.Size = new System.Drawing.Size(92, 39);
            this.btn_CancelarModificacion.TabIndex = 82;
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
            this.btn_Guardar.Location = new System.Drawing.Point(649, 160);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(85, 27);
            this.btn_Guardar.TabIndex = 81;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(598, 50);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(153, 89);
            this.txt_Descripcion.TabIndex = 79;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(361, 50);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(130, 23);
            this.txt_Nombre.TabIndex = 78;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.lbl_Descripcion.Location = new System.Drawing.Point(503, 50);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(97, 18);
            this.lbl_Descripcion.TabIndex = 77;
            this.lbl_Descripcion.Text = "Descripcion";
            this.lbl_Descripcion.Click += new System.EventHandler(this.lbl_Descripcion_Click);
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.lbl_Cantidad.Location = new System.Drawing.Point(278, 87);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(77, 18);
            this.lbl_Cantidad.TabIndex = 76;
            this.lbl_Cantidad.Text = "Cantidad";
            this.lbl_Cantidad.Click += new System.EventHandler(this.lbl_Cantidad_Click);
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.lbl_Nombre.Location = new System.Drawing.Point(287, 56);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(68, 18);
            this.lbl_Nombre.TabIndex = 75;
            this.lbl_Nombre.Text = "Nombre";
            this.lbl_Nombre.Click += new System.EventHandler(this.lbl_Nombre_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Modificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Modificar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Modificar.Location = new System.Drawing.Point(196, 380);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(118, 27);
            this.btn_Modificar.TabIndex = 83;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(361, 87);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(130, 23);
            this.txt_Cantidad.TabIndex = 84;
            this.txt_Cantidad.TextChanged += new System.EventHandler(this.txt_Cantidad_TextChanged);
            this.txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cantidad_KeyPress);
            // 
=======
>>>>>>> parent of 4824c6f (Catalogo Venta-Usuarios-Gastos Terminado)
            // Catalogo_Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(763, 412);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_CancelarModificacion);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.lbl_Nombre);
=======
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(714, 374);
>>>>>>> parent of 4824c6f (Catalogo Venta-Usuarios-Gastos Terminado)
            this.Controls.Add(this.lbl_Hasta);
            this.Controls.Add(this.lbl_Desde);
            this.Controls.Add(this.dtp_CatalogoGastosHasta);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_MostrarDatos);
            this.Controls.Add(this.dtp_CatalogoGastosDesde);
            this.Controls.Add(this.dgv_CatalogoGastos);
            this.Controls.Add(this.lbl_Catalogo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Catalogo_Gastos";
            this.Text = "Catalogo_Gastos";
            this.Load += new System.EventHandler(this.Catalogo_Gastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CatalogoGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Catalogo;
        private System.Windows.Forms.Label lbl_Hasta;
        private System.Windows.Forms.Label lbl_Desde;
        private System.Windows.Forms.DateTimePicker dtp_CatalogoGastosHasta;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_MostrarDatos;
        private System.Windows.Forms.DateTimePicker dtp_CatalogoGastosDesde;
        private System.Windows.Forms.DataGridView dgv_CatalogoGastos;
    }
}
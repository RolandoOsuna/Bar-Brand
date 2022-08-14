
namespace WTFBarber
{
    partial class Catalogo_Usuarios
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
            this.dtp_CatalogoHasta = new System.Windows.Forms.DateTimePicker();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_MostrarDatos = new System.Windows.Forms.Button();
            this.dtp_CatalogoDesde = new System.Windows.Forms.DateTimePicker();
            this.dgv_CatalogoUsuarios = new System.Windows.Forms.DataGridView();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Privilegio = new System.Windows.Forms.Label();
            this.lbl_Contra = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Contra = new System.Windows.Forms.TextBox();
            this.cmb_Privilegio = new System.Windows.Forms.ComboBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_CancelarModificacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CatalogoUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Catalogo
            // 
            this.lbl_Catalogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Catalogo.AutoSize = true;
            this.lbl_Catalogo.Font = new System.Drawing.Font("Perpetua Titling MT", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Catalogo.Location = new System.Drawing.Point(113, 9);
            this.lbl_Catalogo.Name = "lbl_Catalogo";
            this.lbl_Catalogo.Size = new System.Drawing.Size(498, 42);
            this.lbl_Catalogo.TabIndex = 49;
            this.lbl_Catalogo.Text = "Catálogo de Usuarios";
            // 
            // lbl_Hasta
            // 
            this.lbl_Hasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Hasta.AutoSize = true;
            this.lbl_Hasta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Hasta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Hasta.Location = new System.Drawing.Point(13, 88);
            this.lbl_Hasta.Name = "lbl_Hasta";
            this.lbl_Hasta.Size = new System.Drawing.Size(52, 19);
            this.lbl_Hasta.TabIndex = 63;
            this.lbl_Hasta.Text = "Hasta";
            // 
            // lbl_Desde
            // 
            this.lbl_Desde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Desde.AutoSize = true;
            this.lbl_Desde.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Desde.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Desde.Location = new System.Drawing.Point(8, 56);
            this.lbl_Desde.Name = "lbl_Desde";
            this.lbl_Desde.Size = new System.Drawing.Size(57, 19);
            this.lbl_Desde.TabIndex = 62;
            this.lbl_Desde.Text = "Desde";
            // 
            // dtp_CatalogoHasta
            // 
            this.dtp_CatalogoHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_CatalogoHasta.CustomFormat = "dd/MM/yyyy HH:MM";
            this.dtp_CatalogoHasta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_CatalogoHasta.Location = new System.Drawing.Point(71, 86);
            this.dtp_CatalogoHasta.Name = "dtp_CatalogoHasta";
            this.dtp_CatalogoHasta.Size = new System.Drawing.Size(120, 23);
            this.dtp_CatalogoHasta.TabIndex = 61;
            this.dtp_CatalogoHasta.Value = new System.DateTime(2022, 8, 10, 21, 21, 54, 0);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Cancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Cancelar.Location = new System.Drawing.Point(289, 339);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(118, 27);
            this.btn_Cancelar.TabIndex = 60;
            this.btn_Cancelar.Text = "Eliminar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_MostrarDatos
            // 
            this.btn_MostrarDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_MostrarDatos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_MostrarDatos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MostrarDatos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_MostrarDatos.Location = new System.Drawing.Point(37, 117);
            this.btn_MostrarDatos.Name = "btn_MostrarDatos";
            this.btn_MostrarDatos.Size = new System.Drawing.Size(98, 27);
            this.btn_MostrarDatos.TabIndex = 59;
            this.btn_MostrarDatos.Text = "Mostrar Datos";
            this.btn_MostrarDatos.UseVisualStyleBackColor = true;
            this.btn_MostrarDatos.Click += new System.EventHandler(this.btn_MostrarDatos_Click);
            // 
            // dtp_CatalogoDesde
            // 
            this.dtp_CatalogoDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_CatalogoDesde.CustomFormat = "dd/MM/yyyy HH:MM";
            this.dtp_CatalogoDesde.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_CatalogoDesde.Location = new System.Drawing.Point(71, 54);
            this.dtp_CatalogoDesde.Name = "dtp_CatalogoDesde";
            this.dtp_CatalogoDesde.Size = new System.Drawing.Size(120, 23);
            this.dtp_CatalogoDesde.TabIndex = 58;
            this.dtp_CatalogoDesde.Value = new System.DateTime(2022, 8, 10, 21, 21, 54, 0);
            // 
            // dgv_CatalogoUsuarios
            // 
            this.dgv_CatalogoUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_CatalogoUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CatalogoUsuarios.Location = new System.Drawing.Point(37, 160);
            this.dgv_CatalogoUsuarios.MultiSelect = false;
            this.dgv_CatalogoUsuarios.Name = "dgv_CatalogoUsuarios";
            this.dgv_CatalogoUsuarios.ReadOnly = true;
            this.dgv_CatalogoUsuarios.RowTemplate.Height = 25;
            this.dgv_CatalogoUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CatalogoUsuarios.Size = new System.Drawing.Size(612, 173);
            this.dgv_CatalogoUsuarios.TabIndex = 57;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.Location = new System.Drawing.Point(373, 62);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(68, 18);
            this.lbl_Nombre.TabIndex = 64;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Privilegio
            // 
            this.lbl_Privilegio.AutoSize = true;
            this.lbl_Privilegio.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Privilegio.Location = new System.Drawing.Point(373, 117);
            this.lbl_Privilegio.Name = "lbl_Privilegio";
            this.lbl_Privilegio.Size = new System.Drawing.Size(75, 18);
            this.lbl_Privilegio.TabIndex = 65;
            this.lbl_Privilegio.Text = "Privilegio";
            // 
            // lbl_Contra
            // 
            this.lbl_Contra.AutoSize = true;
            this.lbl_Contra.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Contra.Location = new System.Drawing.Point(373, 91);
            this.lbl_Contra.Name = "lbl_Contra";
            this.lbl_Contra.Size = new System.Drawing.Size(93, 18);
            this.lbl_Contra.TabIndex = 66;
            this.lbl_Contra.Text = "Contraseña";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(481, 56);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(130, 23);
            this.txt_Nombre.TabIndex = 67;
            // 
            // txt_Contra
            // 
            this.txt_Contra.Location = new System.Drawing.Point(481, 88);
            this.txt_Contra.Name = "txt_Contra";
            this.txt_Contra.Size = new System.Drawing.Size(130, 23);
            this.txt_Contra.TabIndex = 69;
            // 
            // cmb_Privilegio
            // 
            this.cmb_Privilegio.FormattingEnabled = true;
            this.cmb_Privilegio.Items.AddRange(new object[] {
            "Admin",
            "Cajera"});
            this.cmb_Privilegio.Location = new System.Drawing.Point(481, 117);
            this.cmb_Privilegio.Name = "cmb_Privilegio";
            this.cmb_Privilegio.Size = new System.Drawing.Size(130, 23);
            this.cmb_Privilegio.TabIndex = 70;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Agregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Agregar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Agregar.Location = new System.Drawing.Point(37, 339);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(118, 27);
            this.btn_Agregar.TabIndex = 71;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Modificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Modificar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Modificar.Location = new System.Drawing.Point(161, 339);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(118, 27);
            this.btn_Modificar.TabIndex = 72;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Guardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Guardar.Location = new System.Drawing.Point(621, 63);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(85, 27);
            this.btn_Guardar.TabIndex = 73;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_CancelarModificacion
            // 
            this.btn_CancelarModificacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CancelarModificacion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_CancelarModificacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CancelarModificacion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_CancelarModificacion.Location = new System.Drawing.Point(614, 96);
            this.btn_CancelarModificacion.Name = "btn_CancelarModificacion";
            this.btn_CancelarModificacion.Size = new System.Drawing.Size(92, 39);
            this.btn_CancelarModificacion.TabIndex = 74;
            this.btn_CancelarModificacion.Text = "Cancelar Modificacion";
            this.btn_CancelarModificacion.UseVisualStyleBackColor = true;
            this.btn_CancelarModificacion.Click += new System.EventHandler(this.btn_CancelarModificacion_Click);
            // 
            // Catalogo_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(714, 374);
            this.Controls.Add(this.btn_CancelarModificacion);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.cmb_Privilegio);
            this.Controls.Add(this.txt_Contra);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Contra);
            this.Controls.Add(this.lbl_Privilegio);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Hasta);
            this.Controls.Add(this.lbl_Desde);
            this.Controls.Add(this.dtp_CatalogoHasta);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_MostrarDatos);
            this.Controls.Add(this.dtp_CatalogoDesde);
            this.Controls.Add(this.dgv_CatalogoUsuarios);
            this.Controls.Add(this.lbl_Catalogo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Catalogo_Usuarios";
            this.Text = "Catalogo_Usuarios";
            this.Load += new System.EventHandler(this.Catalogo_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CatalogoUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Catalogo;
        private System.Windows.Forms.Label lbl_Hasta;
        private System.Windows.Forms.Label lbl_Desde;
        private System.Windows.Forms.DateTimePicker dtp_CatalogoHasta;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_MostrarDatos;
        private System.Windows.Forms.DateTimePicker dtp_CatalogoDesde;
        private System.Windows.Forms.DataGridView dgv_CatalogoUsuarios;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Privilegio;
        private System.Windows.Forms.Label lbl_Contra;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Contra;
        private System.Windows.Forms.ComboBox cmb_Privilegio;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_CancelarModificacion;
    }
}
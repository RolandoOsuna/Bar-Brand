
namespace WTFBarber
{
    partial class Catalogo_Productos
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
            this.dgv_CatalogoProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CatalogoProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Catalogo
            // 
            this.lbl_Catalogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Catalogo.AutoSize = true;
            this.lbl_Catalogo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Catalogo.ForeColor = System.Drawing.Color.White;
            this.lbl_Catalogo.Location = new System.Drawing.Point(160, 9);
            this.lbl_Catalogo.Name = "lbl_Catalogo";
            this.lbl_Catalogo.Size = new System.Drawing.Size(407, 41);
            this.lbl_Catalogo.TabIndex = 49;
            this.lbl_Catalogo.Text = "Catálogo de Productos";
            // 
            // lbl_Hasta
            // 
            this.lbl_Hasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Hasta.AutoSize = true;
            this.lbl_Hasta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hasta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Hasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.lbl_Hasta.Location = new System.Drawing.Point(213, 56);
            this.lbl_Hasta.Name = "lbl_Hasta";
            this.lbl_Hasta.Size = new System.Drawing.Size(52, 19);
            this.lbl_Hasta.TabIndex = 70;
            this.lbl_Hasta.Text = "Hasta";
            // 
            // lbl_Desde
            // 
            this.lbl_Desde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Desde.AutoSize = true;
            this.lbl_Desde.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Desde.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Desde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(225)))));
            this.lbl_Desde.Location = new System.Drawing.Point(10, 56);
            this.lbl_Desde.Name = "lbl_Desde";
            this.lbl_Desde.Size = new System.Drawing.Size(57, 19);
            this.lbl_Desde.TabIndex = 69;
            this.lbl_Desde.Text = "Desde";
            // 
            // dtp_CatalogoHasta
            // 
            this.dtp_CatalogoHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_CatalogoHasta.CustomFormat = "dd/MM/yyyy HH:MM";
            this.dtp_CatalogoHasta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_CatalogoHasta.Location = new System.Drawing.Point(271, 54);
            this.dtp_CatalogoHasta.Name = "dtp_CatalogoHasta";
            this.dtp_CatalogoHasta.Size = new System.Drawing.Size(120, 23);
            this.dtp_CatalogoHasta.TabIndex = 68;
            this.dtp_CatalogoHasta.Value = new System.DateTime(2022, 8, 10, 21, 21, 54, 0);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Cancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Cancelar.Location = new System.Drawing.Point(57, 315);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(118, 27);
            this.btn_Cancelar.TabIndex = 67;
            this.btn_Cancelar.Text = "Eliminar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_MostrarDatos
            // 
            this.btn_MostrarDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_MostrarDatos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_MostrarDatos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MostrarDatos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_MostrarDatos.Location = new System.Drawing.Point(18, 91);
            this.btn_MostrarDatos.Name = "btn_MostrarDatos";
            this.btn_MostrarDatos.Size = new System.Drawing.Size(98, 27);
            this.btn_MostrarDatos.TabIndex = 66;
            this.btn_MostrarDatos.Text = "Mostrar Datos";
            this.btn_MostrarDatos.UseVisualStyleBackColor = true;
            // 
            // dtp_CatalogoDesde
            // 
            this.dtp_CatalogoDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_CatalogoDesde.CustomFormat = "dd/MM/yyyy HH:MM";
            this.dtp_CatalogoDesde.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_CatalogoDesde.Location = new System.Drawing.Point(73, 54);
            this.dtp_CatalogoDesde.Name = "dtp_CatalogoDesde";
            this.dtp_CatalogoDesde.Size = new System.Drawing.Size(120, 23);
            this.dtp_CatalogoDesde.TabIndex = 65;
            this.dtp_CatalogoDesde.Value = new System.DateTime(2022, 8, 10, 21, 21, 54, 0);
            // 
            // dgv_CatalogoProductos
            // 
            this.dgv_CatalogoProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_CatalogoProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(204)))), ((int)(((byte)(168)))));
            this.dgv_CatalogoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CatalogoProductos.Location = new System.Drawing.Point(57, 126);
            this.dgv_CatalogoProductos.MultiSelect = false;
            this.dgv_CatalogoProductos.Name = "dgv_CatalogoProductos";
            this.dgv_CatalogoProductos.ReadOnly = true;
            this.dgv_CatalogoProductos.RowTemplate.Height = 25;
            this.dgv_CatalogoProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CatalogoProductos.Size = new System.Drawing.Size(551, 173);
            this.dgv_CatalogoProductos.TabIndex = 64;
            // 
            // Catalogo_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(714, 374);
            this.Controls.Add(this.lbl_Hasta);
            this.Controls.Add(this.lbl_Desde);
            this.Controls.Add(this.dtp_CatalogoHasta);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_MostrarDatos);
            this.Controls.Add(this.dtp_CatalogoDesde);
            this.Controls.Add(this.dgv_CatalogoProductos);
            this.Controls.Add(this.lbl_Catalogo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Catalogo_Productos";
            this.Text = "Catalogo_Productos";
            this.Load += new System.EventHandler(this.Catalogo_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CatalogoProductos)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_CatalogoProductos;
    }
}
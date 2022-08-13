
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
            this.lbl_Catalogo.Font = new System.Drawing.Font("Perpetua Titling MT", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Catalogo.Location = new System.Drawing.Point(127, 9);
            this.lbl_Catalogo.Name = "lbl_Catalogo";
            this.lbl_Catalogo.Size = new System.Drawing.Size(449, 42);
            this.lbl_Catalogo.TabIndex = 49;
            this.lbl_Catalogo.Text = "Catálogo de Gastos";
            // 
            // lbl_Hasta
            // 
            this.lbl_Hasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Hasta.AutoSize = true;
            this.lbl_Hasta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Hasta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Hasta.Location = new System.Drawing.Point(218, 58);
            this.lbl_Hasta.Name = "lbl_Hasta";
            this.lbl_Hasta.Size = new System.Drawing.Size(52, 19);
            this.lbl_Hasta.TabIndex = 56;
            this.lbl_Hasta.Text = "Hasta";
            // 
            // lbl_Desde
            // 
            this.lbl_Desde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Desde.AutoSize = true;
            this.lbl_Desde.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Desde.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Desde.Location = new System.Drawing.Point(22, 58);
            this.lbl_Desde.Name = "lbl_Desde";
            this.lbl_Desde.Size = new System.Drawing.Size(57, 19);
            this.lbl_Desde.TabIndex = 55;
            this.lbl_Desde.Text = "Desde";
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
            // Catalogo_Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(714, 374);
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
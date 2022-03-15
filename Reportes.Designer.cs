
namespace WTFBarber
{
    partial class Reportes
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
            this.cmb_TipoReporte = new System.Windows.Forms.ComboBox();
            this.lbl_Reportes = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Generar = new System.Windows.Forms.Button();
            this.lbl_Desde = new System.Windows.Forms.Label();
            this.lbl_TipoReporte = new System.Windows.Forms.Label();
            this.dtp_Desde = new System.Windows.Forms.DateTimePicker();
            this.dgv_Reportes = new System.Windows.Forms.DataGridView();
            this.dtp_Hasta = new System.Windows.Forms.DateTimePicker();
            this.lbl_Hasta = new System.Windows.Forms.Label();
            this.btn_MostrarDatos = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_TipoReporte
            // 
            this.cmb_TipoReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_TipoReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_TipoReporte.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_TipoReporte.ForeColor = System.Drawing.Color.Silver;
            this.cmb_TipoReporte.FormattingEnabled = true;
            this.cmb_TipoReporte.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_TipoReporte.Items.AddRange(new object[] {
            "Detallado",
            "Productos",
            "Empleados",
            "Nómina",
            "Comisiones",
            "Corte de Caja"});
            this.cmb_TipoReporte.Location = new System.Drawing.Point(72, 93);
            this.cmb_TipoReporte.Name = "cmb_TipoReporte";
            this.cmb_TipoReporte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_TipoReporte.Size = new System.Drawing.Size(117, 27);
            this.cmb_TipoReporte.TabIndex = 24;
            this.cmb_TipoReporte.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoReporte_SelectedIndexChanged);
            // 
            // lbl_Reportes
            // 
            this.lbl_Reportes.AutoSize = true;
            this.lbl_Reportes.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Reportes.Location = new System.Drawing.Point(266, 9);
            this.lbl_Reportes.Name = "lbl_Reportes";
            this.lbl_Reportes.Size = new System.Drawing.Size(284, 58);
            this.lbl_Reportes.TabIndex = 23;
            this.lbl_Reportes.Text = "Reportes";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Cancelar.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Red;
            this.btn_Cancelar.Location = new System.Drawing.Point(23, 433);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(145, 35);
            this.btn_Cancelar.TabIndex = 22;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Generar
            // 
            this.btn_Generar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Generar.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Generar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Generar.Location = new System.Drawing.Point(249, 433);
            this.btn_Generar.Name = "btn_Generar";
            this.btn_Generar.Size = new System.Drawing.Size(145, 35);
            this.btn_Generar.TabIndex = 21;
            this.btn_Generar.Text = "Generar";
            this.btn_Generar.UseVisualStyleBackColor = true;
            this.btn_Generar.Click += new System.EventHandler(this.btn_Generar_Click);
            // 
            // lbl_Desde
            // 
            this.lbl_Desde.AutoSize = true;
            this.lbl_Desde.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Desde.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Desde.Location = new System.Drawing.Point(479, 74);
            this.lbl_Desde.Name = "lbl_Desde";
            this.lbl_Desde.Size = new System.Drawing.Size(56, 19);
            this.lbl_Desde.TabIndex = 18;
            this.lbl_Desde.Text = "Desde";
            // 
            // lbl_TipoReporte
            // 
            this.lbl_TipoReporte.AutoSize = true;
            this.lbl_TipoReporte.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_TipoReporte.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TipoReporte.Location = new System.Drawing.Point(61, 70);
            this.lbl_TipoReporte.Name = "lbl_TipoReporte";
            this.lbl_TipoReporte.Size = new System.Drawing.Size(141, 20);
            this.lbl_TipoReporte.TabIndex = 16;
            this.lbl_TipoReporte.Text = "Tipo de Reporte";
            // 
            // dtp_Desde
            // 
            this.dtp_Desde.CustomFormat = "";
            this.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Desde.Location = new System.Drawing.Point(545, 70);
            this.dtp_Desde.Name = "dtp_Desde";
            this.dtp_Desde.Size = new System.Drawing.Size(98, 23);
            this.dtp_Desde.TabIndex = 27;
            this.dtp_Desde.Value = new System.DateTime(2022, 2, 25, 0, 0, 0, 0);
            // 
            // dgv_Reportes
            // 
            this.dgv_Reportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reportes.Location = new System.Drawing.Point(137, 164);
            this.dgv_Reportes.Name = "dgv_Reportes";
            this.dgv_Reportes.RowTemplate.Height = 25;
            this.dgv_Reportes.Size = new System.Drawing.Size(563, 237);
            this.dgv_Reportes.TabIndex = 28;
            // 
            // dtp_Hasta
            // 
            this.dtp_Hasta.CustomFormat = "";
            this.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Hasta.Location = new System.Drawing.Point(545, 121);
            this.dtp_Hasta.Name = "dtp_Hasta";
            this.dtp_Hasta.Size = new System.Drawing.Size(98, 23);
            this.dtp_Hasta.TabIndex = 30;
            this.dtp_Hasta.Value = new System.DateTime(2022, 2, 25, 14, 3, 13, 0);
            // 
            // lbl_Hasta
            // 
            this.lbl_Hasta.AutoSize = true;
            this.lbl_Hasta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Hasta.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Hasta.Location = new System.Drawing.Point(479, 121);
            this.lbl_Hasta.Name = "lbl_Hasta";
            this.lbl_Hasta.Size = new System.Drawing.Size(50, 19);
            this.lbl_Hasta.TabIndex = 29;
            this.lbl_Hasta.Text = "Hasta";
            // 
            // btn_MostrarDatos
            // 
            this.btn_MostrarDatos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_MostrarDatos.Font = new System.Drawing.Font("Perpetua", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MostrarDatos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_MostrarDatos.Location = new System.Drawing.Point(649, 93);
            this.btn_MostrarDatos.Name = "btn_MostrarDatos";
            this.btn_MostrarDatos.Size = new System.Drawing.Size(118, 27);
            this.btn_MostrarDatos.TabIndex = 31;
            this.btn_MostrarDatos.Text = "Mostrar Datos";
            this.btn_MostrarDatos.UseVisualStyleBackColor = true;
            this.btn_MostrarDatos.Click += new System.EventHandler(this.btn_MostrarDatos_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(545, 440);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 19);
            this.lbl.TabIndex = 32;
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn_MostrarDatos);
            this.Controls.Add(this.dtp_Hasta);
            this.Controls.Add(this.lbl_Hasta);
            this.Controls.Add(this.dgv_Reportes);
            this.Controls.Add(this.dtp_Desde);
            this.Controls.Add(this.cmb_TipoReporte);
            this.Controls.Add(this.lbl_Reportes);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Generar);
            this.Controls.Add(this.lbl_Desde);
            this.Controls.Add(this.lbl_TipoReporte);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_TipoReporte;
        private System.Windows.Forms.Label lbl_Reportes;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Generar;
        private System.Windows.Forms.Label lbl_Desde;
        private System.Windows.Forms.Label lbl_TipoReporte;
        private System.Windows.Forms.DateTimePicker dtp_Desde;
        private System.Windows.Forms.DataGridView dgv_Reportes;
        private System.Windows.Forms.DateTimePicker dtp_Hasta;
        private System.Windows.Forms.Label lbl_Hasta;
        private System.Windows.Forms.Button btn_MostrarDatos;
        private System.Windows.Forms.Label lbl;
    }
}
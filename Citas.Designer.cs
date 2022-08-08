
namespace WTFBarber
{
    partial class Citas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Citas));
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_Citas = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.dtp_cita = new System.Windows.Forms.DateTimePicker();
            this.dgv_Citas = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Citas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(721, 413);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 19);
            this.lbl.TabIndex = 46;
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Citas
            // 
            this.lbl_Citas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Citas.AutoSize = true;
            this.lbl_Citas.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Citas.Location = new System.Drawing.Point(320, 56);
            this.lbl_Citas.Name = "lbl_Citas";
            this.lbl_Citas.Size = new System.Drawing.Size(173, 58);
            this.lbl_Citas.TabIndex = 42;
            this.lbl_Citas.Text = "Citas";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nombre.Location = new System.Drawing.Point(161, 153);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(150, 23);
            this.txt_nombre.TabIndex = 47;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(80, 156);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_nombre.TabIndex = 48;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(80, 207);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(52, 15);
            this.lbl_telefono.TabIndex = 52;
            this.lbl_telefono.Text = "Teléfono";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_telefono.Location = new System.Drawing.Point(161, 204);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(150, 23);
            this.txt_telefono.TabIndex = 51;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // dtp_cita
            // 
            this.dtp_cita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_cita.CustomFormat = "dd/MM/yyyy HH:MM";
            this.dtp_cita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_cita.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_cita.Location = new System.Drawing.Point(81, 252);
            this.dtp_cita.Name = "dtp_cita";
            this.dtp_cita.Size = new System.Drawing.Size(132, 23);
            this.dtp_cita.TabIndex = 53;
            // 
            // dgv_Citas
            // 
            this.dgv_Citas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Citas.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_Citas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Citas.Location = new System.Drawing.Point(80, 299);
            this.dgv_Citas.MultiSelect = false;
            this.dgv_Citas.Name = "dgv_Citas";
            this.dgv_Citas.ReadOnly = true;
            this.dgv_Citas.RowTemplate.Height = 25;
            this.dgv_Citas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Citas.Size = new System.Drawing.Size(545, 150);
            this.dgv_Citas.TabIndex = 54;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancelar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Cancelar.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Red;
            this.btn_Cancelar.Location = new System.Drawing.Point(607, 197);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(145, 35);
            this.btn_Cancelar.TabIndex = 59;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Agregar.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Agregar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Agregar.Location = new System.Drawing.Point(607, 156);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(145, 35);
            this.btn_Agregar.TabIndex = 58;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Limpiar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Limpiar.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Limpiar.ForeColor = System.Drawing.Color.Red;
            this.btn_Limpiar.Location = new System.Drawing.Point(607, 238);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(145, 35);
            this.btn_Limpiar.TabIndex = 60;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(535, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(176, 152);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 61;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 455);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.dgv_Citas);
            this.Controls.Add(this.dtp_cita);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lbl_Citas);
            this.Name = "Citas";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.Citas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Citas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl_Citas;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.DateTimePicker dtp_cita;
        private System.Windows.Forms.DataGridView dgv_Citas;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
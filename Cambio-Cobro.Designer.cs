
namespace WTFBarber
{
    partial class Cambio_Cobro
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
            this.txt_Pago = new System.Windows.Forms.TextBox();
            this.lbl_Pago = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_CantidadTotal = new System.Windows.Forms.Label();
            this.lbl_CantidadCambio = new System.Windows.Forms.Label();
            this.lbl_Cambio = new System.Windows.Forms.Label();
            this.btn_iconoConfirmar = new FontAwesome.Sharp.IconButton();
            this.btn_iconoCancelar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txt_Pago
            // 
            this.txt_Pago.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Pago.Location = new System.Drawing.Point(37, 96);
            this.txt_Pago.Name = "txt_Pago";
            this.txt_Pago.PlaceholderText = "$";
            this.txt_Pago.Size = new System.Drawing.Size(195, 27);
            this.txt_Pago.TabIndex = 0;
            // 
            // lbl_Pago
            // 
            this.lbl_Pago.AutoSize = true;
            this.lbl_Pago.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pago.Location = new System.Drawing.Point(37, 69);
            this.lbl_Pago.Name = "lbl_Pago";
            this.lbl_Pago.Size = new System.Drawing.Size(65, 25);
            this.lbl_Pago.TabIndex = 1;
            this.lbl_Pago.Text = "Pago";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Total.Location = new System.Drawing.Point(37, 139);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(49, 21);
            this.lbl_Total.TabIndex = 2;
            this.lbl_Total.Text = "Total";
            // 
            // lbl_CantidadTotal
            // 
            this.lbl_CantidadTotal.AutoSize = true;
            this.lbl_CantidadTotal.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CantidadTotal.Location = new System.Drawing.Point(37, 168);
            this.lbl_CantidadTotal.Name = "lbl_CantidadTotal";
            this.lbl_CantidadTotal.Size = new System.Drawing.Size(22, 27);
            this.lbl_CantidadTotal.TabIndex = 3;
            this.lbl_CantidadTotal.Text = "-";
            // 
            // lbl_CantidadCambio
            // 
            this.lbl_CantidadCambio.AutoSize = true;
            this.lbl_CantidadCambio.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CantidadCambio.Location = new System.Drawing.Point(159, 168);
            this.lbl_CantidadCambio.Name = "lbl_CantidadCambio";
            this.lbl_CantidadCambio.Size = new System.Drawing.Size(22, 27);
            this.lbl_CantidadCambio.TabIndex = 5;
            this.lbl_CantidadCambio.Text = "-";
            // 
            // lbl_Cambio
            // 
            this.lbl_Cambio.AutoSize = true;
            this.lbl_Cambio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cambio.Location = new System.Drawing.Point(159, 139);
            this.lbl_Cambio.Name = "lbl_Cambio";
            this.lbl_Cambio.Size = new System.Drawing.Size(73, 21);
            this.lbl_Cambio.TabIndex = 4;
            this.lbl_Cambio.Text = "Cambio";
            // 
            // btn_iconoConfirmar
            // 
            this.btn_iconoConfirmar.BackColor = System.Drawing.Color.Green;
            this.btn_iconoConfirmar.FlatAppearance.BorderSize = 0;
            this.btn_iconoConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iconoConfirmar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_iconoConfirmar.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_iconoConfirmar.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.btn_iconoConfirmar.IconColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_iconoConfirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_iconoConfirmar.IconSize = 40;
            this.btn_iconoConfirmar.Location = new System.Drawing.Point(273, 57);
            this.btn_iconoConfirmar.Name = "btn_iconoConfirmar";
            this.btn_iconoConfirmar.Size = new System.Drawing.Size(143, 53);
            this.btn_iconoConfirmar.TabIndex = 6;
            this.btn_iconoConfirmar.Text = "Confirmar";
            this.btn_iconoConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_iconoConfirmar.UseVisualStyleBackColor = false;
            this.btn_iconoConfirmar.Click += new System.EventHandler(this.btn_iconoConfirmar_Click);
            // 
            // btn_iconoCancelar
            // 
            this.btn_iconoCancelar.BackColor = System.Drawing.Color.Brown;
            this.btn_iconoCancelar.FlatAppearance.BorderSize = 0;
            this.btn_iconoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iconoCancelar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_iconoCancelar.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_iconoCancelar.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btn_iconoCancelar.IconColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_iconoCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_iconoCancelar.IconSize = 40;
            this.btn_iconoCancelar.Location = new System.Drawing.Point(273, 116);
            this.btn_iconoCancelar.Name = "btn_iconoCancelar";
            this.btn_iconoCancelar.Size = new System.Drawing.Size(143, 53);
            this.btn_iconoCancelar.TabIndex = 7;
            this.btn_iconoCancelar.Text = "Cancelar";
            this.btn_iconoCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_iconoCancelar.UseVisualStyleBackColor = false;
            this.btn_iconoCancelar.Click += new System.EventHandler(this.btn_iconoCancelar_Click);
            // 
            // Cambio_Cobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(428, 252);
            this.Controls.Add(this.btn_iconoCancelar);
            this.Controls.Add(this.btn_iconoConfirmar);
            this.Controls.Add(this.lbl_CantidadCambio);
            this.Controls.Add(this.lbl_Cambio);
            this.Controls.Add(this.lbl_CantidadTotal);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Pago);
            this.Controls.Add(this.txt_Pago);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cambio_Cobro";
            this.Text = "Cambio_Cobro";
            this.Load += new System.EventHandler(this.Cambio_Cobro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Pago;
        private System.Windows.Forms.Label lbl_Pago;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_CantidadTotal;
        private System.Windows.Forms.Label lbl_CantidadCambio;
        private System.Windows.Forms.Label lbl_Cambio;
        private FontAwesome.Sharp.IconButton btn_iconoConfirmar;
        private FontAwesome.Sharp.IconButton btn_iconoCancelar;
    }
}
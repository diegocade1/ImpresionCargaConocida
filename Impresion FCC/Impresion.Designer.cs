namespace Impresion_FCC
{
    partial class Impresion
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
            this.lblImpresion = new System.Windows.Forms.Label();
            this.lblGuia = new System.Windows.Forms.Label();
            this.txtGuia = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblImpresion
            // 
            this.lblImpresion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblImpresion.AutoSize = true;
            this.lblImpresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpresion.Location = new System.Drawing.Point(193, 36);
            this.lblImpresion.Name = "lblImpresion";
            this.lblImpresion.Size = new System.Drawing.Size(120, 29);
            this.lblImpresion.TabIndex = 0;
            this.lblImpresion.Text = "Impresión";
            // 
            // lblGuia
            // 
            this.lblGuia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGuia.AutoSize = true;
            this.lblGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuia.Location = new System.Drawing.Point(58, 108);
            this.lblGuia.Name = "lblGuia";
            this.lblGuia.Size = new System.Drawing.Size(94, 20);
            this.lblGuia.TabIndex = 1;
            this.lblGuia.Text = "Guia Aérea:";
            // 
            // txtGuia
            // 
            this.txtGuia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuia.Location = new System.Drawing.Point(158, 106);
            this.txtGuia.MaxLength = 20;
            this.txtGuia.Name = "txtGuia";
            this.txtGuia.Size = new System.Drawing.Size(196, 24);
            this.txtGuia.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(94, 166);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(58, 20);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(104, 223);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(48, 20);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.CustomFormat = "";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(158, 165);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 24);
            this.dtpFecha.TabIndex = 5;
            // 
            // dtpHora
            // 
            this.dtpHora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpHora.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora.CustomFormat = "hh:mm";
            this.dtpHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora.Location = new System.Drawing.Point(158, 223);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(200, 24);
            this.dtpHora.TabIndex = 6;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(75, 284);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(77, 20);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(158, 282);
            this.txtCantidad.MaxLength = 10;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(196, 24);
            this.txtCantidad.TabIndex = 8;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(108, 384);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(89, 32);
            this.btnImprimir.TabIndex = 9;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(287, 384);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 32);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Impresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 465);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtGuia);
            this.Controls.Add(this.lblGuia);
            this.Controls.Add(this.lblImpresion);
            this.Name = "Impresion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Impresion";
            this.Load += new System.EventHandler(this.Impresion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImpresion;
        private System.Windows.Forms.Label lblGuia;
        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;
    }
}
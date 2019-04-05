namespace Impresion_FCC
{
    partial class Consulta
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
            this.lblConsulta = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dtpComienzo = new System.Windows.Forms.DateTimePicker();
            this.lblBuscar2 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarFecha = new System.Windows.Forms.Button();
            this.panelGuia = new System.Windows.Forms.Panel();
            this.btnBuscarGuia = new System.Windows.Forms.Button();
            this.txtGuia = new System.Windows.Forms.TextBox();
            this.lblGuia = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.panelGuia.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConsulta
            // 
            this.lblConsulta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(309, 33);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(107, 29);
            this.lblConsulta.TabIndex = 1;
            this.lblConsulta.Text = "Consulta";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(12, 119);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(730, 457);
            this.dgvLista.TabIndex = 2;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(21, 78);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(103, 18);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Buscar desde:";
            // 
            // dtpComienzo
            // 
            this.dtpComienzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpComienzo.Location = new System.Drawing.Point(130, 73);
            this.dtpComienzo.Name = "dtpComienzo";
            this.dtpComienzo.Size = new System.Drawing.Size(162, 24);
            this.dtpComienzo.TabIndex = 4;
            // 
            // lblBuscar2
            // 
            this.lblBuscar2.AutoSize = true;
            this.lblBuscar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar2.Location = new System.Drawing.Point(307, 78);
            this.lblBuscar2.Name = "lblBuscar2";
            this.lblBuscar2.Size = new System.Drawing.Size(48, 18);
            this.lblBuscar2.TabIndex = 5;
            this.lblBuscar2.Text = "hasta:";
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Location = new System.Drawing.Point(361, 73);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(162, 24);
            this.dtpFin.TabIndex = 6;
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFecha.Location = new System.Drawing.Point(539, 71);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(77, 32);
            this.btnBuscarFecha.TabIndex = 7;
            this.btnBuscarFecha.Text = "Buscar";
            this.btnBuscarFecha.UseVisualStyleBackColor = true;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelGuia
            // 
            this.panelGuia.Controls.Add(this.btnBuscarGuia);
            this.panelGuia.Controls.Add(this.txtGuia);
            this.panelGuia.Controls.Add(this.lblGuia);
            this.panelGuia.Location = new System.Drawing.Point(683, 11);
            this.panelGuia.Name = "panelGuia";
            this.panelGuia.Size = new System.Drawing.Size(604, 50);
            this.panelGuia.TabIndex = 8;
            this.panelGuia.Visible = false;
            // 
            // btnBuscarGuia
            // 
            this.btnBuscarGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarGuia.Location = new System.Drawing.Point(288, 10);
            this.btnBuscarGuia.Name = "btnBuscarGuia";
            this.btnBuscarGuia.Size = new System.Drawing.Size(77, 32);
            this.btnBuscarGuia.TabIndex = 9;
            this.btnBuscarGuia.Text = "Buscar";
            this.btnBuscarGuia.UseVisualStyleBackColor = true;
            this.btnBuscarGuia.Click += new System.EventHandler(this.btnBuscarGuia_Click);
            // 
            // txtGuia
            // 
            this.txtGuia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuia.Location = new System.Drawing.Point(69, 14);
            this.txtGuia.MaxLength = 20;
            this.txtGuia.Name = "txtGuia";
            this.txtGuia.Size = new System.Drawing.Size(196, 24);
            this.txtGuia.TabIndex = 5;
            // 
            // lblGuia
            // 
            this.lblGuia.AutoSize = true;
            this.lblGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuia.Location = new System.Drawing.Point(20, 17);
            this.lblGuia.Name = "lblGuia";
            this.lblGuia.Size = new System.Drawing.Size(43, 18);
            this.lblGuia.TabIndex = 4;
            this.lblGuia.Text = "Guia:";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(24, 40);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(47, 23);
            this.btnFiltro.TabIndex = 9;
            this.btnFiltro.Text = "Fecha";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(642, 67);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(87, 42);
            this.btnExportar.TabIndex = 10;
            this.btnExportar.Text = "Exportar a Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 588);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.panelGuia);
            this.Controls.Add(this.btnBuscarFecha);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.lblBuscar2);
            this.Controls.Add(this.dtpComienzo);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.lblConsulta);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.panelGuia.ResumeLayout(false);
            this.panelGuia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DateTimePicker dtpComienzo;
        private System.Windows.Forms.Label lblBuscar2;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button btnBuscarFecha;
        private System.Windows.Forms.Panel panelGuia;
        private System.Windows.Forms.Label lblGuia;
        private System.Windows.Forms.Button btnBuscarGuia;
        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Button btnExportar;
    }
}
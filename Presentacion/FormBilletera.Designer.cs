namespace billeteraMovilCajaArequipa.Presentacion
{
    partial class FormBilletera
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnRecibirTransferencia = new System.Windows.Forms.Button();
            this.btnProcesarSiguiente = new System.Windows.Forms.Button();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.btnRevertirUltima = new System.Windows.Forms.Button();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();

            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(30, 30);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(150, 23);
            this.txtMonto.TabIndex = 0;

            // 
            // btnRecibirTransferencia
            // 
            this.btnRecibirTransferencia.Location = new System.Drawing.Point(200, 29);
            this.btnRecibirTransferencia.Name = "btnRecibirTransferencia";
            this.btnRecibirTransferencia.Size = new System.Drawing.Size(150, 25);
            this.btnRecibirTransferencia.TabIndex = 1;
            this.btnRecibirTransferencia.Text = "Simular Llegada";
            this.btnRecibirTransferencia.UseVisualStyleBackColor = true;
            this.btnRecibirTransferencia.Click += new System.EventHandler(this.btnRecibirTransferencia_Click);

            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.ItemHeight = 15;
            this.lstCola.Location = new System.Drawing.Point(30, 80);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(320, 139);
            this.lstCola.TabIndex = 2;

            // 
            // btnProcesarSiguiente
            // 
            this.btnProcesarSiguiente.Location = new System.Drawing.Point(30, 230);
            this.btnProcesarSiguiente.Name = "btnProcesarSiguiente";
            this.btnProcesarSiguiente.Size = new System.Drawing.Size(320, 30);
            this.btnProcesarSiguiente.TabIndex = 3;
            this.btnProcesarSiguiente.Text = "Procesar Siguiente de la Cola";
            this.btnProcesarSiguiente.UseVisualStyleBackColor = true;
            this.btnProcesarSiguiente.Click += new System.EventHandler(this.btnProcesarSiguiente_Click);

            // 
            // btnRevertirUltima
            // 
            this.btnRevertirUltima.Location = new System.Drawing.Point(30, 270);
            this.btnRevertirUltima.Name = "btnRevertirUltima";
            this.btnRevertirUltima.Size = new System.Drawing.Size(320, 30);
            this.btnRevertirUltima.TabIndex = 4;
            this.btnRevertirUltima.Text = "Revertir Último Abono";
            this.btnRevertirUltima.UseVisualStyleBackColor = true;
            this.btnRevertirUltima.Click += new System.EventHandler(this.btnRevertirUltima_Click);

            // 
            // dgvHistorial
            // 
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(380, 30);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.RowTemplate.Height = 25;
            this.dgvHistorial.Size = new System.Drawing.Size(500, 270);
            this.dgvHistorial.TabIndex = 5;

            // 
            // FormBilletera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 340);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.btnRevertirUltima);
            this.Controls.Add(this.btnProcesarSiguiente);
            this.Controls.Add(this.lstCola);
            this.Controls.Add(this.btnRecibirTransferencia);
            this.Controls.Add(this.txtMonto);
            this.Name = "FormBilletera";
            this.Text = "Prototipo Caja Arequipa - Estructuras Lineales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnRecibirTransferencia;
        private System.Windows.Forms.Button btnProcesarSiguiente;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.Button btnRevertirUltima;
        private System.Windows.Forms.DataGridView dgvHistorial;
    }
}
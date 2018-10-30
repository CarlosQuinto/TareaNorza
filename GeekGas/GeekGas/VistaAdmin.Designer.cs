namespace GeekGas
{
    partial class VistaAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnGenerarFacturas = new System.Windows.Forms.Button();
            this.btnReporteTotalAnual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(40, 107);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(128, 101);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "Registrar Usuarios";
            this.btnRegistro.UseVisualStyleBackColor = true;
            // 
            // btnGenerarFacturas
            // 
            this.btnGenerarFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFacturas.Location = new System.Drawing.Point(226, 107);
            this.btnGenerarFacturas.Name = "btnGenerarFacturas";
            this.btnGenerarFacturas.Size = new System.Drawing.Size(128, 101);
            this.btnGenerarFacturas.TabIndex = 2;
            this.btnGenerarFacturas.Text = "Generar Facturas";
            this.btnGenerarFacturas.UseVisualStyleBackColor = true;
            // 
            // btnReporteTotalAnual
            // 
            this.btnReporteTotalAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteTotalAnual.Location = new System.Drawing.Point(415, 107);
            this.btnReporteTotalAnual.Name = "btnReporteTotalAnual";
            this.btnReporteTotalAnual.Size = new System.Drawing.Size(128, 101);
            this.btnReporteTotalAnual.TabIndex = 3;
            this.btnReporteTotalAnual.Text = "Reporte Total Anual";
            this.btnReporteTotalAnual.UseVisualStyleBackColor = true;
            // 
            // VistaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 305);
            this.Controls.Add(this.btnReporteTotalAnual);
            this.Controls.Add(this.btnGenerarFacturas);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.label1);
            this.Name = "VistaAdmin";
            this.Text = "VistaAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnGenerarFacturas;
        private System.Windows.Forms.Button btnReporteTotalAnual;
    }
}
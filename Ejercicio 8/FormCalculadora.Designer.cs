
namespace Ejercicio_8
{
    partial class FormCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculadora));
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.lblMeses = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cbxPrestamo = new System.Windows.Forms.ComboBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.cbxMeses = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMonto.Location = new System.Drawing.Point(26, 28);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(93, 32);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "Monto:";
            // 
            // lblPrestamo
            // 
            this.lblPrestamo.AutoSize = true;
            this.lblPrestamo.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPrestamo.Location = new System.Drawing.Point(26, 89);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(224, 32);
            this.lblPrestamo.TabIndex = 1;
            this.lblPrestamo.Text = "Tipo de prestamo: ";
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblMeses.Location = new System.Drawing.Point(26, 150);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(95, 32);
            this.lblMeses.TabIndex = 2;
            this.lblMeses.Text = "Meses: ";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(26, 212);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(139, 32);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado: ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(256, 279);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(226, 41);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(256, 31);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(226, 31);
            this.txtMonto.TabIndex = 4;
            // 
            // cbxPrestamo
            // 
            this.cbxPrestamo.FormattingEnabled = true;
            this.cbxPrestamo.Location = new System.Drawing.Point(256, 92);
            this.cbxPrestamo.Name = "cbxPrestamo";
            this.cbxPrestamo.Size = new System.Drawing.Size(226, 33);
            this.cbxPrestamo.TabIndex = 5;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(256, 215);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(226, 31);
            this.txtResultado.TabIndex = 7;
            // 
            // cbxMeses
            // 
            this.cbxMeses.FormattingEnabled = true;
            this.cbxMeses.Location = new System.Drawing.Point(256, 153);
            this.cbxMeses.Name = "cbxMeses";
            this.cbxMeses.Size = new System.Drawing.Size(226, 33);
            this.cbxMeses.TabIndex = 6;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 354);
            this.Controls.Add(this.cbxMeses);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.cbxPrestamo);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.lblPrestamo);
            this.Controls.Add(this.lblMonto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCalculadora";
            this.Text = "Calculadora de prestamos";
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ComboBox cbxPrestamo;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.ComboBox cbxMeses;
    }
}


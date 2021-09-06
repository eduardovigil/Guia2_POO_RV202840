namespace Guia2_POO_RV202840
{
    partial class FrmMenu
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
            this.BtnDescuento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConversion = new System.Windows.Forms.Button();
            this.BtnCuadratica = new System.Windows.Forms.Button();
            this.BtnEjemplo = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDescuento
            // 
            this.BtnDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnDescuento.Location = new System.Drawing.Point(30, 54);
            this.BtnDescuento.Name = "BtnDescuento";
            this.BtnDescuento.Size = new System.Drawing.Size(143, 45);
            this.BtnDescuento.TabIndex = 0;
            this.BtnDescuento.Text = "Descuentos";
            this.BtnDescuento.UseVisualStyleBackColor = false;
            this.BtnDescuento.Click += new System.EventHandler(this.BtnDescuento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // BtnConversion
            // 
            this.BtnConversion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnConversion.Location = new System.Drawing.Point(193, 54);
            this.BtnConversion.Name = "BtnConversion";
            this.BtnConversion.Size = new System.Drawing.Size(143, 45);
            this.BtnConversion.TabIndex = 2;
            this.BtnConversion.Text = "Conversiones";
            this.BtnConversion.UseVisualStyleBackColor = false;
            this.BtnConversion.Click += new System.EventHandler(this.BtnConversion_Click);
            // 
            // BtnCuadratica
            // 
            this.BtnCuadratica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCuadratica.Location = new System.Drawing.Point(354, 54);
            this.BtnCuadratica.Name = "BtnCuadratica";
            this.BtnCuadratica.Size = new System.Drawing.Size(143, 45);
            this.BtnCuadratica.TabIndex = 3;
            this.BtnCuadratica.Text = "Formula Cuadratica";
            this.BtnCuadratica.UseVisualStyleBackColor = false;
            this.BtnCuadratica.Click += new System.EventHandler(this.BtnCuadratica_Click);
            // 
            // BtnEjemplo
            // 
            this.BtnEjemplo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEjemplo.Location = new System.Drawing.Point(520, 54);
            this.BtnEjemplo.Name = "BtnEjemplo";
            this.BtnEjemplo.Size = new System.Drawing.Size(143, 45);
            this.BtnEjemplo.TabIndex = 4;
            this.BtnEjemplo.Text = "Ejemplo 5 Modificado";
            this.BtnEjemplo.UseVisualStyleBackColor = false;
            this.BtnEjemplo.Click += new System.EventHandler(this.BtnEjemplo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSalir.Location = new System.Drawing.Point(264, 105);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(143, 45);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(699, 160);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEjemplo);
            this.Controls.Add(this.BtnCuadratica);
            this.Controls.Add(this.BtnConversion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDescuento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDescuento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConversion;
        private System.Windows.Forms.Button BtnCuadratica;
        private System.Windows.Forms.Button BtnEjemplo;
        private System.Windows.Forms.Button BtnSalir;
    }
}
namespace Guia2_POO_RV202840
{
    partial class FrmEjemplo5
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
            this.grbArreglo = new System.Windows.Forms.GroupBox();
            this.btnmostrar1 = new System.Windows.Forms.Button();
            this.txtmayoposi = new System.Windows.Forms.TextBox();
            this.txtpositivos = new System.Windows.Forms.TextBox();
            this.txtprocentaje = new System.Windows.Forms.TextBox();
            this.lblmayposi = new System.Windows.Forms.Label();
            this.lblpositivos = new System.Windows.Forms.Label();
            this.lblprocentaje = new System.Windows.Forms.Label();
            this.lblnegativo = new System.Windows.Forms.Label();
            this.txtnegativo = new System.Windows.Forms.TextBox();
            this.lsbArreglo = new System.Windows.Forms.ListBox();
            this.lblArreglo = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.grbArreglo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbArreglo
            // 
            this.grbArreglo.Controls.Add(this.btnmostrar1);
            this.grbArreglo.Controls.Add(this.txtmayoposi);
            this.grbArreglo.Controls.Add(this.txtpositivos);
            this.grbArreglo.Controls.Add(this.txtprocentaje);
            this.grbArreglo.Controls.Add(this.lblmayposi);
            this.grbArreglo.Controls.Add(this.lblpositivos);
            this.grbArreglo.Controls.Add(this.lblprocentaje);
            this.grbArreglo.Controls.Add(this.lblnegativo);
            this.grbArreglo.Controls.Add(this.txtnegativo);
            this.grbArreglo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbArreglo.Location = new System.Drawing.Point(156, 159);
            this.grbArreglo.Name = "grbArreglo";
            this.grbArreglo.Size = new System.Drawing.Size(424, 141);
            this.grbArreglo.TabIndex = 16;
            this.grbArreglo.TabStop = false;
            this.grbArreglo.Text = "Operaciones Con Arreglo:";
            // 
            // btnmostrar1
            // 
            this.btnmostrar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnmostrar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar1.Location = new System.Drawing.Point(333, 33);
            this.btnmostrar1.Name = "btnmostrar1";
            this.btnmostrar1.Size = new System.Drawing.Size(85, 90);
            this.btnmostrar1.TabIndex = 10;
            this.btnmostrar1.Text = "Mostrar";
            this.btnmostrar1.UseVisualStyleBackColor = false;
            this.btnmostrar1.Click += new System.EventHandler(this.btnmostrar1_Click);
            // 
            // txtmayoposi
            // 
            this.txtmayoposi.Location = new System.Drawing.Point(237, 110);
            this.txtmayoposi.Name = "txtmayoposi";
            this.txtmayoposi.ReadOnly = true;
            this.txtmayoposi.Size = new System.Drawing.Size(87, 20);
            this.txtmayoposi.TabIndex = 9;
            // 
            // txtpositivos
            // 
            this.txtpositivos.Location = new System.Drawing.Point(237, 86);
            this.txtpositivos.Name = "txtpositivos";
            this.txtpositivos.ReadOnly = true;
            this.txtpositivos.Size = new System.Drawing.Size(87, 20);
            this.txtpositivos.TabIndex = 8;
            // 
            // txtprocentaje
            // 
            this.txtprocentaje.Location = new System.Drawing.Point(237, 59);
            this.txtprocentaje.Name = "txtprocentaje";
            this.txtprocentaje.ReadOnly = true;
            this.txtprocentaje.Size = new System.Drawing.Size(87, 20);
            this.txtprocentaje.TabIndex = 7;
            // 
            // lblmayposi
            // 
            this.lblmayposi.AutoSize = true;
            this.lblmayposi.Location = new System.Drawing.Point(15, 110);
            this.lblmayposi.Name = "lblmayposi";
            this.lblmayposi.Size = new System.Drawing.Size(172, 13);
            this.lblmayposi.TabIndex = 6;
            this.lblmayposi.Text = "Mayor de los pares positivos:";
            // 
            // lblpositivos
            // 
            this.lblpositivos.AutoSize = true;
            this.lblpositivos.Location = new System.Drawing.Point(15, 85);
            this.lblpositivos.Name = "lblpositivos";
            this.lblpositivos.Size = new System.Drawing.Size(182, 13);
            this.lblpositivos.TabIndex = 5;
            this.lblpositivos.Text = "Promedio de impares positivos:";
            // 
            // lblprocentaje
            // 
            this.lblprocentaje.AutoSize = true;
            this.lblprocentaje.Location = new System.Drawing.Point(15, 59);
            this.lblprocentaje.Name = "lblprocentaje";
            this.lblprocentaje.Size = new System.Drawing.Size(186, 13);
            this.lblprocentaje.TabIndex = 4;
            this.lblprocentaje.Text = "Porcentaje de ceros en arreglo:";
            // 
            // lblnegativo
            // 
            this.lblnegativo.AutoSize = true;
            this.lblnegativo.Location = new System.Drawing.Point(15, 33);
            this.lblnegativo.Name = "lblnegativo";
            this.lblnegativo.Size = new System.Drawing.Size(216, 13);
            this.lblnegativo.TabIndex = 3;
            this.lblnegativo.Text = "Números mayores de pares negativo:";
            // 
            // txtnegativo
            // 
            this.txtnegativo.Location = new System.Drawing.Point(237, 33);
            this.txtnegativo.Name = "txtnegativo";
            this.txtnegativo.ReadOnly = true;
            this.txtnegativo.Size = new System.Drawing.Size(87, 20);
            this.txtnegativo.TabIndex = 2;
            // 
            // lsbArreglo
            // 
            this.lsbArreglo.FormattingEnabled = true;
            this.lsbArreglo.Location = new System.Drawing.Point(39, 131);
            this.lsbArreglo.Name = "lsbArreglo";
            this.lsbArreglo.Size = new System.Drawing.Size(99, 160);
            this.lsbArreglo.TabIndex = 15;
            // 
            // lblArreglo
            // 
            this.lblArreglo.AutoSize = true;
            this.lblArreglo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArreglo.Location = new System.Drawing.Point(36, 91);
            this.lblArreglo.Name = "lblArreglo";
            this.lblArreglo.Size = new System.Drawing.Size(267, 24);
            this.lblArreglo.TabIndex = 14;
            this.lblArreglo.Text = "Ingrese el valor del arreglo:";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(318, 58);
            this.txtnumero.Multiline = true;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(80, 90);
            this.txtnumero.TabIndex = 13;
            this.txtnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumero_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Arreglos";
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.Location = new System.Drawing.Point(481, 58);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(93, 90);
            this.BtnMenu.TabIndex = 18;
            this.BtnMenu.Text = "Resgresar Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // FrmEjemplo5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(608, 306);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbArreglo);
            this.Controls.Add(this.lsbArreglo);
            this.Controls.Add(this.lblArreglo);
            this.Controls.Add(this.txtnumero);
            this.Name = "FrmEjemplo5";
            this.Text = "FrmEjemplo5";
            this.grbArreglo.ResumeLayout(false);
            this.grbArreglo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbArreglo;
        private System.Windows.Forms.Button btnmostrar1;
        private System.Windows.Forms.TextBox txtmayoposi;
        private System.Windows.Forms.TextBox txtpositivos;
        private System.Windows.Forms.TextBox txtprocentaje;
        private System.Windows.Forms.Label lblmayposi;
        private System.Windows.Forms.Label lblpositivos;
        private System.Windows.Forms.Label lblprocentaje;
        private System.Windows.Forms.Label lblnegativo;
        private System.Windows.Forms.TextBox txtnegativo;
        private System.Windows.Forms.ListBox lsbArreglo;
        private System.Windows.Forms.Label lblArreglo;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMenu;
    }
}
namespace Guia2_POO_RV202840
{
    partial class FrmConversiones
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
            this.label2 = new System.Windows.Forms.Label();
            this.LblRespuesta = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.RdbTemperatura = new System.Windows.Forms.RadioButton();
            this.RdbLongitud = new System.Windows.Forms.RadioButton();
            this.RdbPeso = new System.Windows.Forms.RadioButton();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingreso de datos:";
            // 
            // LblRespuesta
            // 
            this.LblRespuesta.AutoSize = true;
            this.LblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRespuesta.Location = new System.Drawing.Point(25, 214);
            this.LblRespuesta.Name = "LblRespuesta";
            this.LblRespuesta.Size = new System.Drawing.Size(99, 16);
            this.LblRespuesta.TabIndex = 2;
            this.LblRespuesta.Text = "Conversion a";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(330, 74);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(128, 48);
            this.BtnCalcular.TabIndex = 3;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(161, 86);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(100, 20);
            this.txtIngreso.TabIndex = 4;
            this.txtIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngreso_KeyPress);
            // 
            // RdbTemperatura
            // 
            this.RdbTemperatura.AutoSize = true;
            this.RdbTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbTemperatura.Location = new System.Drawing.Point(28, 128);
            this.RdbTemperatura.Name = "RdbTemperatura";
            this.RdbTemperatura.Size = new System.Drawing.Size(294, 20);
            this.RdbTemperatura.TabIndex = 5;
            this.RdbTemperatura.TabStop = true;
            this.RdbTemperatura.Text = "Temperatura (De Celsius a Fahrenheit)";
            this.RdbTemperatura.UseVisualStyleBackColor = true;
            // 
            // RdbLongitud
            // 
            this.RdbLongitud.AutoSize = true;
            this.RdbLongitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbLongitud.Location = new System.Drawing.Point(29, 154);
            this.RdbLongitud.Name = "RdbLongitud";
            this.RdbLongitud.Size = new System.Drawing.Size(218, 20);
            this.RdbLongitud.TabIndex = 6;
            this.RdbLongitud.TabStop = true;
            this.RdbLongitud.Text = "Longitud (De Metros a Pies)";
            this.RdbLongitud.UseVisualStyleBackColor = true;
            // 
            // RdbPeso
            // 
            this.RdbPeso.AutoSize = true;
            this.RdbPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbPeso.Location = new System.Drawing.Point(29, 180);
            this.RdbPeso.Name = "RdbPeso";
            this.RdbPeso.Size = new System.Drawing.Size(238, 20);
            this.RdbPeso.TabIndex = 7;
            this.RdbPeso.TabStop = true;
            this.RdbPeso.Text = "Peso (De Kilogramos a Libras)";
            this.RdbPeso.UseVisualStyleBackColor = true;
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Enabled = false;
            this.txtRespuesta.Location = new System.Drawing.Point(222, 213);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(100, 20);
            this.txtRespuesta.TabIndex = 8;
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.Location = new System.Drawing.Point(330, 128);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(128, 48);
            this.BtnMenu.TabIndex = 9;
            this.BtnMenu.Text = "Regreso Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // FrmConversiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(481, 250);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.RdbPeso);
            this.Controls.Add(this.RdbLongitud);
            this.Controls.Add(this.RdbTemperatura);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblRespuesta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmConversiones";
            this.Text = "FrmConversiones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblRespuesta;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.RadioButton RdbTemperatura;
        private System.Windows.Forms.RadioButton RdbLongitud;
        private System.Windows.Forms.RadioButton RdbPeso;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Button BtnMenu;
    }
}
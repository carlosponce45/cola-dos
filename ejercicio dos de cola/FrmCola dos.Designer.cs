namespace ejercicio_dos_de_cola
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbprioridad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtarchivo = new System.Windows.Forms.TextBox();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstalta = new System.Windows.Forms.ListBox();
            this.lstmedia = new System.Windows.Forms.ListBox();
            this.lstbaja = new System.Windows.Forms.ListBox();
            this.btnTomar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARCHIVO";
            // 
            // cmbprioridad
            // 
            this.cmbprioridad.FormattingEnabled = true;
            this.cmbprioridad.Location = new System.Drawing.Point(15, 148);
            this.cmbprioridad.Name = "cmbprioridad";
            this.cmbprioridad.Size = new System.Drawing.Size(121, 21);
            this.cmbprioridad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PRIORIDAD";
            // 
            // txtarchivo
            // 
            this.txtarchivo.Location = new System.Drawing.Point(15, 42);
            this.txtarchivo.Name = "txtarchivo";
            this.txtarchivo.Size = new System.Drawing.Size(100, 20);
            this.txtarchivo.TabIndex = 3;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(203, 148);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(75, 23);
            this.btnimprimir.TabIndex = 4;
            this.btnimprimir.Text = "IMPRIMIR";
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ALTA ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "MEDIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "BAJA";
            // 
            // lstalta
            // 
            this.lstalta.FormattingEnabled = true;
            this.lstalta.Location = new System.Drawing.Point(12, 212);
            this.lstalta.Name = "lstalta";
            this.lstalta.Size = new System.Drawing.Size(67, 121);
            this.lstalta.TabIndex = 8;
            // 
            // lstmedia
            // 
            this.lstmedia.FormattingEnabled = true;
            this.lstmedia.Location = new System.Drawing.Point(104, 212);
            this.lstmedia.Name = "lstmedia";
            this.lstmedia.Size = new System.Drawing.Size(64, 121);
            this.lstmedia.TabIndex = 9;
            // 
            // lstbaja
            // 
            this.lstbaja.FormattingEnabled = true;
            this.lstbaja.Location = new System.Drawing.Point(203, 212);
            this.lstbaja.Name = "lstbaja";
            this.lstbaja.Size = new System.Drawing.Size(65, 121);
            this.lstbaja.TabIndex = 10;
            // 
            // btnTomar
            // 
            this.btnTomar.Location = new System.Drawing.Point(203, 339);
            this.btnTomar.Name = "btnTomar";
            this.btnTomar.Size = new System.Drawing.Size(75, 23);
            this.btnTomar.TabIndex = 11;
            this.btnTomar.Text = "TOMAR";
            this.btnTomar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 367);
            this.Controls.Add(this.btnTomar);
            this.Controls.Add(this.lstbaja);
            this.Controls.Add(this.lstmedia);
            this.Controls.Add(this.lstalta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.txtarchivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbprioridad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "EJERCIO DOS COLA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbprioridad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtarchivo;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstalta;
        private System.Windows.Forms.ListBox lstmedia;
        private System.Windows.Forms.ListBox lstbaja;
        private System.Windows.Forms.Button btnTomar;
    }
}


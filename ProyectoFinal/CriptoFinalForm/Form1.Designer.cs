namespace CriptoFinalForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accionRealizar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mensajeFinal = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Seleccionar archivo de claves";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.subirArchivoClavesBoton);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Seleccionar archivo de texto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.subirArchivoMensajeBoton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(724, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Servicios de Inteligencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(196, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccionar la acción a realizar";
            // 
            // accionRealizar
            // 
            this.accionRealizar.FormattingEnabled = true;
            this.accionRealizar.Items.AddRange(new object[] {
            "Encriptar",
            "Desencriptar"});
            this.accionRealizar.Location = new System.Drawing.Point(356, 114);
            this.accionRealizar.Name = "accionRealizar";
            this.accionRealizar.Size = new System.Drawing.Size(121, 21);
            this.accionRealizar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mensaje:";
            // 
            // mensajeFinal
            // 
            this.mensajeFinal.AutoSize = true;
            this.mensajeFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mensajeFinal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mensajeFinal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mensajeFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajeFinal.Location = new System.Drawing.Point(378, 231);
            this.mensajeFinal.Name = "mensajeFinal";
            this.mensajeFinal.Size = new System.Drawing.Size(28, 27);
            this.mensajeFinal.TabIndex = 6;
            this.mensajeFinal.Text = "\"\"";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(308, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Encriptar/Desencriptar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.encriptarDesencriptarBoton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mensajeFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accionRealizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox accionRealizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mensajeFinal;
        private System.Windows.Forms.Button button3;
    }
}


namespace Practica1Fuentes
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
            this.lblLugarMancha = new System.Windows.Forms.Label();
            this.btnNegrita = new System.Windows.Forms.Button();
            this.btnCursiva = new System.Windows.Forms.Button();
            this.btnSubrayado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLugarMancha
            // 
            this.lblLugarMancha.AutoSize = true;
            this.lblLugarMancha.Location = new System.Drawing.Point(279, 110);
            this.lblLugarMancha.Name = "lblLugarMancha";
            this.lblLugarMancha.Size = new System.Drawing.Size(157, 16);
            this.lblLugarMancha.TabIndex = 0;
            this.lblLugarMancha.Text = "En un lugar de la Mancha";
            this.lblLugarMancha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNegrita
            // 
            this.btnNegrita.Location = new System.Drawing.Point(216, 151);
            this.btnNegrita.Name = "btnNegrita";
            this.btnNegrita.Size = new System.Drawing.Size(78, 30);
            this.btnNegrita.TabIndex = 1;
            this.btnNegrita.Text = "Negrita";
            this.btnNegrita.UseVisualStyleBackColor = true;
            this.btnNegrita.Click += new System.EventHandler(this.btnNegrita_Click);
            // 
            // btnCursiva
            // 
            this.btnCursiva.Location = new System.Drawing.Point(313, 151);
            this.btnCursiva.Name = "btnCursiva";
            this.btnCursiva.Size = new System.Drawing.Size(82, 30);
            this.btnCursiva.TabIndex = 2;
            this.btnCursiva.Text = "Cursiva";
            this.btnCursiva.UseVisualStyleBackColor = true;
            this.btnCursiva.Click += new System.EventHandler(this.btnCursiva_Click);
            // 
            // btnSubrayado
            // 
            this.btnSubrayado.Location = new System.Drawing.Point(423, 151);
            this.btnSubrayado.Name = "btnSubrayado";
            this.btnSubrayado.Size = new System.Drawing.Size(84, 30);
            this.btnSubrayado.TabIndex = 3;
            this.btnSubrayado.Text = "Subrayado";
            this.btnSubrayado.UseVisualStyleBackColor = true;
            this.btnSubrayado.Click += new System.EventHandler(this.btnSubrayado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubrayado);
            this.Controls.Add(this.btnCursiva);
            this.Controls.Add(this.btnNegrita);
            this.Controls.Add(this.lblLugarMancha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLugarMancha;
        private System.Windows.Forms.Button btnNegrita;
        private System.Windows.Forms.Button btnCursiva;
        private System.Windows.Forms.Button btnSubrayado;
    }
}


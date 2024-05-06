namespace PracticaFormativa.semana3
{
    partial class frmInicio
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
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnIngPerro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngreso
            // 
            this.btnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.Location = new System.Drawing.Point(252, 90);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(222, 80);
            this.btnIngreso.TabIndex = 0;
            this.btnIngreso.Text = "Uso de una clase";
            this.btnIngreso.UseVisualStyleBackColor = true;
            // 
            // btnIngPerro
            // 
            this.btnIngPerro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngPerro.Location = new System.Drawing.Point(252, 218);
            this.btnIngPerro.Name = "btnIngPerro";
            this.btnIngPerro.Size = new System.Drawing.Size(222, 80);
            this.btnIngPerro.TabIndex = 1;
            this.btnIngPerro.Text = "Ingresar Perro";
            this.btnIngPerro.UseVisualStyleBackColor = true;
            this.btnIngPerro.Click += new System.EventHandler(this.btnIngPerro_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIngPerro);
            this.Controls.Add(this.btnIngreso);
            this.Name = "frmInicio";
            this.Text = "Uso de Clases";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnIngPerro;
    }
}
namespace PracticaFormativa.Ventanas
{
    partial class frmVentana1
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
            this.btnNoModal = new System.Windows.Forms.Button();
            this.btnModal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNoModal
            // 
            this.btnNoModal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoModal.Location = new System.Drawing.Point(87, 71);
            this.btnNoModal.Name = "btnNoModal";
            this.btnNoModal.Size = new System.Drawing.Size(180, 89);
            this.btnNoModal.TabIndex = 0;
            this.btnNoModal.Text = "Ir a Formulario Dos\r\n(No Modal)\r\n";
            this.btnNoModal.UseVisualStyleBackColor = true;
            this.btnNoModal.Click += new System.EventHandler(this.btnNoModal_Click);
            // 
            // btnModal
            // 
            this.btnModal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModal.Location = new System.Drawing.Point(87, 218);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(180, 89);
            this.btnModal.TabIndex = 1;
            this.btnModal.Text = "Ir a Formulario \r\n( Modal )\r\n";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmVentana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 410);
            this.Controls.Add(this.btnModal);
            this.Controls.Add(this.btnNoModal);
            this.Name = "frmVentana1";
            this.Text = "frmVentana1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNoModal;
        private System.Windows.Forms.Button btnModal;
    }
}
namespace Telecommunication
{
    partial class Form2
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
            this.btnItirazListe = new System.Windows.Forms.Button();
            this.btnPrimListe = new System.Windows.Forms.Button();
            this.btnCagriListe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnItirazListe
            // 
            this.btnItirazListe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnItirazListe.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnItirazListe.Location = new System.Drawing.Point(96, 299);
            this.btnItirazListe.Name = "btnItirazListe";
            this.btnItirazListe.Size = new System.Drawing.Size(608, 60);
            this.btnItirazListe.TabIndex = 5;
            this.btnItirazListe.Text = "İtiraz Listesi Menüsü";
            this.btnItirazListe.UseVisualStyleBackColor = false;
            // 
            // btnPrimListe
            // 
            this.btnPrimListe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrimListe.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrimListe.Location = new System.Drawing.Point(96, 202);
            this.btnPrimListe.Name = "btnPrimListe";
            this.btnPrimListe.Size = new System.Drawing.Size(608, 55);
            this.btnPrimListe.TabIndex = 4;
            this.btnPrimListe.Text = "Aylık Prim Listesi Menüsü";
            this.btnPrimListe.UseVisualStyleBackColor = false;
            // 
            // btnCagriListe
            // 
            this.btnCagriListe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCagriListe.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCagriListe.Location = new System.Drawing.Point(96, 91);
            this.btnCagriListe.Name = "btnCagriListe";
            this.btnCagriListe.Size = new System.Drawing.Size(608, 61);
            this.btnCagriListe.TabIndex = 3;
            this.btnCagriListe.Text = "Müşteri Çağrı Listesi Menüsü";
            this.btnCagriListe.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnItirazListe);
            this.Controls.Add(this.btnPrimListe);
            this.Controls.Add(this.btnCagriListe);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnItirazListe;
        private System.Windows.Forms.Button btnPrimListe;
        private System.Windows.Forms.Button btnCagriListe;
    }
}
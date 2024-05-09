namespace Telecommunication
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAsistanGiris = new System.Windows.Forms.Button();
            this.btnTakimLiderGiris = new System.Windows.Forms.Button();
            this.btnGrupYöneticiGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAsistanGiris
            // 
            this.btnAsistanGiris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAsistanGiris.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAsistanGiris.Location = new System.Drawing.Point(60, 63);
            this.btnAsistanGiris.Name = "btnAsistanGiris";
            this.btnAsistanGiris.Size = new System.Drawing.Size(608, 61);
            this.btnAsistanGiris.TabIndex = 0;
            this.btnAsistanGiris.Text = "Asistan Girişi";
            this.btnAsistanGiris.UseVisualStyleBackColor = false;
            this.btnAsistanGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTakimLiderGiris
            // 
            this.btnTakimLiderGiris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTakimLiderGiris.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTakimLiderGiris.Location = new System.Drawing.Point(60, 174);
            this.btnTakimLiderGiris.Name = "btnTakimLiderGiris";
            this.btnTakimLiderGiris.Size = new System.Drawing.Size(608, 55);
            this.btnTakimLiderGiris.TabIndex = 1;
            this.btnTakimLiderGiris.Text = "Takım Lideri Giriş";
            this.btnTakimLiderGiris.UseVisualStyleBackColor = false;
            this.btnTakimLiderGiris.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGrupYöneticiGiris
            // 
            this.btnGrupYöneticiGiris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGrupYöneticiGiris.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGrupYöneticiGiris.Location = new System.Drawing.Point(60, 271);
            this.btnGrupYöneticiGiris.Name = "btnGrupYöneticiGiris";
            this.btnGrupYöneticiGiris.Size = new System.Drawing.Size(608, 60);
            this.btnGrupYöneticiGiris.TabIndex = 2;
            this.btnGrupYöneticiGiris.Text = "Grup Yöneticisi Giriş";
            this.btnGrupYöneticiGiris.UseVisualStyleBackColor = false;
            this.btnGrupYöneticiGiris.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGrupYöneticiGiris);
            this.Controls.Add(this.btnTakimLiderGiris);
            this.Controls.Add(this.btnAsistanGiris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAsistanGiris;
        private System.Windows.Forms.Button btnTakimLiderGiris;
        private System.Windows.Forms.Button btnGrupYöneticiGiris;
      
    }
}


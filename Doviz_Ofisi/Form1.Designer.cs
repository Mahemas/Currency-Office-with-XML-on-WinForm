namespace Doviz_Ofisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDA = new System.Windows.Forms.Label();
            this.lblDS = new System.Windows.Forms.Label();
            this.lblES = new System.Windows.Forms.Label();
            this.lblEA = new System.Windows.Forms.Label();
            this.btnDA = new System.Windows.Forms.Button();
            this.bntDS = new System.Windows.Forms.Button();
            this.btnEA = new System.Windows.Forms.Button();
            this.btnES = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKur = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtKalan = new System.Windows.Forms.TextBox();
            this.btnIslem1 = new System.Windows.Forms.Button();
            this.btnIslem2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alış:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dolar Satış:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(33, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Euro Alış:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MidnightBlue;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(24, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Euro Satış:";
            // 
            // lblDA
            // 
            this.lblDA.AutoSize = true;
            this.lblDA.BackColor = System.Drawing.Color.Black;
            this.lblDA.ForeColor = System.Drawing.Color.Red;
            this.lblDA.Location = new System.Drawing.Point(172, 27);
            this.lblDA.Name = "lblDA";
            this.lblDA.Size = new System.Drawing.Size(22, 24);
            this.lblDA.TabIndex = 4;
            this.lblDA.Text = "0";
            // 
            // lblDS
            // 
            this.lblDS.AutoSize = true;
            this.lblDS.BackColor = System.Drawing.Color.Black;
            this.lblDS.ForeColor = System.Drawing.Color.Red;
            this.lblDS.Location = new System.Drawing.Point(172, 64);
            this.lblDS.Name = "lblDS";
            this.lblDS.Size = new System.Drawing.Size(22, 24);
            this.lblDS.TabIndex = 5;
            this.lblDS.Text = "0";
            // 
            // lblES
            // 
            this.lblES.AutoSize = true;
            this.lblES.BackColor = System.Drawing.Color.Black;
            this.lblES.ForeColor = System.Drawing.Color.Red;
            this.lblES.Location = new System.Drawing.Point(172, 159);
            this.lblES.Name = "lblES";
            this.lblES.Size = new System.Drawing.Size(22, 24);
            this.lblES.TabIndex = 6;
            this.lblES.Text = "0";
            // 
            // lblEA
            // 
            this.lblEA.AutoSize = true;
            this.lblEA.BackColor = System.Drawing.Color.Black;
            this.lblEA.ForeColor = System.Drawing.Color.Red;
            this.lblEA.Location = new System.Drawing.Point(172, 123);
            this.lblEA.Name = "lblEA";
            this.lblEA.Size = new System.Drawing.Size(22, 24);
            this.lblEA.TabIndex = 7;
            this.lblEA.Text = "0";
            // 
            // btnDA
            // 
            this.btnDA.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDA.ForeColor = System.Drawing.Color.Lime;
            this.btnDA.Location = new System.Drawing.Point(253, 21);
            this.btnDA.Name = "btnDA";
            this.btnDA.Size = new System.Drawing.Size(50, 30);
            this.btnDA.TabIndex = 8;
            this.btnDA.Text = "...";
            this.btnDA.UseVisualStyleBackColor = false;
            this.btnDA.Click += new System.EventHandler(this.btnDA_Click);
            // 
            // bntDS
            // 
            this.bntDS.BackColor = System.Drawing.Color.MidnightBlue;
            this.bntDS.ForeColor = System.Drawing.Color.Lime;
            this.bntDS.Location = new System.Drawing.Point(253, 64);
            this.bntDS.Name = "bntDS";
            this.bntDS.Size = new System.Drawing.Size(50, 30);
            this.bntDS.TabIndex = 9;
            this.bntDS.Text = "...";
            this.bntDS.UseVisualStyleBackColor = false;
            this.bntDS.Click += new System.EventHandler(this.bntDS_Click);
            // 
            // btnEA
            // 
            this.btnEA.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEA.ForeColor = System.Drawing.Color.Lime;
            this.btnEA.Location = new System.Drawing.Point(253, 117);
            this.btnEA.Name = "btnEA";
            this.btnEA.Size = new System.Drawing.Size(50, 30);
            this.btnEA.TabIndex = 10;
            this.btnEA.Text = "...";
            this.btnEA.UseVisualStyleBackColor = false;
            this.btnEA.Click += new System.EventHandler(this.btnEA_Click);
            // 
            // btnES
            // 
            this.btnES.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnES.ForeColor = System.Drawing.Color.Lime;
            this.btnES.Location = new System.Drawing.Point(253, 156);
            this.btnES.Name = "btnES";
            this.btnES.Size = new System.Drawing.Size(50, 30);
            this.btnES.TabIndex = 11;
            this.btnES.Text = "...";
            this.btnES.UseVisualStyleBackColor = false;
            this.btnES.Click += new System.EventHandler(this.btnES_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnIslem2);
            this.groupBox1.Controls.Add(this.btnIslem1);
            this.groupBox1.Controls.Add(this.txtKalan);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.txtKur);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(290, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 237);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MidnightBlue;
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(63, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Kur:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MidnightBlue;
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(36, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "Miktar:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.MidnightBlue;
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(48, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 24);
            this.label11.TabIndex = 3;
            this.label11.Text = "Tutar:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.MidnightBlue;
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(45, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 24);
            this.label12.TabIndex = 4;
            this.label12.Text = "Kalan:";
            // 
            // txtKur
            // 
            this.txtKur.Location = new System.Drawing.Point(143, 33);
            this.txtKur.Name = "txtKur";
            this.txtKur.Size = new System.Drawing.Size(190, 30);
            this.txtKur.TabIndex = 5;
            this.txtKur.TextChanged += new System.EventHandler(this.txtKur_TextChanged);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(143, 70);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(190, 30);
            this.txtMiktar.TabIndex = 6;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(143, 110);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(190, 30);
            this.txtTutar.TabIndex = 7;
            // 
            // txtKalan
            // 
            this.txtKalan.Location = new System.Drawing.Point(143, 151);
            this.txtKalan.Name = "txtKalan";
            this.txtKalan.Size = new System.Drawing.Size(190, 30);
            this.txtKalan.TabIndex = 8;
            // 
            // btnIslem1
            // 
            this.btnIslem1.Location = new System.Drawing.Point(143, 187);
            this.btnIslem1.Name = "btnIslem1";
            this.btnIslem1.Size = new System.Drawing.Size(89, 30);
            this.btnIslem1.TabIndex = 9;
            this.btnIslem1.Text = "İşlem 1";
            this.btnIslem1.UseVisualStyleBackColor = true;
            this.btnIslem1.Click += new System.EventHandler(this.btnIslem1_Click);
            // 
            // btnIslem2
            // 
            this.btnIslem2.Location = new System.Drawing.Point(244, 187);
            this.btnIslem2.Name = "btnIslem2";
            this.btnIslem2.Size = new System.Drawing.Size(89, 30);
            this.btnIslem2.TabIndex = 10;
            this.btnIslem2.Text = "İşlem 2";
            this.btnIslem2.UseVisualStyleBackColor = true;
            this.btnIslem2.Click += new System.EventHandler(this.btnIslem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnES);
            this.Controls.Add(this.btnEA);
            this.Controls.Add(this.bntDS);
            this.Controls.Add(this.btnDA);
            this.Controls.Add(this.lblEA);
            this.Controls.Add(this.lblES);
            this.Controls.Add(this.lblDS);
            this.Controls.Add(this.lblDA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Döviz Bürosu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDA;
        private System.Windows.Forms.Label lblDS;
        private System.Windows.Forms.Label lblES;
        private System.Windows.Forms.Label lblEA;
        private System.Windows.Forms.Button btnDA;
        private System.Windows.Forms.Button bntDS;
        private System.Windows.Forms.Button btnEA;
        private System.Windows.Forms.Button btnES;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKalan;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtKur;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnIslem2;
        private System.Windows.Forms.Button btnIslem1;
    }
}


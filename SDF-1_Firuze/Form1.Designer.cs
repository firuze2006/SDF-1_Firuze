namespace SDF_1_Firuze
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIsciElaveAt = new System.Windows.Forms.Button();
            this.lblOdenisKodu = new System.Windows.Forms.Label();
            this.lblOdenisAdi = new System.Windows.Forms.Label();
            this.lblMebleg = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOdenisKodu = new System.Windows.Forms.TextBox();
            this.txtMebleg = new System.Windows.Forms.TextBox();
            this.txtOdenisAdi = new System.Windows.Forms.TextBox();
            this.btnOdenisYaz = new System.Windows.Forms.Button();
            this.lblAxtarKod = new System.Windows.Forms.Label();
            this.txtAxtarKod = new System.Windows.Forms.TextBox();
            this.btnAxtar = new System.Windows.Forms.Button();
            this.lstStatistika = new System.Windows.Forms.ListBox();
            this.btnCixis = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-3, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 394);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnIsciElaveAt);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtKod);
            this.tabPage1.Controls.Add(this.txtAd);
            this.tabPage1.Controls.Add(this.txtSoyad);
            this.tabPage1.Controls.Add(this.txtYas);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Isci elave et ";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnOdenisYaz);
            this.tabPage2.Controls.Add(this.txtOdenisAdi);
            this.tabPage2.Controls.Add(this.txtMebleg);
            this.tabPage2.Controls.Add(this.txtOdenisKodu);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lblMebleg);
            this.tabPage2.Controls.Add(this.lblOdenisAdi);
            this.tabPage2.Controls.Add(this.lblOdenisKodu);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(581, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Odenis yaz";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lstStatistika);
            this.tabPage3.Controls.Add(this.btnAxtar);
            this.tabPage3.Controls.Add(this.txtAxtarKod);
            this.tabPage3.Controls.Add(this.lblAxtarKod);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(581, 365);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Statistika";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Isci kodu";
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(236, 50);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(100, 22);
            this.txtYas.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(236, 150);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(11, 150);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 3;
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(11, 50);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(100, 22);
            this.txtKod.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Soyad";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnIsciElaveAt
            // 
            this.btnIsciElaveAt.Location = new System.Drawing.Point(139, 224);
            this.btnIsciElaveAt.Name = "btnIsciElaveAt";
            this.btnIsciElaveAt.Size = new System.Drawing.Size(154, 23);
            this.btnIsciElaveAt.TabIndex = 8;
            this.btnIsciElaveAt.Text = "Isci Elave Et";
            this.btnIsciElaveAt.UseVisualStyleBackColor = true;
            this.btnIsciElaveAt.Click += new System.EventHandler(this.btnIsciElaveAt_Click);
            // 
            // lblOdenisKodu
            // 
            this.lblOdenisKodu.AutoSize = true;
            this.lblOdenisKodu.Location = new System.Drawing.Point(43, 28);
            this.lblOdenisKodu.Name = "lblOdenisKodu";
            this.lblOdenisKodu.Size = new System.Drawing.Size(64, 16);
            this.lblOdenisKodu.TabIndex = 0;
            this.lblOdenisKodu.Text = "Isci Kodu:";
            // 
            // lblOdenisAdi
            // 
            this.lblOdenisAdi.AutoSize = true;
            this.lblOdenisAdi.Location = new System.Drawing.Point(43, 124);
            this.lblOdenisAdi.Name = "lblOdenisAdi";
            this.lblOdenisAdi.Size = new System.Drawing.Size(76, 16);
            this.lblOdenisAdi.TabIndex = 1;
            this.lblOdenisAdi.Text = "Odenis Adi:";
            // 
            // lblMebleg
            // 
            this.lblMebleg.AutoSize = true;
            this.lblMebleg.Location = new System.Drawing.Point(43, 231);
            this.lblMebleg.Name = "lblMebleg";
            this.lblMebleg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMebleg.Size = new System.Drawing.Size(56, 16);
            this.lblMebleg.TabIndex = 2;
            this.lblMebleg.Text = "Mebleg:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 3;
            // 
            // txtOdenisKodu
            // 
            this.txtOdenisKodu.Location = new System.Drawing.Point(46, 66);
            this.txtOdenisKodu.Name = "txtOdenisKodu";
            this.txtOdenisKodu.Size = new System.Drawing.Size(100, 22);
            this.txtOdenisKodu.TabIndex = 4;
            this.txtOdenisKodu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMebleg
            // 
            this.txtMebleg.Location = new System.Drawing.Point(46, 274);
            this.txtMebleg.Name = "txtMebleg";
            this.txtMebleg.Size = new System.Drawing.Size(100, 22);
            this.txtMebleg.TabIndex = 5;
            // 
            // txtOdenisAdi
            // 
            this.txtOdenisAdi.Location = new System.Drawing.Point(46, 166);
            this.txtOdenisAdi.Name = "txtOdenisAdi";
            this.txtOdenisAdi.Size = new System.Drawing.Size(100, 22);
            this.txtOdenisAdi.TabIndex = 6;
            // 
            // btnOdenisYaz
            // 
            this.btnOdenisYaz.Location = new System.Drawing.Point(164, 329);
            this.btnOdenisYaz.Name = "btnOdenisYaz";
            this.btnOdenisYaz.Size = new System.Drawing.Size(121, 23);
            this.btnOdenisYaz.TabIndex = 7;
            this.btnOdenisYaz.Text = "Odenis Yaz";
            this.btnOdenisYaz.UseVisualStyleBackColor = true;
            this.btnOdenisYaz.Click += new System.EventHandler(this.btnOdenisYaz_Click);
            // 
            // lblAxtarKod
            // 
            this.lblAxtarKod.AutoSize = true;
            this.lblAxtarKod.Location = new System.Drawing.Point(51, 28);
            this.lblAxtarKod.Name = "lblAxtarKod";
            this.lblAxtarKod.Size = new System.Drawing.Size(61, 16);
            this.lblAxtarKod.TabIndex = 0;
            this.lblAxtarKod.Text = "Isci Kodu";
            // 
            // txtAxtarKod
            // 
            this.txtAxtarKod.Location = new System.Drawing.Point(54, 74);
            this.txtAxtarKod.Name = "txtAxtarKod";
            this.txtAxtarKod.Size = new System.Drawing.Size(100, 22);
            this.txtAxtarKod.TabIndex = 1;
            // 
            // btnAxtar
            // 
            this.btnAxtar.Location = new System.Drawing.Point(54, 128);
            this.btnAxtar.Name = "btnAxtar";
            this.btnAxtar.Size = new System.Drawing.Size(75, 23);
            this.btnAxtar.TabIndex = 2;
            this.btnAxtar.Text = "Axtar";
            this.btnAxtar.UseVisualStyleBackColor = true;
            this.btnAxtar.Click += new System.EventHandler(this.btnAxtar_Click);
            // 
            // lstStatistika
            // 
            this.lstStatistika.FormattingEnabled = true;
            this.lstStatistika.ItemHeight = 16;
            this.lstStatistika.Location = new System.Drawing.Point(54, 183);
            this.lstStatistika.Name = "lstStatistika";
            this.lstStatistika.Size = new System.Drawing.Size(212, 116);
            this.lstStatistika.TabIndex = 3;
            this.lstStatistika.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnCixis
            // 
            this.btnCixis.Location = new System.Drawing.Point(481, 399);
            this.btnCixis.Name = "btnCixis";
            this.btnCixis.Size = new System.Drawing.Size(75, 23);
            this.btnCixis.TabIndex = 1;
            this.btnCixis.Text = "Cixis";
            this.btnCixis.UseVisualStyleBackColor = true;
            this.btnCixis.Click += new System.EventHandler(this.btnCixis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.btnCixis);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnIsciElaveAt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOdenisAdi;
        private System.Windows.Forms.TextBox txtMebleg;
        private System.Windows.Forms.TextBox txtOdenisKodu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMebleg;
        private System.Windows.Forms.Label lblOdenisAdi;
        private System.Windows.Forms.Label lblOdenisKodu;
        private System.Windows.Forms.Button btnOdenisYaz;
        private System.Windows.Forms.ListBox lstStatistika;
        private System.Windows.Forms.Button btnAxtar;
        private System.Windows.Forms.TextBox txtAxtarKod;
        private System.Windows.Forms.Label lblAxtarKod;
        private System.Windows.Forms.Button btnCixis;
    }
}


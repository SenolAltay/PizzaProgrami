namespace PizzaProgrami
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
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.cmbBoyut = new System.Windows.Forms.ComboBox();
            this.cmbhamurTipi = new System.Windows.Forms.ComboBox();
            this.rdbHayır = new System.Windows.Forms.RadioButton();
            this.rdbEvet = new System.Windows.Forms.RadioButton();
            this.chkSucuk = new System.Windows.Forms.CheckBox();
            this.chkDomates = new System.Windows.Forms.CheckBox();
            this.chkZeytin = new System.Windows.Forms.CheckBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkMısır = new System.Windows.Forms.CheckBox();
            this.chkMantar = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.rdmSucukMalzeme = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFiyataGore = new System.Windows.Forms.TextBox();
            this.btnFiyatKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(124, 277);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(109, 41);
            this.btnTemizle.TabIndex = 34;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(272, 277);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(108, 41);
            this.btnKaydet.TabIndex = 33;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(161, 179);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(168, 20);
            this.txtFiyat.TabIndex = 32;
            // 
            // cmbBoyut
            // 
            this.cmbBoyut.FormattingEnabled = true;
            this.cmbBoyut.Items.AddRange(new object[] {
            "Küçük",
            "Orta",
            "Büyük"});
            this.cmbBoyut.Location = new System.Drawing.Point(161, 152);
            this.cmbBoyut.Name = "cmbBoyut";
            this.cmbBoyut.Size = new System.Drawing.Size(168, 21);
            this.cmbBoyut.TabIndex = 31;
            // 
            // cmbhamurTipi
            // 
            this.cmbhamurTipi.FormattingEnabled = true;
            this.cmbhamurTipi.Items.AddRange(new object[] {
            "İnce",
            "Normal",
            "Kalın"});
            this.cmbhamurTipi.Location = new System.Drawing.Point(164, 66);
            this.cmbhamurTipi.Name = "cmbhamurTipi";
            this.cmbhamurTipi.Size = new System.Drawing.Size(165, 21);
            this.cmbhamurTipi.TabIndex = 30;
            // 
            // rdbHayır
            // 
            this.rdbHayır.AutoSize = true;
            this.rdbHayır.Location = new System.Drawing.Point(272, 126);
            this.rdbHayır.Name = "rdbHayır";
            this.rdbHayır.Size = new System.Drawing.Size(49, 17);
            this.rdbHayır.TabIndex = 29;
            this.rdbHayır.TabStop = true;
            this.rdbHayır.Text = "Hayır";
            this.rdbHayır.UseVisualStyleBackColor = true;
            // 
            // rdbEvet
            // 
            this.rdbEvet.AutoSize = true;
            this.rdbEvet.Location = new System.Drawing.Point(161, 126);
            this.rdbEvet.Name = "rdbEvet";
            this.rdbEvet.Size = new System.Drawing.Size(47, 17);
            this.rdbEvet.TabIndex = 28;
            this.rdbEvet.TabStop = true;
            this.rdbEvet.Text = "Evet";
            this.rdbEvet.UseVisualStyleBackColor = true;
            // 
            // chkSucuk
            // 
            this.chkSucuk.AutoSize = true;
            this.chkSucuk.Location = new System.Drawing.Point(272, 99);
            this.chkSucuk.Name = "chkSucuk";
            this.chkSucuk.Size = new System.Drawing.Size(57, 17);
            this.chkSucuk.TabIndex = 27;
            this.chkSucuk.Text = "Sucuk";
            this.chkSucuk.UseVisualStyleBackColor = true;
            // 
            // chkDomates
            // 
            this.chkDomates.AutoSize = true;
            this.chkDomates.Location = new System.Drawing.Point(210, 99);
            this.chkDomates.Name = "chkDomates";
            this.chkDomates.Size = new System.Drawing.Size(68, 17);
            this.chkDomates.TabIndex = 26;
            this.chkDomates.Text = "Domates";
            this.chkDomates.UseVisualStyleBackColor = true;
            // 
            // chkZeytin
            // 
            this.chkZeytin.AutoSize = true;
            this.chkZeytin.Location = new System.Drawing.Point(161, 99);
            this.chkZeytin.Name = "chkZeytin";
            this.chkZeytin.Size = new System.Drawing.Size(55, 17);
            this.chkZeytin.TabIndex = 25;
            this.chkZeytin.Text = "Zeytin";
            this.chkZeytin.UseVisualStyleBackColor = true;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(164, 40);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(165, 20);
            this.txtAd.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(113, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(108, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Boyut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Domates Sosu Var Mı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(72, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Malzemeler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(77, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Hamur Tipi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(121, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Adı";
            // 
            // chkMısır
            // 
            this.chkMısır.AutoSize = true;
            this.chkMısır.Location = new System.Drawing.Point(335, 99);
            this.chkMısır.Name = "chkMısır";
            this.chkMısır.Size = new System.Drawing.Size(47, 17);
            this.chkMısır.TabIndex = 35;
            this.chkMısır.Text = "Mısır";
            this.chkMısır.UseVisualStyleBackColor = true;
            // 
            // chkMantar
            // 
            this.chkMantar.AutoSize = true;
            this.chkMantar.Location = new System.Drawing.Point(398, 100);
            this.chkMantar.Name = "chkMantar";
            this.chkMantar.Size = new System.Drawing.Size(59, 17);
            this.chkMantar.TabIndex = 36;
            this.chkMantar.Text = "Mantar";
            this.chkMantar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(477, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(215, 239);
            this.dataGridView1.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(57, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "Varmı Sorgusu";
            // 
            // rdmSucukMalzeme
            // 
            this.rdmSucukMalzeme.AutoSize = true;
            this.rdmSucukMalzeme.Location = new System.Drawing.Point(161, 206);
            this.rdmSucukMalzeme.Name = "rdmSucukMalzeme";
            this.rdmSucukMalzeme.Size = new System.Drawing.Size(56, 17);
            this.rdmSucukMalzeme.TabIndex = 39;
            this.rdmSucukMalzeme.TabStop = true;
            this.rdmSucukMalzeme.Text = "Sucuk";
            this.rdmSucukMalzeme.UseVisualStyleBackColor = true;
            this.rdmSucukMalzeme.CheckedChanged += new System.EventHandler(this.rdmSucukMalzeme_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(44, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "Fiyata göre sorgu";
            // 
            // txtFiyataGore
            // 
            this.txtFiyataGore.Location = new System.Drawing.Point(161, 226);
            this.txtFiyataGore.Name = "txtFiyataGore";
            this.txtFiyataGore.Size = new System.Drawing.Size(168, 20);
            this.txtFiyataGore.TabIndex = 41;
            // 
            // btnFiyatKaydet
            // 
            this.btnFiyatKaydet.Location = new System.Drawing.Point(335, 224);
            this.btnFiyatKaydet.Name = "btnFiyatKaydet";
            this.btnFiyatKaydet.Size = new System.Drawing.Size(100, 23);
            this.btnFiyatKaydet.TabIndex = 42;
            this.btnFiyatKaydet.Text = "Kaydet";
            this.btnFiyatKaydet.UseVisualStyleBackColor = true;
            this.btnFiyatKaydet.Click += new System.EventHandler(this.btnFiyatKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(716, 344);
            this.Controls.Add(this.btnFiyatKaydet);
            this.Controls.Add(this.txtFiyataGore);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rdmSucukMalzeme);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chkMantar);
            this.Controls.Add(this.chkMısır);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.cmbBoyut);
            this.Controls.Add(this.cmbhamurTipi);
            this.Controls.Add(this.rdbHayır);
            this.Controls.Add(this.rdbEvet);
            this.Controls.Add(this.chkSucuk);
            this.Controls.Add(this.chkDomates);
            this.Controls.Add(this.chkZeytin);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.ComboBox cmbBoyut;
        private System.Windows.Forms.ComboBox cmbhamurTipi;
        private System.Windows.Forms.RadioButton rdbHayır;
        private System.Windows.Forms.RadioButton rdbEvet;
        private System.Windows.Forms.CheckBox chkSucuk;
        private System.Windows.Forms.CheckBox chkDomates;
        private System.Windows.Forms.CheckBox chkZeytin;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkMısır;
        private System.Windows.Forms.CheckBox chkMantar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdmSucukMalzeme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFiyataGore;
        private System.Windows.Forms.Button btnFiyatKaydet;
    }
}


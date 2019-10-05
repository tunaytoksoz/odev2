namespace odev2
{
    partial class Hesaplama
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
            this.components = new System.ComponentModel.Container();
            this.mtxtbAltSinir = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbUstSinir = new System.Windows.Forms.MaskedTextBox();
            this.lblAltSinir = new System.Windows.Forms.Label();
            this.lblUstSinir = new System.Windows.Forms.Label();
            this.grpGirisBilgileri = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.tabSonuc = new System.Windows.Forms.TabControl();
            this.tabTekSayilar = new System.Windows.Forms.TabPage();
            this.lblTekToplam = new System.Windows.Forms.Label();
            this.lblTekCarpim = new System.Windows.Forms.Label();
            this.txtTekToplam = new System.Windows.Forms.TextBox();
            this.lvTekSayilar = new System.Windows.Forms.ListView();
            this.txtTekCarpim = new System.Windows.Forms.TextBox();
            this.tabCiftSayilar = new System.Windows.Forms.TabPage();
            this.lvCiftSayilar = new System.Windows.Forms.ListView();
            this.lblCiftToplam = new System.Windows.Forms.Label();
            this.lblCiftCarpim = new System.Windows.Forms.Label();
            this.txtCiftCarpim = new System.Windows.Forms.TextBox();
            this.txtCiftToplam = new System.Windows.Forms.TextBox();
            this.tabAsalSayi = new System.Windows.Forms.TabPage();
            this.lvAsalSayilar = new System.Windows.Forms.ListView();
            this.lblAsalToplam = new System.Windows.Forms.Label();
            this.lblAsalCarpim = new System.Windows.Forms.Label();
            this.txtAsalCarpim = new System.Windows.Forms.TextBox();
            this.txtAsalToplam = new System.Windows.Forms.TextBox();
            this.tabArmstrong = new System.Windows.Forms.TabPage();
            this.lvArmSayilar = new System.Windows.Forms.ListView();
            this.lblArmToplam = new System.Windows.Forms.Label();
            this.lblArmCarpim = new System.Windows.Forms.Label();
            this.txtArmCarpim = new System.Windows.Forms.TextBox();
            this.txtArmToplam = new System.Windows.Forms.TextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnIleri = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.nfIBildirim = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpGirisBilgileri.SuspendLayout();
            this.tabSonuc.SuspendLayout();
            this.tabTekSayilar.SuspendLayout();
            this.tabCiftSayilar.SuspendLayout();
            this.tabAsalSayi.SuspendLayout();
            this.tabArmstrong.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtxtbAltSinir
            // 
            this.mtxtbAltSinir.Location = new System.Drawing.Point(102, 29);
            this.mtxtbAltSinir.Mask = "00000";
            this.mtxtbAltSinir.Name = "mtxtbAltSinir";
            this.mtxtbAltSinir.Size = new System.Drawing.Size(100, 20);
            this.mtxtbAltSinir.TabIndex = 0;
            this.mtxtbAltSinir.ValidatingType = typeof(int);
            // 
            // mtxtbUstSinir
            // 
            this.mtxtbUstSinir.Location = new System.Drawing.Point(102, 66);
            this.mtxtbUstSinir.Mask = "00000";
            this.mtxtbUstSinir.Name = "mtxtbUstSinir";
            this.mtxtbUstSinir.Size = new System.Drawing.Size(100, 20);
            this.mtxtbUstSinir.TabIndex = 1;
            this.mtxtbUstSinir.ValidatingType = typeof(int);
            // 
            // lblAltSinir
            // 
            this.lblAltSinir.AutoSize = true;
            this.lblAltSinir.Location = new System.Drawing.Point(31, 36);
            this.lblAltSinir.Name = "lblAltSinir";
            this.lblAltSinir.Size = new System.Drawing.Size(42, 13);
            this.lblAltSinir.TabIndex = 2;
            this.lblAltSinir.Text = "Alt Sınır";
            // 
            // lblUstSinir
            // 
            this.lblUstSinir.AutoSize = true;
            this.lblUstSinir.Location = new System.Drawing.Point(31, 69);
            this.lblUstSinir.Name = "lblUstSinir";
            this.lblUstSinir.Size = new System.Drawing.Size(46, 13);
            this.lblUstSinir.TabIndex = 3;
            this.lblUstSinir.Text = "Üst Sınır";
            // 
            // grpGirisBilgileri
            // 
            this.grpGirisBilgileri.Controls.Add(this.btnTemizle);
            this.grpGirisBilgileri.Controls.Add(this.btnHesapla);
            this.grpGirisBilgileri.Controls.Add(this.lblAltSinir);
            this.grpGirisBilgileri.Controls.Add(this.lblUstSinir);
            this.grpGirisBilgileri.Controls.Add(this.mtxtbAltSinir);
            this.grpGirisBilgileri.Controls.Add(this.mtxtbUstSinir);
            this.grpGirisBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpGirisBilgileri.Name = "grpGirisBilgileri";
            this.grpGirisBilgileri.Size = new System.Drawing.Size(775, 108);
            this.grpGirisBilgileri.TabIndex = 4;
            this.grpGirisBilgileri.TabStop = false;
            this.grpGirisBilgileri.Text = "Giriş Bilgileri";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(350, 64);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(251, 63);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // tabSonuc
            // 
            this.tabSonuc.Controls.Add(this.tabTekSayilar);
            this.tabSonuc.Controls.Add(this.tabCiftSayilar);
            this.tabSonuc.Controls.Add(this.tabAsalSayi);
            this.tabSonuc.Controls.Add(this.tabArmstrong);
            this.tabSonuc.Location = new System.Drawing.Point(12, 126);
            this.tabSonuc.Name = "tabSonuc";
            this.tabSonuc.SelectedIndex = 0;
            this.tabSonuc.Size = new System.Drawing.Size(779, 249);
            this.tabSonuc.TabIndex = 6;
            // 
            // tabTekSayilar
            // 
            this.tabTekSayilar.Controls.Add(this.lblTekToplam);
            this.tabTekSayilar.Controls.Add(this.lblTekCarpim);
            this.tabTekSayilar.Controls.Add(this.txtTekToplam);
            this.tabTekSayilar.Controls.Add(this.lvTekSayilar);
            this.tabTekSayilar.Controls.Add(this.txtTekCarpim);
            this.tabTekSayilar.Location = new System.Drawing.Point(4, 22);
            this.tabTekSayilar.Name = "tabTekSayilar";
            this.tabTekSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabTekSayilar.Size = new System.Drawing.Size(771, 223);
            this.tabTekSayilar.TabIndex = 0;
            this.tabTekSayilar.Text = "Tek Sayilar";
            this.tabTekSayilar.UseVisualStyleBackColor = true;
            // 
            // lblTekToplam
            // 
            this.lblTekToplam.AutoSize = true;
            this.lblTekToplam.Location = new System.Drawing.Point(199, 13);
            this.lblTekToplam.Name = "lblTekToplam";
            this.lblTekToplam.Size = new System.Drawing.Size(42, 13);
            this.lblTekToplam.TabIndex = 4;
            this.lblTekToplam.Text = "Toplam";
            // 
            // lblTekCarpim
            // 
            this.lblTekCarpim.AutoSize = true;
            this.lblTekCarpim.Location = new System.Drawing.Point(6, 13);
            this.lblTekCarpim.Name = "lblTekCarpim";
            this.lblTekCarpim.Size = new System.Drawing.Size(39, 13);
            this.lblTekCarpim.TabIndex = 3;
            this.lblTekCarpim.Text = "Çarpım";
            // 
            // txtTekToplam
            // 
            this.txtTekToplam.Location = new System.Drawing.Point(247, 10);
            this.txtTekToplam.Name = "txtTekToplam";
            this.txtTekToplam.ReadOnly = true;
            this.txtTekToplam.Size = new System.Drawing.Size(100, 20);
            this.txtTekToplam.TabIndex = 2;
            // 
            // lvTekSayilar
            // 
            this.lvTekSayilar.Location = new System.Drawing.Point(0, 32);
            this.lvTekSayilar.Name = "lvTekSayilar";
            this.lvTekSayilar.Size = new System.Drawing.Size(775, 191);
            this.lvTekSayilar.TabIndex = 1;
            this.lvTekSayilar.UseCompatibleStateImageBehavior = false;
            this.lvTekSayilar.View = System.Windows.Forms.View.List;
            // 
            // txtTekCarpim
            // 
            this.txtTekCarpim.Location = new System.Drawing.Point(51, 9);
            this.txtTekCarpim.Name = "txtTekCarpim";
            this.txtTekCarpim.ReadOnly = true;
            this.txtTekCarpim.Size = new System.Drawing.Size(100, 20);
            this.txtTekCarpim.TabIndex = 0;
            // 
            // tabCiftSayilar
            // 
            this.tabCiftSayilar.Controls.Add(this.lvCiftSayilar);
            this.tabCiftSayilar.Controls.Add(this.lblCiftToplam);
            this.tabCiftSayilar.Controls.Add(this.lblCiftCarpim);
            this.tabCiftSayilar.Controls.Add(this.txtCiftCarpim);
            this.tabCiftSayilar.Controls.Add(this.txtCiftToplam);
            this.tabCiftSayilar.Location = new System.Drawing.Point(4, 22);
            this.tabCiftSayilar.Name = "tabCiftSayilar";
            this.tabCiftSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCiftSayilar.Size = new System.Drawing.Size(771, 223);
            this.tabCiftSayilar.TabIndex = 1;
            this.tabCiftSayilar.Text = "Çift Sayilar";
            this.tabCiftSayilar.UseVisualStyleBackColor = true;
            // 
            // lvCiftSayilar
            // 
            this.lvCiftSayilar.Location = new System.Drawing.Point(-3, 32);
            this.lvCiftSayilar.Name = "lvCiftSayilar";
            this.lvCiftSayilar.Size = new System.Drawing.Size(775, 191);
            this.lvCiftSayilar.TabIndex = 7;
            this.lvCiftSayilar.UseCompatibleStateImageBehavior = false;
            this.lvCiftSayilar.View = System.Windows.Forms.View.List;
            // 
            // lblCiftToplam
            // 
            this.lblCiftToplam.AutoSize = true;
            this.lblCiftToplam.Location = new System.Drawing.Point(234, 13);
            this.lblCiftToplam.Name = "lblCiftToplam";
            this.lblCiftToplam.Size = new System.Drawing.Size(42, 13);
            this.lblCiftToplam.TabIndex = 6;
            this.lblCiftToplam.Text = "Toplam";
            // 
            // lblCiftCarpim
            // 
            this.lblCiftCarpim.AutoSize = true;
            this.lblCiftCarpim.Location = new System.Drawing.Point(12, 13);
            this.lblCiftCarpim.Name = "lblCiftCarpim";
            this.lblCiftCarpim.Size = new System.Drawing.Size(39, 13);
            this.lblCiftCarpim.TabIndex = 5;
            this.lblCiftCarpim.Text = "Çarpım";
            // 
            // txtCiftCarpim
            // 
            this.txtCiftCarpim.Location = new System.Drawing.Point(57, 10);
            this.txtCiftCarpim.Name = "txtCiftCarpim";
            this.txtCiftCarpim.ReadOnly = true;
            this.txtCiftCarpim.Size = new System.Drawing.Size(100, 20);
            this.txtCiftCarpim.TabIndex = 4;
            // 
            // txtCiftToplam
            // 
            this.txtCiftToplam.Location = new System.Drawing.Point(295, 10);
            this.txtCiftToplam.Name = "txtCiftToplam";
            this.txtCiftToplam.ReadOnly = true;
            this.txtCiftToplam.Size = new System.Drawing.Size(100, 20);
            this.txtCiftToplam.TabIndex = 3;
            // 
            // tabAsalSayi
            // 
            this.tabAsalSayi.Controls.Add(this.lvAsalSayilar);
            this.tabAsalSayi.Controls.Add(this.lblAsalToplam);
            this.tabAsalSayi.Controls.Add(this.lblAsalCarpim);
            this.tabAsalSayi.Controls.Add(this.txtAsalCarpim);
            this.tabAsalSayi.Controls.Add(this.txtAsalToplam);
            this.tabAsalSayi.Location = new System.Drawing.Point(4, 22);
            this.tabAsalSayi.Name = "tabAsalSayi";
            this.tabAsalSayi.Size = new System.Drawing.Size(771, 223);
            this.tabAsalSayi.TabIndex = 2;
            this.tabAsalSayi.Text = "Asal Sayılar";
            this.tabAsalSayi.UseVisualStyleBackColor = true;
            // 
            // lvAsalSayilar
            // 
            this.lvAsalSayilar.Location = new System.Drawing.Point(0, 32);
            this.lvAsalSayilar.Name = "lvAsalSayilar";
            this.lvAsalSayilar.Size = new System.Drawing.Size(772, 191);
            this.lvAsalSayilar.TabIndex = 11;
            this.lvAsalSayilar.UseCompatibleStateImageBehavior = false;
            this.lvAsalSayilar.View = System.Windows.Forms.View.List;
            // 
            // lblAsalToplam
            // 
            this.lblAsalToplam.AutoSize = true;
            this.lblAsalToplam.Location = new System.Drawing.Point(244, 17);
            this.lblAsalToplam.Name = "lblAsalToplam";
            this.lblAsalToplam.Size = new System.Drawing.Size(42, 13);
            this.lblAsalToplam.TabIndex = 10;
            this.lblAsalToplam.Text = "Toplam";
            // 
            // lblAsalCarpim
            // 
            this.lblAsalCarpim.AutoSize = true;
            this.lblAsalCarpim.Location = new System.Drawing.Point(18, 16);
            this.lblAsalCarpim.Name = "lblAsalCarpim";
            this.lblAsalCarpim.Size = new System.Drawing.Size(39, 13);
            this.lblAsalCarpim.TabIndex = 9;
            this.lblAsalCarpim.Text = "Çarpım";
            // 
            // txtAsalCarpim
            // 
            this.txtAsalCarpim.Location = new System.Drawing.Point(63, 10);
            this.txtAsalCarpim.Name = "txtAsalCarpim";
            this.txtAsalCarpim.ReadOnly = true;
            this.txtAsalCarpim.Size = new System.Drawing.Size(100, 20);
            this.txtAsalCarpim.TabIndex = 8;
            // 
            // txtAsalToplam
            // 
            this.txtAsalToplam.Location = new System.Drawing.Point(301, 10);
            this.txtAsalToplam.Name = "txtAsalToplam";
            this.txtAsalToplam.ReadOnly = true;
            this.txtAsalToplam.Size = new System.Drawing.Size(100, 20);
            this.txtAsalToplam.TabIndex = 7;
            // 
            // tabArmstrong
            // 
            this.tabArmstrong.Controls.Add(this.lvArmSayilar);
            this.tabArmstrong.Controls.Add(this.lblArmToplam);
            this.tabArmstrong.Controls.Add(this.lblArmCarpim);
            this.tabArmstrong.Controls.Add(this.txtArmCarpim);
            this.tabArmstrong.Controls.Add(this.txtArmToplam);
            this.tabArmstrong.Location = new System.Drawing.Point(4, 22);
            this.tabArmstrong.Name = "tabArmstrong";
            this.tabArmstrong.Size = new System.Drawing.Size(771, 223);
            this.tabArmstrong.TabIndex = 3;
            this.tabArmstrong.Text = "Armstrong Sayılar";
            this.tabArmstrong.UseVisualStyleBackColor = true;
            // 
            // lvArmSayilar
            // 
            this.lvArmSayilar.Location = new System.Drawing.Point(0, 36);
            this.lvArmSayilar.Name = "lvArmSayilar";
            this.lvArmSayilar.Size = new System.Drawing.Size(772, 191);
            this.lvArmSayilar.TabIndex = 16;
            this.lvArmSayilar.UseCompatibleStateImageBehavior = false;
            this.lvArmSayilar.View = System.Windows.Forms.View.List;
            // 
            // lblArmToplam
            // 
            this.lblArmToplam.AutoSize = true;
            this.lblArmToplam.Location = new System.Drawing.Point(234, 21);
            this.lblArmToplam.Name = "lblArmToplam";
            this.lblArmToplam.Size = new System.Drawing.Size(42, 13);
            this.lblArmToplam.TabIndex = 15;
            this.lblArmToplam.Text = "Toplam";
            // 
            // lblArmCarpim
            // 
            this.lblArmCarpim.AutoSize = true;
            this.lblArmCarpim.Location = new System.Drawing.Point(16, 17);
            this.lblArmCarpim.Name = "lblArmCarpim";
            this.lblArmCarpim.Size = new System.Drawing.Size(39, 13);
            this.lblArmCarpim.TabIndex = 14;
            this.lblArmCarpim.Text = "Çarpım";
            // 
            // txtArmCarpim
            // 
            this.txtArmCarpim.Location = new System.Drawing.Point(61, 14);
            this.txtArmCarpim.Name = "txtArmCarpim";
            this.txtArmCarpim.ReadOnly = true;
            this.txtArmCarpim.Size = new System.Drawing.Size(100, 20);
            this.txtArmCarpim.TabIndex = 13;
            // 
            // txtArmToplam
            // 
            this.txtArmToplam.Location = new System.Drawing.Point(297, 14);
            this.txtArmToplam.Name = "txtArmToplam";
            this.txtArmToplam.ReadOnly = true;
            this.txtArmToplam.Size = new System.Drawing.Size(100, 20);
            this.txtArmToplam.TabIndex = 12;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(263, 381);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "<< Geri <<";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(412, 381);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(75, 23);
            this.btnIleri.TabIndex = 8;
            this.btnIleri.Text = ">> İleri >>";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.BtnIleri_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // nfIBildirim
            // 
            this.nfIBildirim.Text = "Bildirim";
            this.nfIBildirim.Visible = true;
            // 
            // Hesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 416);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.tabSonuc);
            this.Controls.Add(this.grpGirisBilgileri);
            this.Name = "Hesaplama";
            this.Text = "Hesaplama";
            this.Load += new System.EventHandler(this.Hesaplama_Load);
            this.grpGirisBilgileri.ResumeLayout(false);
            this.grpGirisBilgileri.PerformLayout();
            this.tabSonuc.ResumeLayout(false);
            this.tabTekSayilar.ResumeLayout(false);
            this.tabTekSayilar.PerformLayout();
            this.tabCiftSayilar.ResumeLayout(false);
            this.tabCiftSayilar.PerformLayout();
            this.tabAsalSayi.ResumeLayout(false);
            this.tabAsalSayi.PerformLayout();
            this.tabArmstrong.ResumeLayout(false);
            this.tabArmstrong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtbAltSinir;
        private System.Windows.Forms.MaskedTextBox mtxtbUstSinir;
        private System.Windows.Forms.Label lblAltSinir;
        private System.Windows.Forms.Label lblUstSinir;
        private System.Windows.Forms.GroupBox grpGirisBilgileri;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TabControl tabSonuc;
        private System.Windows.Forms.TabPage tabTekSayilar;
        private System.Windows.Forms.TabPage tabCiftSayilar;
        private System.Windows.Forms.TabPage tabAsalSayi;
        private System.Windows.Forms.TabPage tabArmstrong;
        private System.Windows.Forms.ListView lvTekSayilar;
        private System.Windows.Forms.TextBox txtTekCarpim;
        private System.Windows.Forms.TextBox txtTekToplam;
        private System.Windows.Forms.Label lblTekCarpim;
        private System.Windows.Forms.Label lblTekToplam;
        private System.Windows.Forms.Label lblCiftToplam;
        private System.Windows.Forms.Label lblCiftCarpim;
        private System.Windows.Forms.TextBox txtCiftCarpim;
        private System.Windows.Forms.TextBox txtCiftToplam;
        private System.Windows.Forms.Label lblAsalToplam;
        private System.Windows.Forms.Label lblAsalCarpim;
        private System.Windows.Forms.TextBox txtAsalCarpim;
        private System.Windows.Forms.TextBox txtAsalToplam;
        private System.Windows.Forms.ListView lvCiftSayilar;
        private System.Windows.Forms.ListView lvAsalSayilar;
        private System.Windows.Forms.ListView lvArmSayilar;
        private System.Windows.Forms.Label lblArmToplam;
        private System.Windows.Forms.Label lblArmCarpim;
        private System.Windows.Forms.TextBox txtArmCarpim;
        private System.Windows.Forms.TextBox txtArmToplam;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon nfIBildirim;
    }
}


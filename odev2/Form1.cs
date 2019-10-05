using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace odev2
{
    public partial class Hesaplama : Form
    {
        public Hesaplama()
        {
            InitializeComponent();
        }

        private void temizle()
        {
            if (tabSonuc.SelectedTab == tabTekSayilar)
            {
                lvTekSayilar.Clear();
                txtTekCarpim.Clear();
                txtTekToplam.Clear();
                ekranHazirla();
            }
            else if (tabSonuc.SelectedTab == tabCiftSayilar)
            {
                lvCiftSayilar.Clear();
                txtCiftCarpim.Clear();
                ekranHazirla();
            }
            else if (tabSonuc.SelectedTab == tabAsalSayi)
            {
                lvAsalSayilar.Clear();
                txtAsalToplam.Clear();
                txtAsalCarpim.Clear();
                ekranHazirla();
            }
            else if (tabSonuc.SelectedTab == tabArmstrong)
            {
                lvArmSayilar.Clear();
                txtArmCarpim.Clear();
                txtArmToplam.Clear();
                ekranHazirla();
            }
        }
        private void ekranHazirla()
        {
            mtxtbAltSinir.Focus();
            mtxtbAltSinir.Clear();
            mtxtbUstSinir.Clear();
        }

        void dosyaYazdirma(string islemTuru,int carpim, int toplam)
        {
            int altSinir = Convert.ToInt32(mtxtbAltSinir.Text);
            int ustSinir = Convert.ToInt32(mtxtbUstSinir.Text);
            using (StreamWriter islem = new StreamWriter("denemelog.txt",true))
            {
                string zaman = DateTime.Now.ToString();
                islem.WriteLine("İşlem Türü:" + islemTuru + "\nAlt sınır: " + altSinir.ToString() + " Üst sınır:" + ustSinir.ToString() + " Carpim:" + carpim + " Toplam:" + toplam + "\nTarih ve Saat:" + zaman + "\n");
            }
            
        }
        private Boolean Dogrula()
        {
            if(Convert.ToInt32(mtxtbAltSinir.Text) < Convert.ToInt32(mtxtbUstSinir.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private Boolean kontrol()
        {
            try
            {
                Convert.ToInt32(mtxtbAltSinir.Text);
                Convert.ToInt32(mtxtbUstSinir.Text);
                
                return true;
            }
            catch (Exception)
            {

                return false;
            }

           
        }
        int tekSayilarToplam()
        {
            int tekToplam = 0;
            int altSinir = Convert.ToInt32(mtxtbAltSinir.Text);
            int ustSinir = Convert.ToInt32(mtxtbUstSinir.Text);

            for (int i = altSinir; i <= ustSinir; i++)
            {
                if ((i % 2) == 1)
                {
                    tekToplam += i;
                    lvTekSayilar.Items.Add(i.ToString());
                }
            }
            txtTekToplam.Text = tekToplam.ToString();
            return tekToplam;
        }
        int ciftSayilarToplam()
        {
            int ciftToplam = 0;
            int altSinir = Convert.ToInt32(mtxtbAltSinir.Text);
            int ustSinir = Convert.ToInt32(mtxtbUstSinir.Text);

            for (int i = altSinir; i <= ustSinir; i++)
            {
                if ((i % 2) == 0)
                {
                    ciftToplam += i;
                    lvCiftSayilar.Items.Add(i.ToString());
                }
            }
            txtCiftToplam.Text = ciftToplam.ToString();
            return ciftToplam;
        }
        BigInteger tekSayilarCarpim()
        {
            int tekCarpim = 1;
            int altSinir = Convert.ToInt32(mtxtbAltSinir.Text);
            int ustSinir = Convert.ToInt32(mtxtbUstSinir.Text);

            for (int i = altSinir; i <= ustSinir; i++)
            {
                if ((i % 2) == 1)
                {
                    tekCarpim *= i;
                }
            }
            txtTekCarpim.Text = tekCarpim.ToString();
            return tekCarpim;
        }
         BigInteger ciftSayilarCarpim()
        {
            int ciftCarpim = 1;
            int altSinir = Convert.ToInt32(mtxtbAltSinir.Text);
            int ustSinir = Convert.ToInt32(mtxtbUstSinir.Text);

            for (int i = altSinir; i <= ustSinir; i++)
            {
                if ((i % 2) == 0)
                {
                    ciftCarpim *= i;
                }
            }
            txtCiftCarpim.Text = ciftCarpim.ToString();
            return ciftCarpim;
        }
        int asalSayilarToplam()
        {
            int asalToplam = 0;
            int altSinir = Convert.ToInt32(mtxtbAltSinir.Text);
            int ustSinir = Convert.ToInt32(mtxtbUstSinir.Text);

            for (int sayi = ustSinir; sayi >= altSinir; sayi--)
            {
                int sayac = 0;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        sayac = 1;
                    }
                }
                if (sayac == 0)
                {
                    asalToplam += sayi;
                    lvAsalSayilar.Items.Add(sayi.ToString());
                }
            }
            txtAsalToplam.Text = asalToplam.ToString();
            return asalToplam;
        }
        int asalSayilarCArpim()
        {
            int asalCarpim = 1;

            int altSinir = Convert.ToInt32(mtxtbAltSinir.Text);
            int ustSinir = Convert.ToInt32(mtxtbUstSinir.Text);

            for (int sayi = ustSinir; sayi >= altSinir; sayi--)
            {
                int sayac = 0;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                      sayac = 1;
                    }
                }
                if (sayac == 0)
                {
                    asalCarpim *= sayi;
                }
            }
            txtAsalCarpim.Text = asalCarpim.ToString();
            return asalCarpim;
        }

        int armstrongSayiToplam()
        {
            double armstrongToplam = 0;
            double birlerBasamagi, onlarBasamagı, yuzlerBasamagı, binlerBasamagı;
            int altSinir = Convert.ToInt32(mtxtbAltSinir.Text);
            int ustSinir = Convert.ToInt32(mtxtbUstSinir.Text);

            for (double sayi = altSinir; sayi < ustSinir; sayi++)
            {
                if(sayi < 10)
                {
                    armstrongToplam += sayi;
                    lvArmSayilar.Items.Add(sayi.ToString());
                }
                else if(sayi>10 && sayi < 100)
                {
                        birlerBasamagi = sayi % 10;
                        onlarBasamagı = ((sayi - birlerBasamagi) / 10) % 10;

                    if (sayi == (Math.Pow(onlarBasamagı,2) + Math.Pow(birlerBasamagi, 2)))
                        {
                            armstrongToplam += sayi;
                            lvArmSayilar.Items.Add(sayi.ToString());
                        }
                }
                else if (sayi > 100 && sayi < 1000)
                {
                    birlerBasamagi = sayi % 10;
                    onlarBasamagı = ((sayi - birlerBasamagi) / 10) % 10;
                    yuzlerBasamagı = Math.Floor((sayi / 100));

                    if (sayi == (Math.Pow(yuzlerBasamagı,3) + Math.Pow(onlarBasamagı, 3) + Math.Pow(birlerBasamagi, 3)))
                    {
                        armstrongToplam += sayi;
                        lvArmSayilar.Items.Add(sayi.ToString());
                    }
                }
                else if (sayi > 1000 && sayi < 10000)
                {
                    birlerBasamagi = sayi % 10;
                    onlarBasamagı = ((sayi - birlerBasamagi) / 10) % 10;
                    yuzlerBasamagı = Math.Floor((sayi / 100) % 10);
                    binlerBasamagı = Math.Floor(sayi / 1000);

                    if (sayi == (Math.Pow(binlerBasamagı,4) + Math.Pow(yuzlerBasamagı, 4) + Math.Pow(onlarBasamagı, 4) + Math.Pow(birlerBasamagi, 4)))
                    {
                        armstrongToplam += sayi;
                        lvArmSayilar.Items.Add(sayi.ToString());
                    }
                }
            }

            txtArmToplam.Text = armstrongToplam.ToString();
            return 0;
        }
        int armstrongSayiCarpim()
        {
            double armstrongCarpim = 1;
            double birlerBasamagi, onlarBasamagı, yuzlerBasamagı, binlerBasamagı;
            int altSinir = Convert.ToInt32(mtxtbAltSinir.Text);
            int ustSinir = Convert.ToInt32(mtxtbUstSinir.Text);

            for (double sayi = altSinir; sayi < ustSinir; sayi++)
            {
                if (sayi < 10)
                {
                    armstrongCarpim *= sayi;
                }
                else if (sayi > 10 && sayi < 100)
                {
                    birlerBasamagi = sayi % 10;
                    onlarBasamagı = ((sayi - birlerBasamagi) / 10) % 10;

                    if (sayi == (Math.Pow(onlarBasamagı, 2) + Math.Pow(birlerBasamagi, 2)))
                    {
                        armstrongCarpim *= sayi;
                    }
                }
                else if (sayi > 100 && sayi < 1000)
                {
                    birlerBasamagi = sayi % 10;
                    onlarBasamagı = ((sayi - birlerBasamagi) / 10) % 10;
                    yuzlerBasamagı = Math.Floor((sayi / 100));

                    if (sayi == (Math.Pow(yuzlerBasamagı, 3) + Math.Pow(onlarBasamagı, 3) + Math.Pow(birlerBasamagi, 3)))
                    {
                        armstrongCarpim *= sayi;
                    }
                }
                else if (sayi > 1000 && sayi < 10000)
                {
                    birlerBasamagi = sayi % 10;
                    onlarBasamagı = ((sayi - birlerBasamagi) / 10) % 10;
                    yuzlerBasamagı = Math.Floor((sayi / 100) % 10);
                    binlerBasamagı = Math.Floor(sayi / 1000);

                    if (sayi == (Math.Pow(binlerBasamagı, 4) + Math.Pow(yuzlerBasamagı, 4) + Math.Pow(onlarBasamagı, 4) + Math.Pow(birlerBasamagi, 4)))
                    {
                        armstrongCarpim *= sayi;
                    }
                }
            }

            txtArmCarpim.Text = armstrongCarpim.ToString();
            return 0;
        }


        private void BtnHesapla_Click(object sender, EventArgs e)
        {   
            if(kontrol() == false)
            {
                MessageBox.Show("Değer Girilmedi!!!");
                ekranHazirla();
            }
            else if(Dogrula() == false)
            {
                MessageBox.Show("Hatalı Aralık!!!");
            }
            else if(kontrol() == true)
            {
                if (tabSonuc.SelectedTab == tabTekSayilar)
                {
                    
                    tekSayilarToplam();
                    tekSayilarCarpim();
                    int carpim = Convert.ToInt32(txtTekCarpim.Text);
                    int toplam = Convert.ToInt32(txtTekToplam.Text);
                    string islemTuru = "Tek sayiların toplanması ve çarpılması";
                    
                    dosyaYazdirma(islemTuru,carpim,toplam);
                }
                else if (tabSonuc.SelectedTab == tabCiftSayilar)
                {
                    ciftSayilarToplam();
                    ciftSayilarCarpim();
                    int carpim = Convert.ToInt32(txtCiftCarpim.Text);
                    int toplam = Convert.ToInt32(txtCiftToplam.Text);
                    string islemTuru = "Çift sayiların toplanması ve çarpılması";

                    dosyaYazdirma(islemTuru, carpim, toplam);
                }
                else if (tabSonuc.SelectedTab == tabAsalSayi)
                {
                    asalSayilarToplam();
                    asalSayilarCArpim();
                    int carpim = Convert.ToInt32(txtAsalCarpim.Text);
                    int toplam = Convert.ToInt32(txtAsalToplam.Text);
                    string islemTuru = "Asal sayiların toplanması ve çarpılması";

                    dosyaYazdirma(islemTuru, carpim, toplam);
                }
                else if (tabSonuc.SelectedTab == tabArmstrong)
                {
                    armstrongSayiToplam();
                    armstrongSayiCarpim();
                    int carpim = Convert.ToInt32(txtArmCarpim.Text);
                    int toplam = Convert.ToInt32(txtArmToplam.Text);
                    string islemTuru = "Armstrong sayiların toplanması ve çarpılması";

                    dosyaYazdirma(islemTuru, carpim, toplam);
                }
            }
        }

        private void BtnIleri_Click(object sender, EventArgs e)
        {
            if(tabSonuc.SelectedTab == tabTekSayilar)
            {
                tabSonuc.SelectedTab = tabCiftSayilar;
                ekranHazirla();
            }
            else if (tabSonuc.SelectedTab == tabCiftSayilar)
            {
                tabSonuc.SelectedTab = tabAsalSayi;
                ekranHazirla();
            }
            else if (tabSonuc.SelectedTab == tabAsalSayi)
            {
                tabSonuc.SelectedTab = tabArmstrong;
                ekranHazirla();
            }
            else if (tabSonuc.SelectedTab == tabArmstrong)
            {
                tabSonuc.SelectedTab = tabTekSayilar;
                ekranHazirla();
            }
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            if (tabSonuc.SelectedTab == tabTekSayilar)
            {
                tabSonuc.SelectedTab = tabArmstrong;
                ekranHazirla();
            }
            else if (tabSonuc.SelectedTab == tabCiftSayilar)
            {
                tabSonuc.SelectedTab = tabTekSayilar;
                ekranHazirla();
            }
            else if (tabSonuc.SelectedTab == tabAsalSayi)
            {
                tabSonuc.SelectedTab = tabCiftSayilar;
                ekranHazirla();
            }
            else if (tabSonuc.SelectedTab == tabArmstrong)
            {
                tabSonuc.SelectedTab = tabAsalSayi;
                ekranHazirla();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void Hesaplama_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "HOŞGELDİNİZ";
            notifyIcon1.BalloonTipTitle = "SAYI HESAPLAMALARI";
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(30000);
        }
    }
}

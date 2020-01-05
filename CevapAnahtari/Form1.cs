using System;
using System.IO;
using System.Windows.Forms;

namespace CevapAnahtari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dogruSayisi = 0, yanlisSayisi = 0, bosSayisi = 0, i = 0, k = 0, cevap = 0, turkce = 0, inklap = 0, din = 0, ingilizce = 0, matematik = 0, fen = 0,
        toplamSoruSayisi = 0, soruSayilari = 0;
        string hangiDers = "";

        int[] cevap2;
        bool veriAlindiMi = false;
        // string text = System.IO.File.ReadAllText(@"D:\Matematik\WriteText.txt");
        StreamReader sr;
        string s;
        private void txtSoruSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }


        private void txtSoruSayisi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSoruSayisiAl_Click(null, null);
            }

        }
        private void btnSoruSayisiAl_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoruSayisi.Text == "")
                {
                    MessageBox.Show("Soru Sayısı Boş Geçilemez");
                    txtSoruSayisi.Focus();
                    return;
                }
                if (int.TryParse(txtSoruSayisi.Text.Substring(txtSoruSayisi.Text.Length - 2, 2), out soruSayilari) == false)
                {
                    txtSoruSayisi.Text += "00";
                }
                soruSayilari = Convert.ToInt32(txtSoruSayisi.Text.Substring(txtSoruSayisi.Text.Length - 2, 2));
                hangiDers = txtSoruSayisi.Text.Substring(0, txtSoruSayisi.Text.Length - 2).ToUpper();

                switch (hangiDers)
                {

                    case "TUR":
                    case "TURCE":
                    case "TUKCE":
                    case "TÜRKÇE":
                    case "TURKCE":
                    case "TURKÇE":
                    case "TRKCE":
                    case "TURK":
                        txtSoruSayisi.Focus();


                        turkce = soruSayilari;
                        toplamSoruSayisi += turkce;
                        lblSoruSayisi.Text = $"Soru sayısı: {turkce}";
                        txtSoruSayisi.Text = "";
                        break;

                    case "TAR":
                    case "TARİH":
                    case "TARH":
                    case "TRİH":
                    case "TARİİH":
                    case "TR":

                        txtSoruSayisi.Focus();


                        inklap = soruSayilari;
                        lblSoruSayisi.Text = $"Soru sayısı: {inklap}";
                        toplamSoruSayisi += inklap;
                        txtSoruSayisi.Text = "";
                        break;
                    case "DIN":
                    case "DİN":
                    case "DN":
                    case "DİNN":
                        txtSoruSayisi.Focus();

                        din = soruSayilari;
                        lblSoruSayisi.Text = $"Soru sayısı: {din}";
                        toplamSoruSayisi += din;
                        txtSoruSayisi.Text = "";
                        break;
                    case "İNGİLİZCE":
                    case "İNGLZCE":
                    case "İNGİLİZC":
                    case "İNİLİZCE":
                    case "INGILIZCE":

                        txtSoruSayisi.Focus();


                        ingilizce = soruSayilari;
                        toplamSoruSayisi += ingilizce;
                        lblSoruSayisi.Text = $"Soru sayısı: {ingilizce}";
                        txtSoruSayisi.Text = "";
                        break;

                    case "MATEMATİK":
                    case "MAT":
                    case "MATMATİK":
                    case "MATİK":
                    case "MATEMATIK":
                    case "MATIK":
                        txtSoruSayisi.Focus();


                        matematik = soruSayilari;
                        toplamSoruSayisi += matematik;
                        lblSoruSayisi.Text = $"Soru sayısı: {matematik}";
                        txtSoruSayisi.Text = "";
                        break;

                    case "FEN":
                    case "FN":
                    case "FENN":
                        txtSoruSayisi.Focus();


                        fen = soruSayilari;
                        toplamSoruSayisi += fen;
                        lblSoruSayisi.Text = $"Soru sayısı: {fen}";
                        txtSoruSayisi.Text = "";
                        break;
                    case "GELISIM":
                    case "gelisim":
                    case "GELİSİM":

                        turkce = 20;
                        inklap = 10;
                        din = 10;
                        ingilizce = 10;
                        matematik = 20;
                        fen = 20;
                        toplamSoruSayisi = 90;
                        txtSoruSayisi.Text = "";
                        txtSoruSayisi.Enabled = false;
                        txtCevaplar.Enabled = true;
                        break;
                    default:
                        MessageBox.Show("Geçerli bir dönüt girmediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSoruSayisi.Text = "";
                        break;
                }
                if (matematik > 0 && fen > 0 && turkce > 0 && inklap > 0 && ingilizce > 0 && din > 0)
                {
                    txtSoruSayisi.Enabled = false;
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }

        }



        private void btnOku_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();

            dosya.Filter = "Resim Dosyası |*.txt;*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            dosya.Title = "Cevap Anahtarı Text Dosyasını Seçiniz.";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            sr = new StreamReader(DosyaYolu);

            if (toplamSoruSayisi > 0)
            {
                veriAlindiMi = true;
                txtCevaplar.Enabled = true;
            }
            else
                return;

            cevap2 = new int[toplamSoruSayisi];


            int bkitapcigicevaplari = 0;
            do
            {
                s = sr.ReadLine();
                if (s != null)
                {
                    listCevapAnahtari.Items.Add(s);
                }
                else
                {
                    break;
                }

                bkitapcigicevaplari++;

            } while (s != null && bkitapcigicevaplari < toplamSoruSayisi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGeriAl_Click(object sender, EventArgs e)
        {

            if (toplamSoruSayisi > 0 && listCevapAnahtari.Items.Count > 0&&i<toplamSoruSayisi)
            {
                if (i > 0)
                {
                    i--;
                }
                else
                {
                    return;
                }


                if (i < listCevapAnahtari.Items.Count + 1 && i > 0)
                {
                    if (Convert.ToInt32(listCevapAnahtari.Items[i]).Equals(cevap2[i]))
                    {
                        if (dogruSayisi > 0)
                        {
                            dogruSayisi--;
                        }


                    }
                    else if (cevap2[i] == 0)
                    {
                        if (bosSayisi > 0)
                        {
                            bosSayisi--;
                        }

                    }
                    else
                    {
                        if (yanlisSayisi > 0)
                        {
                            yanlisSayisi--;
                        }

                    }

                    if (i > 0 && i < turkce)
                    {
                        lblSonuc.Text = $"Türkçe : {dogruSayisi.ToString()} Doğru. { yanlisSayisi} Yanlış. {bosSayisi} Boş.\n";
                    }
                    if (i > turkce - 1 && i < inklap + turkce)
                    {
                        lblSonucInklap.Text = $"Inklap : {dogruSayisi.ToString()} Doğru. { yanlisSayisi} Yanlış. {bosSayisi} Boş.\n";
                    }
                    if (i > inklap + turkce - 1 && i < turkce + inklap + din)
                    {
                        lblDin.Text = $"Din : {dogruSayisi.ToString()} Doğru. { yanlisSayisi} Yanlış. {bosSayisi} Boş.\n";
                    }
                    if (i > turkce + inklap + din - 1 && i < turkce + inklap + din + ingilizce)
                    {
                        lblIngilizce.Text = $"Ingilizce : {dogruSayisi.ToString()} Doğru. { yanlisSayisi} Yanlış. {bosSayisi} Boş.\n";
                    }
                    if (i > turkce + inklap + din + ingilizce - 1 && i < turkce + inklap + din + ingilizce + matematik)
                    {
                        lblMatematik.Text = $"Matematik : {dogruSayisi.ToString()} Doğru. { yanlisSayisi} Yanlış. {bosSayisi} Boş.\n";
                    }
                    if (i > turkce + inklap + din + ingilizce + matematik - 1 && i < toplamSoruSayisi)
                    {
                        lblFen.Text = $"Fen : {dogruSayisi.ToString()} Doğru. { yanlisSayisi} Yanlış. {bosSayisi} Boş.\n";
                    }

                    lblSoruSirasi.Text = i.ToString();

                }
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {

            if (i > 0)
            {
                if (MessageBox.Show("Alanları temizlemek istiyormusunuz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lblSonuc.Text = "";
                    lblSonucInklap.Text = "";
                    lblDin.Text = "";
                    lblIngilizce.Text = "";
                    lblMatematik.Text = "";
                    lblFen.Text = "";
                    dogruSayisi = 0; yanlisSayisi = 0;
                    bosSayisi = 0;
                    i = 0;
                    txtCevaplar.Text = "";
                }
            }

        }

        private void txtCevaplar_TextChanged(object sender, EventArgs e)
        {
            if (veriAlindiMi == true)

            {

                if (txtCevaplar.Text == "")
                {
                    txtCevaplar.Focus();
                    return;

                }
                if (int.TryParse(txtCevaplar.Text, out cevap))
                {
                    if (i < toplamSoruSayisi)
                    {

                        cevap = Convert.ToInt32(txtCevaplar.Text);
                        cevap2[i] = cevap;



                        while (int.TryParse(txtCevaplar.Text, out cevap) == true)
                        {
                            txtCevaplar.Text = "";


                            if (i >= 0 && i < turkce)
                            {
                                if (Convert.ToInt32(listCevapAnahtari.Items[i]).Equals(cevap))
                                {
                                    dogruSayisi++;
                                }
                                else if (cevap == 0)
                                {
                                    bosSayisi++;
                                }
                                else
                                {
                                    yanlisSayisi++;
                                }
                                if (i == turkce - 1)
                                {
                                    lblSonuc.Text = $"Türkçe : {dogruSayisi.ToString()} Doğru. { yanlisSayisi} Yanlış. {bosSayisi} Boş.\n";
                                    if (MessageBox.Show("Türkçe bitti. Diğer derse geçmek istermisiniz.", "Sıradaki Derse Geçmek Üzeresiniz.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        bosSayisi = 0; yanlisSayisi = 0; dogruSayisi = 0;
                                    }
                                    else
                                    {

                                        if (Convert.ToInt32(listCevapAnahtari.Items[i]).Equals(cevap2[i]))
                                        {
                                            if (dogruSayisi > 0)
                                            {
                                                dogruSayisi--;
                                            }

                                        }
                                        else if (cevap == 0)
                                        {
                                            if (bosSayisi > 0)
                                            {
                                                bosSayisi--;
                                            }

                                        }
                                        else
                                        {
                                            if (yanlisSayisi > 0)
                                            {
                                                yanlisSayisi--;
                                            }

                                        }
                                        if (i > 0)
                                        {
                                            i--;
                                        }

                                    }
                                }

                            }
                            if (i > turkce - 1 && i < turkce + inklap)//inkılap
                            {

                                if (Convert.ToInt32(listCevapAnahtari.Items[i]).Equals(cevap))
                                {

                                    dogruSayisi++;
                                }
                                else if (cevap == 0)
                                {
                                    bosSayisi++;

                                }
                                else
                                {
                                    yanlisSayisi++;
                                }
                                if (i == turkce + inklap - 1)
                                {

                                    lblSonucInklap.Text = $"İnkılap : {dogruSayisi.ToString()} Doğru. { yanlisSayisi} Yanlış. {bosSayisi} Boş.\n";
                                    if (MessageBox.Show("Inklap bitti. Diğer derse geçmek istermisiniz.", "Sıradaki Derse Geçmek Üzeresiniz.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        bosSayisi = 0; yanlisSayisi = 0; dogruSayisi = 0;
                                    }
                                    else
                                    {

                                        if (Convert.ToInt32(listCevapAnahtari.Items[i]).Equals(cevap))
                                        {
                                            if (dogruSayisi > 0)
                                            {
                                                dogruSayisi--;
                                            }

                                        }
                                        else if (cevap == 0)
                                        {
                                            if (bosSayisi > 0)
                                            {
                                                bosSayisi--;
                                            }

                                        }
                                        else
                                        {
                                            if (yanlisSayisi > 0)
                                            {
                                                yanlisSayisi--;
                                            }

                                        }
                                        i--;
                                    }

                                }

                            }
                            if (i > turkce + inklap - 1 && i < turkce + inklap + din)//Din
                            {
                                if (Convert.ToInt32(listCevapAnahtari.Items[i]).Equals(cevap))
                                {
                                    dogruSayisi++;
                                }
                                else if (cevap == 0)
                                {
                                    bosSayisi++;
                                }
                                else
                                {
                                    yanlisSayisi++;
                                }
                                if (i == turkce + inklap + din - 1)
                                {
                                    lblDin.Text = $"Din : {dogruSayisi.ToString()} Doğru. { yanlisSayisi} Yanlış. {bosSayisi} Boş.\n";
                                    if (MessageBox.Show("Din bitti. Diğer derse geçmek istermisiniz.", "Sıradaki Derse Geçmek Üzeresiniz.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        bosSayisi = 0; yanlisSayisi = 0; dogruSayisi = 0;
                                    }
                                    else
                                    {

                                        if (Convert.ToInt32(listCevapAnahtari.Items[i]).Equals(cevap))
                                        {
                                            if (dogruSayisi > 0)
                                            {
                                                dogruSayisi--;
                                            }

                                        }
                                        else if (cevap == 0)
                                        {
                                            if (bosSayisi > 0)
                                            {
                                                bosSayisi--;
                                            }

                                        }
                                        else
                                        {
                                            if (yanlisSayisi > 0)
                                            {
                                                yanlisSayisi--;
                                            }

                                        }
                                        i--;
                                    }
                                }

                            }
                            if (i > turkce + inklap + din - 1 && i < turkce + inklap + din + ingilizce)//ingilizce
                            {
                                if (Convert.ToInt32(listCevapAnahtari.Items[i]).Equals(cevap))
                                {
                                    dogruSayisi++;
                                }
                                else if (cevap == 0)
                                {
                                    bosSayisi++;
                                }
                                else
                                {
                                    yanlisSayisi++;
                                }
                                if (i == turkce + inklap + din + ingilizce - 1)
                                {
                                    lblIngilizce.Text = $"Ingilizce : {dogruSayisi.ToString()} Doğru. { yanlisSayisi} Yanlış. {bosSayisi} Boş.\n";
                                    if (MessageBox.Show("İngilizce bitti. Diğer derse geçmek istermisiniz.", "Sıradaki Derse Geçmek Üzeresiniz.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        bosSayisi = 0; yanlisSayisi = 0; dogruSayisi = 0;
                                    }
                                    else
                                    {

                                        if (Convert.ToInt32(listCevapAnahtari.Items[i]).Equals(cevap))
                                        {
                                            if (dogruSayisi > 0)
                                            {
                                                dogruSayisi--;
                                            }

                                        }
                                        else if (cevap == 0)
                                        {
                                            if (bosSayisi > 0)
                                            {
                                                bosSayisi--;
                                            }

                                        }
                                        else
                                        {
                                            if (yanlisSayisi > 0)
                                            {
                                                yanlisSayisi--;
                                            }

                                        }
                                        i--;
                                    }
                                }
                            }
                            if (i > turkce + inklap + din + ingilizce - 1 && i < turkce + inklap + din + ingilizce + matematik)//matematik
                            {
                                if (Convert.ToInt32(listCevapAnahtari.Items[i]).Equals(cevap))
                                {
                                    dogruSayisi++;
                                }
                                else if (cevap == 0)
                                {
                                    bosSayisi++;
                                }
                                else
                                {
                                    yanlisSayisi++;
                                }
                                if (i == turkce + inklap + din + ingilizce + matematik - 1)
                                {
                                    lblMatematik.Text = $"Matematik : {dogruSayisi.ToString()} Doğru. { yanlisSayisi} Yanlış. {bosSayisi} Boş.\n";
                                    if (MessageBox.Show("Matematik bitti. Diğer derse geçmek istermisiniz.", "Sıradaki Derse Geçmek Üzeresiniz.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        bosSayisi = 0; yanlisSayisi = 0; dogruSayisi = 0;
                                    }

                                    else
                                    {

                                        if (Convert.ToInt32(listCevapAnahtari.Items[i]).Equals(cevap))
                                        {
                                            if (dogruSayisi > 0)
                                            {
                                                dogruSayisi--;
                                            }

                                        }
                                        else if (cevap == 0)
                                        {
                                            if (bosSayisi > 0)
                                            {
                                                bosSayisi--;
                                            }
                                        }
                                        else
                                        {
                                            if (yanlisSayisi > 0)
                                            {
                                                yanlisSayisi--;
                                            }

                                        }
                                        i--;
                                    }
                                }

                            }
                            if (i > turkce + inklap + din + ingilizce + matematik - 1 && i < toplamSoruSayisi)//
                            {
                                if (Convert.ToInt32(listCevapAnahtari.Items[i]).Equals(cevap))
                                {

                                    dogruSayisi++;
                                }
                                else if (cevap == 0)
                                {
                                    bosSayisi++;
                                }
                                else
                                {
                                    yanlisSayisi++;
                                }
                                if (i == toplamSoruSayisi - 1)
                                {
                                    lblFen.Text = $"Fen Bilimi : {dogruSayisi.ToString()} Doğru. { yanlisSayisi} Yanlış. {bosSayisi} Boş.\n";
                                    if (MessageBox.Show("Fen bitti. Sonuçları görmek istermisiniz.", "Bitirmek Üzeresiniz.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        bosSayisi = 0; yanlisSayisi = 0; dogruSayisi = 0;

                                    }
                                    else
                                    {

                                        if (Convert.ToInt32(listCevapAnahtari.Items[i]).Equals(cevap))
                                        {
                                            if (dogruSayisi > 0)
                                            {
                                                dogruSayisi--;
                                            }

                                        }
                                        else if (cevap == 0)
                                        {
                                            if (bosSayisi > 0)
                                            {
                                                bosSayisi--;
                                            }

                                        }
                                        else
                                        {
                                            if (bosSayisi > 0)
                                            {
                                                yanlisSayisi--;
                                            }

                                        }
                                        i--;
                                    }
                                }

                            }
                        }

                        i++;
                        lblSoruSirasi.Text = i.ToString();
                    }

                    else
                    {
                        MessageBox.Show("Sonuçlarınızı görebilirsiniz.");
                        txtCevaplar.Enabled = false;

                        return;

                    }
                }
            }

        }
    }
}


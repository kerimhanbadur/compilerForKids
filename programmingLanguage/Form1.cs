using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programmingLanguage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            int index = kodTB.Text.Length;
            int line = kodTB.GetLineFromCharIndex(index) + 1;
            int firstChar = kodTB.GetFirstCharIndexFromLine(line);
            int column = index - firstChar;
            AddLineNumbers();
            if(kodTB.Text.Trim() == "")
            {
                satirTB.Text = "";
            }
        }
        public void AddLineNumbers()
        {
            Point pt = new Point(0, 0);
            int First_Index = kodTB.GetCharIndexFromPosition(pt);
            int First_Line = kodTB.GetLineFromCharIndex(First_Index);
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            int Last_Index = kodTB.GetCharIndexFromPosition(pt);
            int Last_Line = kodTB.GetLineFromCharIndex(Last_Index);
            satirTB.SelectionAlignment = HorizontalAlignment.Center;
            satirTB.Text = "";
            for (int i = First_Line; i <= Last_Line; i++)
            {
                satirTB.Text += i + 1 + "\n";
            }
        }

        public bool sayiMi(string str)
        {
            foreach(char c in str)
            {
                if (!Char.IsNumber(c)) return false;
            }
            return true;
        }

        private void derleyiciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] line = kodTB.Text.Split(';');
            sonucTB.Clear();
            if(line[0] == "başla" && (line[line.Length - 2] == "dur" || line[line.Length - 2] == "\ndur"))
            {
                sonucTB.Text = "Kodlama Öğreniyorum v1.0 - Derleyici Çalışıyor...\n";
                if (line[1] == "\ntopla" || line[1] == "\n+")
                {
                    int toplam = 0; int sayac = 0;
                    for (int i = 2; i < line.Length - 2; i++)
                    {
                        try
                        {
                            toplam += int.Parse(line[i]);
                        }
                        catch
                        {
                            sayac++;
                        }
                    }
                    if (sayac == 0)
                    {
                        sonucTB.Text += "Derleme Başarıyla Tamamlandı,\nToplama İşlemi Sonucu : " + toplam.ToString();
                    }
                    else
                    {
                        sonucTB.Text += "Derleme Sırasında Hata Meydana Geldi,\nGirilen Parametrelerden Biri veya Birkaçı Hatalı...\nLütfen Tek Methodlu Bir Kod Yazdığınızdan Emin Olun...";
                    }
                }
                else if(line[1] == "\nçıkar" || line[1] == "\n-")
                {
                    List<int> farkDizi = new List<int>(); int sayac = 0;
                    for(int i = 2; i < line.Length - 2; i++)
                    {
                        try
                        {
                            farkDizi.Add(int.Parse(line[i]));
                        }
                        catch
                        {
                            sayac++;
                        }
                    }
                    int sonuc = farkDizi[0];
                    for(int i = 1; i < farkDizi.Count; i++)
                    {
                        sonuc -= farkDizi[i];
                    }
                    if (sayac == 0)
                    {
                        sonucTB.Text += "Derleme Başarıyla Tamamlandı,\nÇıkarma İşlemi Sonucu : " + sonuc.ToString();
                    }
                    else
                    {
                        sonucTB.Text += "Derleme Sırasında Hata Meydana Geldi,\nGirilen Parametrelerden Biri veya Birkaçı Hatalı...\nLütfen Tek Methodlu Bir Kod Yazdığınızdan Emin Olun...";
                    }
                }
                else if(line[1] == "\nçarp" || line[1] == "\n*")
                {
                    int carpim = 1; int sayac = 0;
                    for(int i = 2; i < line.Length - 2; i++)
                    {
                        try
                        {
                            carpim *= int.Parse(line[i]);
                        }
                        catch
                        {
                            sayac++;
                        }
                    }
                    if (sayac == 0)
                    {
                        sonucTB.Text += "Derleme Başarıyla Tamamlandı,\nÇarpma İşlemi Sonucu : " + carpim.ToString();
                    }
                    else
                    {
                        sonucTB.Text += "Derleme Sırasında Hata Meydana Geldi,\nGirilen Parametrelerden Biri veya Birkaçı Hatalı...\nLütfen Tek Methodlu Bir Kod Yazdığınızdan Emin Olun...";
                    }
                }
                else if(line[1] == "\nböl" || line[1] == "\n/")
                {
                    List<int> bolum = new List<int>(); int sayac = 0;
                    for (int i = 2; i < line.Length - 2; i++)
                    {
                        try
                        {
                            bolum.Add(int.Parse(line[i]));
                        }
                        catch
                        {
                            sayac++;
                        }
                    }
                    if (sayac != 0)
                    {
                        sonucTB.Text += "Derleme Sırasında Hata Meydana Geldi,\nGirilen Parametrelerden Biri veya Birkaçı Hatalı...\nLütfen Tek Methodlu Bir Kod Yazdığınızdan Emin Olun...";
                    }
                    else
                    {
                        if (line.Length > 6)
                        {
                            sonucTB.Text += "Derleme Sırasında Hata Meydana Geldi,\nBölme İşlemi Sadece 2 Sayı Arasında Yapılabilmektedir...";
                        }
                        else
                        {
                            int sonuc = bolum[0];
                            for (int i = 1; i <= 1; i++)
                            {
                                if (bolum[i] == 0)
                                {
                                    sonucTB.Text += "Derleme Sırasında Hata Meydana Geldi,\nHerhangi Bir Sayı Sıfıra(0) Bölünemez...";
                                }
                                else if ((sonuc % bolum[i]) == 0)
                                {
                                    sonucTB.Text += "Derleme Başarıyla Tamamlandı,\nBölme İşlemi Sonucu : " + (sonuc / bolum[i]).ToString();
                                }
                                else
                                {
                                    sonucTB.Text += "Derleme Başarıyla Tamamlandı,\nBölme İşlemi Sonucu Küsuratlı Olduğu İçin İşlem Sonuçlandırılamıyor...";
                                }
                            }
                        }
                    }
                }
                else
                {
                    sonucTB.Text += "Derleme Sırasında Hata Meydana Geldi,\nGeçersiz Method veya Fazla Method Girildi, Lütfen Nasıl Çalışır Kısmından Bilgi Al...";
                }
            }
            else
            {
                sonucTB.Text = "Derleyici Başlangıç/Bitiş Hatası,\nLütfen Nasıl Çalışır Kısmından Bilgi Al...";
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about hakkinda = new about();
            hakkinda.ShowDialog();
        }

        private void nasılÇalışırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            howItWorks nasilCalisir = new howItWorks();
            nasilCalisir.ShowDialog();
        }

        private void örnekKodlamalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            examples ornekler = new examples();
            ornekler.ShowDialog();
        }
    }
}

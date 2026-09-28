namespace ders4
{
    public partial class Form1 : Form
    {
        private int biletSiraNo = 1;

        public Form1()
        {
            InitializeComponent();
            SehirleriYukle();
        }

        // Şəhərləri combobox-lara əlavə edir
        private void SehirleriYukle()
        {
            string[] sehrler =
            {
                "Şəhər seçin",
                "Bakı",
                "Gəncə",
                "Sumqayıt",
                "Şəki",
                "Qəbələ"
            };

            gedisSeheriKombosu.Items.AddRange(sehrler);
            teyyinatSeheriKombosu.Items.AddRange(sehrler);

            gedisSeheriKombosu.SelectedIndex = 0;
            teyyinatSeheriKombosu.SelectedIndex = 0;
        }

        // Proqramdan çıxış
        private void CixisButonu_Click(object? gonderen, EventArgs args)
        {
            if (ConfirmSor("Proqramdan çıxmaq istəyirsiniz?"))
            {
                Close();
            }
        }

        // Şəhərlərin yerini dəyişir
        private void YerDegisButonu_Click(object? gonderen, EventArgs args)
        {
            if (gedisSeheriKombosu.SelectedIndex <= 0 || teyyinatSeheriKombosu.SelectedIndex <= 0)
            {
                XetaGoster("Hər iki şəhəri seçin.");
                return;
            }

            int temp = gedisSeheriKombosu.SelectedIndex;
            gedisSeheriKombosu.SelectedIndex = teyyinatSeheriKombosu.SelectedIndex;
            teyyinatSeheriKombosu.SelectedIndex = temp;
        }

        // Bilet yaratır
        private void BiletYaratButonu_Click(object? gonderen, EventArgs args)
        {
            if (!GedisSehriniYoxla() || !TeyyinatSehriniYoxla() ||
                !AdSoyadiYoxla() || !FiniYoxla() || !YeriYoxla() ||
                !TelefoniYoxla() || !EmailiYoxla() ||
                !TariximiYoxla() || !SaatiYoxla())
                return;

            string biletId = "BMU-" + biletSiraNo.ToString("000");

            string bilet =
                "Ticket ID: " + biletId +
                " | Gediş: " + gedisSeheriKombosu.Text +
                " | Təyinat: " + teyyinatSeheriKombosu.Text +
                " | Tarix: " + tarixKutusu.Text +
                " | Saat: " + saatKutusu.Text +
                " | Yer: " + yerKutusu.Text +
                " | Ad: " + adSoyadKutusu.Text +
                " | FIN: " + finKutusu.Text.ToUpper() +
                " | Telefon: " + telefonKutusu.Text +
                " | Email: " + emailKutusu.Text;

            biletlerListesi.Items.Add(bilet);
            biletlerListesi.SelectedIndex = biletlerListesi.Items.Count - 1;

            MelumatGoster("Bilet uğurla yaradıldı!\n\nTicket ID: " + biletId);

            biletSiraNo++;
            BiletMelumatlariniSil();
        }

        // Bileti silir
        private void BiletSilButonu_Click(object? gonderen, EventArgs args)
        {
            if (biletlerListesi.SelectedIndex < 0)
            {
                XetaGoster("Silmək üçün bilet seçin.");
                return;
            }

            if (ConfirmSor("Seçilmiş bileti silmək istəyirsiniz?"))
            {
                int index = biletlerListesi.SelectedIndex;
                biletlerListesi.Items.RemoveAt(index);

                if (biletlerListesi.Items.Count > 0)
                {
                    if (index >= biletlerListesi.Items.Count)
                        index = biletlerListesi.Items.Count - 1;
                    biletlerListesi.SelectedIndex = index;
                }

                MelumatGoster("Bilet silindi.");
            }
        }

        // ===== YOXLAMA METODLARı =====

        private bool GedisSehriniYoxla()
        {
            if (gedisSeheriKombosu.SelectedIndex <= 0)
            {
                XetaGoster("Gediş şəhərini seçin.");
                gedisSeheriKombosu.Focus();
                return false;
            }
            return true;
        }

        private bool TeyyinatSehriniYoxla()
        {
            if (teyyinatSeheriKombosu.SelectedIndex <= 0)
            {
                XetaGoster("Təyinat şəhərini seçin.");
                teyyinatSeheriKombosu.Focus();
                return false;
            }

            if (gedisSeheriKombosu.SelectedIndex == teyyinatSeheriKombosu.SelectedIndex)
            {
                XetaGoster("Gediş və təyinat şəhəri eyni ola bilməz.");
                return false;
            }
            return true;
        }

        private bool AdSoyadiYoxla()
        {
            if (string.IsNullOrWhiteSpace(adSoyadKutusu.Text))
            {
                XetaGoster("Ad və soyad daxil edin.");
                adSoyadKutusu.Focus();
                return false;
            }
            return true;
        }

        private bool FiniYoxla()
        {
            if (string.IsNullOrWhiteSpace(finKutusu.Text))
            {
                XetaGoster("FIN kodunu daxil edin.");
                finKutusu.Focus();
                return false;
            }

            if (finKutusu.Text.Trim().Length != 7)
            {
                XetaGoster("FIN kodu 7 simvoldan ibarət olmalıdır.");
                finKutusu.Focus();
                return false;
            }
            return true;
        }

        private bool YeriYoxla()
        {
            if (string.IsNullOrWhiteSpace(yerKutusu.Text))
            {
                XetaGoster("Yer nömrəsini daxil edin.");
                yerKutusu.Focus();
                return false;
            }
            return true;
        }

        private bool TelefoniYoxla()
        {
            if (string.IsNullOrWhiteSpace(telefonKutusu.Text))
            {
                XetaGoster("Telefon nömrəsini daxil edin.");
                telefonKutusu.Focus();
                return false;
            }
            return true;
        }

        private bool EmailiYoxla()
        {
            if (string.IsNullOrWhiteSpace(emailKutusu.Text))
            {
                XetaGoster("Email ünvanını daxil edin.");
                emailKutusu.Focus();
                return false;
            }

            if (!emailKutusu.Text.Contains("@") || !emailKutusu.Text.Contains("."))
            {
                XetaGoster("Email ünvanı düzgün deyil. (Məs: user@gmail.com)");
                emailKutusu.Focus();
                return false;
            }
            return true;
        }

        private bool TariximiYoxla()
        {
            if (string.IsNullOrWhiteSpace(tarixKutusu.Text) || tarixKutusu.Text == "  /  /")
            {
                XetaGoster("Tarixi daxil edin.");
                tarixKutusu.Focus();
                return false;
            }

            if (!DateTime.TryParse(tarixKutusu.Text, out DateTime tarix))
            {
                XetaGoster("Tarix düzgün daxil edilməyib. (Məs: 30/09/2026)");
                tarixKutusu.Focus();
                return false;
            }

            if (tarix.Date < DateTime.Today)
            {
                XetaGoster("Keçmiş tarixə bilet almaq olmaz.");
                tarixKutusu.Focus();
                return false;
            }
            return true;
        }

        private bool SaatiYoxla()
        {
            if (string.IsNullOrWhiteSpace(saatKutusu.Text) || saatKutusu.Text == ":")
            {
                XetaGoster("Saatı daxil edin.");
                saatKutusu.Focus();
                return false;
            }

            if (!TimeSpan.TryParse(saatKutusu.Text, out TimeSpan saat))
            {
                XetaGoster("Saat düzgün daxil edilməyib. (Məs: 14:30)");
                saatKutusu.Focus();
                return false;
            }

            if (saat.Hours < 0 || saat.Hours > 23)
            {
                XetaGoster("Saat düzgün deyil. (00:00 - 23:59)");
                saatKutusu.Focus();
                return false;
            }
            return true;
        }

        // ===== KÖMƏKÇİ METODLARı =====

        private void BiletMelumatlariniSil()
        {
            gedisSeheriKombosu.SelectedIndex = 0;
            teyyinatSeheriKombosu.SelectedIndex = 0;
            tarixKutusu.Clear();
            saatKutusu.Clear();
            yerKutusu.Clear();
            adSoyadKutusu.Clear();
            finKutusu.Clear();
            telefonKutusu.Clear();
            emailKutusu.Clear();
            adSoyadKutusu.Focus();
        }

        private void XetaGoster(string mesaj)
        {
            MessageBox.Show(mesaj, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MelumatGoster(string mesaj)
        {
            MessageBox.Show(mesaj, "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ConfirmSor(string sual)
        {
            return MessageBox.Show(sual, "Təsdiq", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes;
        }
    }
}

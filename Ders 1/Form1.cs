using System;
using System.Windows.Forms;

namespace lesson1
{
    public partial class Form1 : Form
    {
        // Qeydiyyatdan kecen istifadecinin melumatlari
        private string qeydliAd = string.Empty;
        private string qeydliPoct = string.Empty;
        private string qeydliSifre = string.Empty;

        private const string PencereBasligi = "Bildiriş";

        public Form1()
        {
            InitializeComponent();
            PlaceholderleriYaz();
        }

        private void PlaceholderleriYaz()
        {
            txtAdSoyad.PlaceholderText = "Ad və soyad";
            txtQeydPoct.PlaceholderText = "Email";
            txtQeydSifre.PlaceholderText = "Şifrə";
            txtQeydSifreTekrar.PlaceholderText = "Şifrəni təkrar edin";

            txtGirisPoct.PlaceholderText = "Email";
            txtGirisSifre.PlaceholderText = "Şifrə";
        }

        // Xeberdarliq penceresi ucun qisa komekci metod
        private static void Xeberdarliq(string metn)
        {
            MessageBox.Show(metn, PencereBasligi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static void Melumat(string metn)
        {
            MessageBox.Show(metn, PencereBasligi, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Email formatinin sade yoxlanmasi
        private bool PoctDuzgundurmu(string poct)
        {
            int ilkAt = poct.IndexOf('@');
            int sonAt = poct.LastIndexOf('@');
            int noqte = poct.IndexOf('.', ilkAt + 1);

            bool atDuzgun = ilkAt > 0 && ilkAt == sonAt;
            bool noqteDuzgun = noqte > ilkAt + 1 && noqte < poct.Length - 1;
            bool simvollarDuzgun = !poct.Contains(' ')
                                   && !poct.Contains("..")
                                   && !poct.EndsWith('.');

            return atDuzgun && noqteDuzgun && simvollarDuzgun;
        }

        // QEYDİYYAT
        private void btnQeydiyyat_Click(object sender, EventArgs e)
        {
            string ad = txtAdSoyad.Text.Trim();
            string poct = txtQeydPoct.Text.Trim().ToLowerInvariant();
            string sifre = txtQeydSifre.Text;
            string sifreTekrar = txtQeydSifreTekrar.Text;

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(poct) ||
                string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(sifreTekrar))
            {
                Xeberdarliq("Bütün xanaları doldurun!");
                return;
            }

            if (!PoctDuzgundurmu(poct))
            {
                Xeberdarliq("Düzgün email daxil edin!");
                return;
            }

            bool artiqVar = qeydliPoct != string.Empty &&
                            (poct == qeydliPoct ||
                             ad.Equals(qeydliAd, StringComparison.OrdinalIgnoreCase));

            if (artiqVar)
            {
                Xeberdarliq("Bu ad və ya email ilə artıq qeydiyyatdan keçilib!");
                return;
            }

            if (sifre.Length < 6)
            {
                Xeberdarliq("Şifrə ən azı 6 simvol olmalıdır!");
                return;
            }

            if (sifre != sifreTekrar)
            {
                Xeberdarliq("Şifrələr uyğun deyil!");
                return;
            }

            qeydliAd = ad;
            qeydliPoct = poct;
            qeydliSifre = sifre;

            Melumat("Qeydiyyat uğurla tamamlandı!");

            txtGirisPoct.Text = qeydliPoct;

            txtAdSoyad.Clear();
            txtQeydPoct.Clear();
            txtQeydSifre.Clear();
            txtQeydSifreTekrar.Clear();
        }

        // LOGİN
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string poct = txtGirisPoct.Text.Trim().ToLowerInvariant();
            string sifre = txtGirisSifre.Text;

            if (poct.Length == 0 || sifre.Length == 0)
            {
                Xeberdarliq("Email və şifrəni daxil edin!");
                return;
            }

            if (poct == qeydliPoct && sifre == qeydliSifre)
            {
                Melumat("Xoş gəldiniz, " + qeydliAd + "!");
            }
            else
            {
                Xeberdarliq("Email və ya şifrə yanlışdır!");
            }
        }

        // QEYDİYYAT ŞİFRƏSİNİ GÖSTƏR / GİZLƏT
        private void chkQeydGoster_CheckedChanged(object sender, EventArgs e)
        {
            bool gizli = !chkQeydGoster.Checked;
            txtQeydSifre.UseSystemPasswordChar = gizli;
            txtQeydSifreTekrar.UseSystemPasswordChar = gizli;
        }

        // LOGİN ŞİFRƏSİNİ GÖSTƏR / GİZLƏT
        private void chkGirisGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtGirisSifre.UseSystemPasswordChar = !chkGirisGoster.Checked;
        }
    }
}

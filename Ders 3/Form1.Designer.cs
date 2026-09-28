namespace ders4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            baslik = new Panel();
            universiteEtiket = new Label();
            basliqEtiket = new Label();
            seyahatKutusu = new GroupBox();
            yerDegisButonu = new Button();
            yerKutusu = new TextBox();
            yerEtiket = new Label();
            saatKutusu = new MaskedTextBox();
            saatEtiket = new Label();
            tarixKutusu = new MaskedTextBox();
            tarixEtiket = new Label();
            teyyinatSeheriKombosu = new ComboBox();
            teyyinatEtiket = new Label();
            gedisSeheriKombosu = new ComboBox();
            gedisEtiket = new Label();
            insonKutusu = new GroupBox();
            biletYaratButonu = new Button();
            emailKutusu = new TextBox();
            emailEtiket = new Label();
            telefonKutusu = new MaskedTextBox();
            telefonEtiket = new Label();
            finKutusu = new TextBox();
            finEtiket = new Label();
            adSoyadKutusu = new TextBox();
            adSoyadEtiket = new Label();
            biletlerListesi = new ListBox();
            biletSilButonu = new Button();
            cixisButonu = new Button();

            baslik.SuspendLayout();
            seyahatKutusu.SuspendLayout();
            insonKutusu.SuspendLayout();
            SuspendLayout();

            // baslik
            baslik.BackColor = Color.White;
            baslik.Controls.Add(universiteEtiket);
            baslik.Controls.Add(basliqEtiket);
            baslik.Dock = DockStyle.Top;
            baslik.Size = new Size(940, 115);

            universiteEtiket.AutoSize = true;
            universiteEtiket.Font = new Font("Arial", 27F, FontStyle.Bold);
            universiteEtiket.ForeColor = Color.DarkRed;
            universiteEtiket.Location = new Point(18, 28);
            universiteEtiket.Text = "⚙ | BEU";

            basliqEtiket.AutoSize = true;
            basliqEtiket.Font = new Font("Arial", 22F, FontStyle.Bold | FontStyle.Italic);
            basliqEtiket.Location = new Point(430, 42);
            basliqEtiket.Text = "BMU Travel";

            // seyahatKutusu
            seyahatKutusu.BackColor = Color.Black;
            seyahatKutusu.Controls.Add(yerDegisButonu);
            seyahatKutusu.Controls.Add(yerKutusu);
            seyahatKutusu.Controls.Add(yerEtiket);
            seyahatKutusu.Controls.Add(saatKutusu);
            seyahatKutusu.Controls.Add(saatEtiket);
            seyahatKutusu.Controls.Add(tarixKutusu);
            seyahatKutusu.Controls.Add(tarixEtiket);
            seyahatKutusu.Controls.Add(teyyinatSeheriKombosu);
            seyahatKutusu.Controls.Add(teyyinatEtiket);
            seyahatKutusu.Controls.Add(gedisSeheriKombosu);
            seyahatKutusu.Controls.Add(gedisEtiket);
            seyahatKutusu.ForeColor = Color.White;
            seyahatKutusu.Location = new Point(40, 128);
            seyahatKutusu.Size = new Size(365, 335);
            seyahatKutusu.Text = "Seyahat məlumatı";

            gedisEtiket.AutoSize = true;
            gedisEtiket.Location = new Point(20, 40);
            gedisEtiket.Text = "Gediş:";

            gedisSeheriKombosu.DropDownStyle = ComboBoxStyle.DropDownList;
            gedisSeheriKombosu.Location = new Point(115, 36);
            gedisSeheriKombosu.Size = new Size(155, 23);

            teyyinatEtiket.AutoSize = true;
            teyyinatEtiket.Location = new Point(20, 92);
            teyyinatEtiket.Text = "Təyinat:";

            teyyinatSeheriKombosu.DropDownStyle = ComboBoxStyle.DropDownList;
            teyyinatSeheriKombosu.Location = new Point(115, 88);
            teyyinatSeheriKombosu.Size = new Size(155, 23);

            yerDegisButonu.BackColor = Color.Teal;
            yerDegisButonu.ForeColor = Color.White;
            yerDegisButonu.Location = new Point(287, 39);
            yerDegisButonu.Size = new Size(55, 90);
            yerDegisButonu.Text = "<\r\n>";
            yerDegisButonu.Click += YerDegisButonu_Click;

            tarixEtiket.AutoSize = true;
            tarixEtiket.Location = new Point(20, 145);
            tarixEtiket.Text = "Tarix:";

            tarixKutusu.Location = new Point(115, 141);
            tarixKutusu.Mask = "00/00/0000";
            tarixKutusu.Size = new Size(155, 23);

            saatEtiket.AutoSize = true;
            saatEtiket.Location = new Point(20, 197);
            saatEtiket.Text = "Saat:";

            saatKutusu.Location = new Point(115, 193);
            saatKutusu.Mask = "00:00";
            saatKutusu.Size = new Size(155, 23);

            yerEtiket.AutoSize = true;
            yerEtiket.Location = new Point(20, 249);
            yerEtiket.Text = "Yer:";

            yerKutusu.Location = new Point(115, 245);
            yerKutusu.Size = new Size(155, 23);

            // insonKutusu
            insonKutusu.BackColor = Color.Black;
            insonKutusu.ForeColor = Color.White;
            insonKutusu.Location = new Point(535, 128);
            insonKutusu.Size = new Size(365, 335);
            insonKutusu.Text = "Şəxsi məlumat";
            insonKutusu.Controls.Add(biletYaratButonu);
            insonKutusu.Controls.Add(emailKutusu);
            insonKutusu.Controls.Add(emailEtiket);
            insonKutusu.Controls.Add(telefonKutusu);
            insonKutusu.Controls.Add(telefonEtiket);
            insonKutusu.Controls.Add(finKutusu);
            insonKutusu.Controls.Add(finEtiket);
            insonKutusu.Controls.Add(adSoyadKutusu);
            insonKutusu.Controls.Add(adSoyadEtiket);

            adSoyadEtiket.AutoSize = true;
            adSoyadEtiket.Location = new Point(20, 40);
            adSoyadEtiket.Text = "Ad və soyad:";

            adSoyadKutusu.Location = new Point(145, 36);
            adSoyadKutusu.Size = new Size(155, 23);

            finEtiket.AutoSize = true;
            finEtiket.Location = new Point(20, 92);
            finEtiket.Text = "FIN:";

            finKutusu.Location = new Point(145, 88);
            finKutusu.Size = new Size(155, 23);

            telefonEtiket.AutoSize = true;
            telefonEtiket.Location = new Point(20, 145);
            telefonEtiket.Text = "Telefon:";

            telefonKutusu.Location = new Point(145, 141);
            telefonKutusu.Mask = "(00) 000-00-00";
            telefonKutusu.Size = new Size(155, 23);

            emailEtiket.AutoSize = true;
            emailEtiket.Location = new Point(20, 197);
            emailEtiket.Text = "Email:";

            emailKutusu.Location = new Point(145, 193);
            emailKutusu.Size = new Size(155, 23);

            biletYaratButonu.BackColor = Color.FromArgb(0, 190, 195);
            biletYaratButonu.FlatStyle = FlatStyle.Flat;
            biletYaratButonu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            biletYaratButonu.ForeColor = Color.White;
            biletYaratButonu.Location = new Point(145, 250);
            biletYaratButonu.Size = new Size(155, 35);
            biletYaratButonu.Text = "Bilet al";
            biletYaratButonu.Click += BiletYaratButonu_Click;

            biletlerListesi.FormattingEnabled = true;
            biletlerListesi.ItemHeight = 16;
            biletlerListesi.Location = new Point(40, 485);
            biletlerListesi.Size = new Size(860, 100);

            biletSilButonu.BackColor = Color.Firebrick;
            biletSilButonu.ForeColor = Color.White;
            biletSilButonu.Location = new Point(40, 615);
            biletSilButonu.Size = new Size(155, 35);
            biletSilButonu.Text = "Bileti sil";
            biletSilButonu.Click += BiletSilButonu_Click;

            cixisButonu.BackColor = Color.Maroon;
            cixisButonu.ForeColor = Color.White;
            cixisButonu.Location = new Point(745, 615);
            cixisButonu.Size = new Size(155, 35);
            cixisButonu.Text = "Çıxış";
            cixisButonu.Click += CixisButonu_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(940, 680);
            Controls.Add(biletSilButonu);
            Controls.Add(cixisButonu);
            Controls.Add(biletlerListesi);
            Controls.Add(insonKutusu);
            Controls.Add(seyahatKutusu);
            Controls.Add(baslik);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BMU Travel";

            baslik.ResumeLayout(false);
            baslik.PerformLayout();
            seyahatKutusu.ResumeLayout(false);
            seyahatKutusu.PerformLayout();
            insonKutusu.ResumeLayout(false);
            insonKutusu.PerformLayout();
            ResumeLayout(false);
        }

        private Panel baslik;
        private Label universiteEtiket;
        private Label basliqEtiket;
        private GroupBox seyahatKutusu;
        private Button yerDegisButonu;
        private TextBox yerKutusu;
        private Label yerEtiket;
        private MaskedTextBox saatKutusu;
        private Label saatEtiket;
        private MaskedTextBox tarixKutusu;
        private Label tarixEtiket;
        private ComboBox teyyinatSeheriKombosu;
        private Label teyyinatEtiket;
        private ComboBox gedisSeheriKombosu;
        private Label gedisEtiket;
        private GroupBox insonKutusu;
        private Button biletYaratButonu;
        private TextBox emailKutusu;
        private Label emailEtiket;
        private MaskedTextBox telefonKutusu;
        private Label telefonEtiket;
        private TextBox finKutusu;
        private Label finEtiket;
        private TextBox adSoyadKutusu;
        private Label adSoyadEtiket;
        private ListBox biletlerListesi;
        private Button biletSilButonu;
        private Button cixisButonu;
    }
}

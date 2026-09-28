namespace ders5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ekranQutusu = new TextBox();
            tarixceSiyahisi = new ListBox();
            SuspendLayout();

            // Ekran (netice gosterilen sahe)
            ekranQutusu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ekranQutusu.BackColor = Color.White;
            ekranQutusu.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ekranQutusu.Location = new Point(30, 25);
            ekranQutusu.Multiline = true;
            ekranQutusu.Name = "ekranQutusu";
            ekranQutusu.ReadOnly = true;
            ekranQutusu.Size = new Size(1110, 170);
            ekranQutusu.TabIndex = 0;
            ekranQutusu.Text = "0";
            ekranQutusu.TextAlign = HorizontalAlignment.Right;

            // Emeliyyatlar tarixcesi
            tarixceSiyahisi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tarixceSiyahisi.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tarixceSiyahisi.FormattingEnabled = true;
            tarixceSiyahisi.ItemHeight = 25;
            tarixceSiyahisi.Location = new Point(890, 205);
            tarixceSiyahisi.Name = "tarixceSiyahisi";
            tarixceSiyahisi.Size = new Size(250, 465);
            tarixceSiyahisi.TabIndex = 1;

            DuymeleriYarat();

            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 185, 211);
            ClientSize = new Size(1170, 700);
            Controls.Add(ekranQutusu);
            Controls.Add(tarixceSiyahisi);
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            Text = "Kalkulyator";
            ResumeLayout(false);
            PerformLayout();
        }

        // Duymeler setir-sutun sxemi ile dinamik yaradilir
        private void DuymeleriYarat()
        {
            string[][] sxem =
            {
                new[] { "1", "2", "3", "+", "<--" },
                new[] { "4", "5", "6", "-", "%" },
                new[] { "7", "8", "9", "x", "Sqrt" },
                new[] { "c", "0", ".", "/", "=" }
            };

            const int baslangicX = 30;
            const int baslangicY = 205;
            const int eni = 132;
            const int hundurluyu = 110;
            const int eniqBosluq = 26;
            const int saqulBosluq = 20;

            int sayac = 0;

            for (int setir = 0; setir < sxem.Length; setir++)
            {
                for (int sutun = 0; sutun < sxem[setir].Length; sutun++)
                {
                    string yazi = sxem[setir][sutun];

                    var yeniDugme = new Button
                    {
                        BackColor = Color.White,
                        FlatStyle = FlatStyle.Standard,
                        Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point),
                        Location = new Point(
                            baslangicX + sutun * (eni + eniqBosluq),
                            baslangicY + setir * (hundurluyu + saqulBosluq)),
                        Name = "duyme_" + yazi.Replace("<", "geri"),
                        Size = new Size(eni, hundurluyu),
                        TabIndex = sayac++,
                        Text = yazi,
                        UseVisualStyleBackColor = true
                    };

                    yeniDugme.Click += DuymeBasildi;
                    Controls.Add(yeniDugme);
                }
            }
        }

        private TextBox ekranQutusu;
        private ListBox tarixceSiyahisi;

        #endregion
    }
}

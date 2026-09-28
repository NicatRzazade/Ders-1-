namespace ders3
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
            txtBirinciEded = new TextBox();
            txtIkinciEded = new TextBox();
            grpKalkulyator = new GroupBox();
            lblBirinciEded = new Label();
            lblIkinciEded = new Label();
            emellerKombosu = new ComboBox();
            lblEmelSeciniz = new Label();
            lblNeticeBasligi = new Label();
            lblNetice = new Label();
            btnHesabla = new Button();
            btnSil = new Button();
            grpKalkulyator.SuspendLayout();
            SuspendLayout();

            // txtBirinciEded
            txtBirinciEded.Location = new Point(94, 88);
            txtBirinciEded.Name = "txtBirinciEded";
            txtBirinciEded.PlaceholderText = "0";
            txtBirinciEded.Size = new Size(193, 23);
            txtBirinciEded.TabIndex = 0;

            // txtIkinciEded
            txtIkinciEded.Location = new Point(94, 155);
            txtIkinciEded.Name = "txtIkinciEded";
            txtIkinciEded.PlaceholderText = "0";
            txtIkinciEded.Size = new Size(193, 23);
            txtIkinciEded.TabIndex = 1;

            // grpKalkulyator
            grpKalkulyator.BackColor = SystemColors.ActiveCaption;
            grpKalkulyator.Controls.Add(btnSil);
            grpKalkulyator.Controls.Add(btnHesabla);
            grpKalkulyator.Controls.Add(lblNetice);
            grpKalkulyator.Controls.Add(lblNeticeBasligi);
            grpKalkulyator.Controls.Add(lblEmelSeciniz);
            grpKalkulyator.Controls.Add(emellerKombosu);
            grpKalkulyator.Controls.Add(lblIkinciEded);
            grpKalkulyator.Controls.Add(lblBirinciEded);
            grpKalkulyator.Controls.Add(txtBirinciEded);
            grpKalkulyator.Controls.Add(txtIkinciEded);
            grpKalkulyator.Location = new Point(21, 12);
            grpKalkulyator.Name = "grpKalkulyator";
            grpKalkulyator.Size = new Size(383, 467);
            grpKalkulyator.TabIndex = 3;
            grpKalkulyator.TabStop = false;
            grpKalkulyator.Text = "Kalkulyator";

            // lblBirinciEded
            lblBirinciEded.AutoSize = true;
            lblBirinciEded.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBirinciEded.ForeColor = SystemColors.Control;
            lblBirinciEded.Location = new Point(94, 64);
            lblBirinciEded.Name = "lblBirinciEded";
            lblBirinciEded.Size = new Size(108, 21);
            lblBirinciEded.TabIndex = 3;
            lblBirinciEded.Text = "Birinci ədəd";

            // lblIkinciEded
            lblIkinciEded.AutoSize = true;
            lblIkinciEded.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIkinciEded.ForeColor = SystemColors.Control;
            lblIkinciEded.Location = new Point(94, 131);
            lblIkinciEded.Name = "lblIkinciEded";
            lblIkinciEded.Size = new Size(108, 21);
            lblIkinciEded.TabIndex = 4;
            lblIkinciEded.Text = "İkinci ədəd";

            // emellerKombosu
            emellerKombosu.FormattingEnabled = true;
            emellerKombosu.Location = new Point(94, 231);
            emellerKombosu.Name = "emellerKombosu";
            emellerKombosu.Size = new Size(193, 23);
            emellerKombosu.TabIndex = 5;

            // lblEmelSeciniz
            lblEmelSeciniz.AutoSize = true;
            lblEmelSeciniz.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmelSeciniz.ForeColor = SystemColors.Control;
            lblEmelSeciniz.Location = new Point(94, 207);
            lblEmelSeciniz.Name = "lblEmelSeciniz";
            lblEmelSeciniz.Size = new Size(96, 21);
            lblEmelSeciniz.TabIndex = 6;
            lblEmelSeciniz.Text = "Əməl seçin";

            // lblNeticeBasligi
            lblNeticeBasligi.AutoSize = true;
            lblNeticeBasligi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNeticeBasligi.ForeColor = SystemColors.Control;
            lblNeticeBasligi.Location = new Point(94, 283);
            lblNeticeBasligi.Name = "lblNeticeBasligi";
            lblNeticeBasligi.Size = new Size(66, 21);
            lblNeticeBasligi.TabIndex = 7;
            lblNeticeBasligi.Text = "Nəticə";

            // lblNetice
            lblNetice.AutoSize = true;
            lblNetice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetice.ForeColor = SystemColors.Control;
            lblNetice.Location = new Point(217, 283);
            lblNetice.Name = "lblNetice";
            lblNetice.Size = new Size(19, 21);
            lblNetice.TabIndex = 8;
            lblNetice.Text = "0";

            // btnHesabla
            btnHesabla.Location = new Point(94, 333);
            btnHesabla.Name = "btnHesabla";
            btnHesabla.Size = new Size(193, 41);
            btnHesabla.TabIndex = 4;
            btnHesabla.Text = "Hesabla";
            btnHesabla.UseVisualStyleBackColor = true;

            // btnSil
            btnSil.Location = new Point(94, 392);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(193, 42);
            btnSil.TabIndex = 9;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 503);
            Controls.Add(grpKalkulyator);
            Name = "Form1";
            Text = "Kalkulyator";
            grpKalkulyator.ResumeLayout(false);
            grpKalkulyator.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtBirinciEded;
        private TextBox txtIkinciEded;
        private GroupBox grpKalkulyator;
        private Label lblBirinciEded;
        private Label lblIkinciEded;
        private Label lblEmelSeciniz;
        private ComboBox emellerKombosu;
        private Label lblNetice;
        private Label lblNeticeBasligi;
        private Button btnSil;
        private Button btnHesabla;
    }
}

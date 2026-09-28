namespace lesson1
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
            grpQeydiyyat = new GroupBox();
            btnQeydiyyat = new Button();
            chkQeydGoster = new CheckBox();
            txtQeydSifre = new TextBox();
            txtQeydSifreTekrar = new TextBox();
            txtAdSoyad = new TextBox();
            txtQeydPoct = new TextBox();
            grpGiris = new GroupBox();
            btnGiris = new Button();
            txtGirisSifre = new TextBox();
            txtGirisPoct = new TextBox();
            chkGirisGoster = new CheckBox();
            grpQeydiyyat.SuspendLayout();
            grpGiris.SuspendLayout();
            SuspendLayout();
            //
            // grpQeydiyyat
            //
            grpQeydiyyat.BackColor = SystemColors.InactiveCaption;
            grpQeydiyyat.Controls.Add(btnQeydiyyat);
            grpQeydiyyat.Controls.Add(chkQeydGoster);
            grpQeydiyyat.Controls.Add(txtQeydSifre);
            grpQeydiyyat.Controls.Add(txtQeydSifreTekrar);
            grpQeydiyyat.Controls.Add(txtAdSoyad);
            grpQeydiyyat.Controls.Add(txtQeydPoct);
            grpQeydiyyat.Location = new Point(92, 61);
            grpQeydiyyat.Name = "grpQeydiyyat";
            grpQeydiyyat.Size = new Size(214, 273);
            grpQeydiyyat.TabIndex = 0;
            grpQeydiyyat.TabStop = false;
            grpQeydiyyat.Text = "Qeydiyyat";
            //
            // btnQeydiyyat
            //
            btnQeydiyyat.Location = new Point(31, 229);
            btnQeydiyyat.Name = "btnQeydiyyat";
            btnQeydiyyat.Size = new Size(149, 23);
            btnQeydiyyat.TabIndex = 8;
            btnQeydiyyat.Text = "Təsdiq et";
            btnQeydiyyat.UseVisualStyleBackColor = true;
            btnQeydiyyat.Click += btnQeydiyyat_Click;
            //
            // chkQeydGoster
            //
            chkQeydGoster.AutoSize = true;
            chkQeydGoster.Location = new Point(31, 204);
            chkQeydGoster.Name = "chkQeydGoster";
            chkQeydGoster.Size = new Size(95, 19);
            chkQeydGoster.TabIndex = 4;
            chkQeydGoster.Text = "Şifrəni göstər";
            chkQeydGoster.UseVisualStyleBackColor = true;
            chkQeydGoster.CheckedChanged += chkQeydGoster_CheckedChanged;
            //
            // txtQeydSifre
            //
            txtQeydSifre.Location = new Point(31, 164);
            txtQeydSifre.Name = "txtQeydSifre";
            txtQeydSifre.Size = new Size(149, 23);
            txtQeydSifre.TabIndex = 2;
            txtQeydSifre.UseSystemPasswordChar = true;
            //
            // txtQeydSifreTekrar
            //
            txtQeydSifreTekrar.Location = new Point(31, 124);
            txtQeydSifreTekrar.Name = "txtQeydSifreTekrar";
            txtQeydSifreTekrar.Size = new Size(149, 23);
            txtQeydSifreTekrar.TabIndex = 3;
            txtQeydSifreTekrar.UseSystemPasswordChar = true;
            //
            // txtAdSoyad
            //
            txtAdSoyad.Location = new Point(31, 43);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(149, 23);
            txtAdSoyad.TabIndex = 0;
            //
            // txtQeydPoct
            //
            txtQeydPoct.Location = new Point(31, 83);
            txtQeydPoct.Name = "txtQeydPoct";
            txtQeydPoct.Size = new Size(149, 23);
            txtQeydPoct.TabIndex = 1;
            //
            // grpGiris
            //
            grpGiris.BackColor = SystemColors.InactiveCaption;
            grpGiris.Controls.Add(btnGiris);
            grpGiris.Controls.Add(txtGirisSifre);
            grpGiris.Controls.Add(txtGirisPoct);
            grpGiris.Controls.Add(chkGirisGoster);
            grpGiris.Location = new Point(452, 61);
            grpGiris.Name = "grpGiris";
            grpGiris.Size = new Size(221, 231);
            grpGiris.TabIndex = 0;
            grpGiris.TabStop = false;
            grpGiris.Text = "Daxil Ol";
            //
            // btnGiris
            //
            btnGiris.Location = new Point(31, 182);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(163, 23);
            btnGiris.TabIndex = 9;
            btnGiris.Text = "Təsdiq et";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            //
            // txtGirisSifre
            //
            txtGirisSifre.Location = new Point(31, 93);
            txtGirisSifre.Name = "txtGirisSifre";
            txtGirisSifre.Size = new Size(163, 23);
            txtGirisSifre.TabIndex = 7;
            txtGirisSifre.UseSystemPasswordChar = true;
            //
            // txtGirisPoct
            //
            txtGirisPoct.Location = new Point(31, 43);
            txtGirisPoct.Name = "txtGirisPoct";
            txtGirisPoct.Size = new Size(163, 23);
            txtGirisPoct.TabIndex = 6;
            //
            // chkGirisGoster
            //
            chkGirisGoster.AutoSize = true;
            chkGirisGoster.Location = new Point(31, 140);
            chkGirisGoster.Name = "chkGirisGoster";
            chkGirisGoster.Size = new Size(95, 19);
            chkGirisGoster.TabIndex = 5;
            chkGirisGoster.Text = "Şifrəni göstər";
            chkGirisGoster.UseVisualStyleBackColor = true;
            chkGirisGoster.CheckedChanged += chkGirisGoster_CheckedChanged;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpGiris);
            Controls.Add(grpQeydiyyat);
            Name = "Form1";
            Text = "Sign in or Sign up";
            grpQeydiyyat.ResumeLayout(false);
            grpQeydiyyat.PerformLayout();
            grpGiris.ResumeLayout(false);
            grpGiris.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpQeydiyyat;
        private GroupBox grpGiris;
        private TextBox txtQeydSifreTekrar;
        private TextBox txtQeydSifre;
        private TextBox txtQeydPoct;
        private TextBox txtAdSoyad;
        private Button btnQeydiyyat;
        private CheckBox chkQeydGoster;
        private Button btnGiris;
        private TextBox txtGirisSifre;
        private TextBox txtGirisPoct;
        private CheckBox chkGirisGoster;
    }
}

namespace ders3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            emellerKombosu.Items.AddRange(new object[] { "+", "-", "*", "/" });
            emellerKombosu.SelectedIndex = 0;
            btnHesabla.Click += HesablaEmeliyyat;
            btnSil.Click += TamaminiSil;
        }

        // İki ədədi götürüb eməl aparır
        private void HesablaEmeliyyat(object? gonderen, EventArgs args)
        {
            if (!GirislerDuzgunmu(out decimal birinciEded, out decimal ikinciEded))
                return;

            decimal netice = Hesabla(birinciEded, ikinciEded);
            lblNetice.Text = netice.ToString();
        }

        // Girişi təsdiq edir
        private bool GirislerDuzgunmu(out decimal birinciEded, out decimal ikinciEded)
        {
            birinciEded = 0;
            ikinciEded = 0;

            if (!decimal.TryParse(txtBirinciEded.Text, out birinciEded) ||
                !decimal.TryParse(txtIkinciEded.Text, out ikinciEded))
            {
                XetaGoster("Rəqəm daxil edin.");
                return false;
            }

            if (emellerKombosu.SelectedItem == null)
            {
                XetaGoster("Əməl seçin (+, -, *, /).");
                return false;
            }

            return true;
        }

        // Hesablamağı apara
        private decimal Hesabla(decimal a, decimal b)
        {
            return emellerKombosu.SelectedItem?.ToString() switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" => b == 0 ? (XetaGoster("Sıfıra bölə bilməzsiniz."), 0) : a / b,
                _ => 0
            };
        }

        // Bütün məlumatı silir
        private void TamaminiSil(object? gonderen, EventArgs args)
        {
            txtBirinciEded.Clear();
            txtIkinciEded.Clear();
            emellerKombosu.SelectedIndex = 0;
            lblNetice.Text = "0";
            txtBirinciEded.Focus();
        }

        // Xəta mesajı göstərir
        private void XetaGoster(string mesaj)
        {
            lblNetice.Text = mesaj;
        }
    }
}

namespace ders5
{
    public partial class Form1 : Form
    {
        // Kalkulyatorun daxili veziyyeti
        private bool yeniGirisGozlenir;
        private char secilmisEmel;
        private double birinciEded;

        public Form1()
        {
            InitializeComponent();
            ekranQutusu.Text = "0";
        }

        // Butun duymeler ucun vahid qebuledici
        private void DuymeBasildi(object? gonderen, EventArgs args)
        {
            if (gonderen is not Button dugme)
                return;

            string yazi = dugme.Text;

            if (yazi.Length == 1 && char.IsDigit(yazi[0]))
            {
                ReqemElaveEt(yazi);
                return;
            }

            switch (yazi)
            {
                case ".":    OndaliqNoqte(); break;
                case "c":    HamisiniSil(); break;
                case "<--":  SonSimvoluSil(); break;
                case "+":    EmelSec('+'); break;
                case "-":    EmelSec('-'); break;
                case "x":    EmelSec('*'); break;
                case "/":    EmelSec('/'); break;
                case "=":    NeticeniHesabla(); break;
                case "Sqrt": KvadratKok(); break;
                case "%":    FaizeCevir(); break;
            }
        }

        private void ReqemElaveEt(string reqem)
        {
            if (yeniGirisGozlenir)
            {
                ekranQutusu.Text = string.Empty;
                yeniGirisGozlenir = false;
            }

            if (ekranQutusu.Text == "0")
                ekranQutusu.Text = string.Empty;

            ekranQutusu.Text = ekranQutusu.Text + reqem;
        }

        private void OndaliqNoqte()
        {
            if (ekranQutusu.Text.IndexOf('.') < 0)
                ekranQutusu.Text = ekranQutusu.Text + ".";
        }

        private void HamisiniSil()
        {
            ekranQutusu.Text = "0";
            yeniGirisGozlenir = false;
            secilmisEmel = '\0';
            birinciEded = 0;
        }

        private void SonSimvoluSil()
        {
            string cari = ekranQutusu.Text;
            ekranQutusu.Text = cari.Length > 1
                ? cari[..^1]
                : "0";
        }

        private void EmelSec(char isare)
        {
            if (string.IsNullOrEmpty(ekranQutusu.Text) ||
                !double.TryParse(ekranQutusu.Text, out birinciEded))
            {
                XetaGoster("Invalid value");
                return;
            }

            secilmisEmel = isare;
            yeniGirisGozlenir = true;
        }

        private void NeticeniHesabla()
        {
            if (!double.TryParse(ekranQutusu.Text, out double ikinciEded))
            {
                XetaGoster("Invalid value");
                return;
            }

            double netice;

            if (secilmisEmel == '+')
            {
                netice = birinciEded + ikinciEded;
            }
            else if (secilmisEmel == '-')
            {
                netice = birinciEded - ikinciEded;
            }
            else if (secilmisEmel == '*')
            {
                netice = birinciEded * ikinciEded;
            }
            else if (secilmisEmel == '/')
            {
                if (ikinciEded == 0)
                {
                    XetaGoster("Divide by zero error");
                    return;
                }
                netice = birinciEded / ikinciEded;
            }
            else
            {
                return;
            }

            string qeyd = $"{birinciEded} {secilmisEmel} {ikinciEded} = {netice}";
            ekranQutusu.Text = netice.ToString();
            tarixceSiyahisi.Items.Insert(0, qeyd);
            yeniGirisGozlenir = true;
        }

        private void KvadratKok()
        {
            if (!double.TryParse(ekranQutusu.Text, out double eded) || eded < 0)
            {
                XetaGoster("Invalid value");
                return;
            }

            ekranQutusu.Text = Math.Sqrt(eded).ToString();
            yeniGirisGozlenir = true;
        }

        private void FaizeCevir()
        {
            if (!double.TryParse(ekranQutusu.Text, out double eded))
            {
                XetaGoster("Invalid value");
                return;
            }

            ekranQutusu.Text = (eded * 100).ToString();
            yeniGirisGozlenir = true;
        }

        private void XetaGoster(string mesaj)
        {
            ekranQutusu.Text = mesaj;
        }
    }
}

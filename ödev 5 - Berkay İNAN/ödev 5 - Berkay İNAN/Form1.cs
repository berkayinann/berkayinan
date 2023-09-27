namespace ödev_5___Berkay_İNAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtsifre_TextChanged(object sender, EventArgs e)
        {
            string sifre = txtsifre.Text;
            int uzunluk = sifre.Length;
            bool ozelKarakter = false;
            bool sayi = false;

            foreach (char karakter in sifre)
            {
                if (char.IsDigit(karakter))
                {
                    sayi = true;
                }
                else if (!char.IsLetterOrDigit(karakter))
                {
                    ozelKarakter = true;
                }
            }
            if (uzunluk > 6)
            {
                if (ozelKarakter && sayi)
                {
                    label1.Text = "Yüksek Güvenlikli";
                    label1.ForeColor = Color.Green;
                }
                else
                {
                    label1.Text = "Orta Güvenlikli";
                    label1.ForeColor = Color.Blue;
                }
            }
            else
            {
                label1.Text = "Düşük Güvenlikli";
                label1.ForeColor = Color.Red;

            }
        }
    }
}

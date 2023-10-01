using System.Text;

namespace Ödev_6___Berkay_İNAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bturet_Click(object sender, EventArgs e)
        {
            int sifressayisi = (int)numericsifresayisi.Value;
            int sifreuzunlugu =(int)numericsifreuzunlugu.Value;
            string karakterler = "";
            string sifre = "";

            if (cbbuyukharf.Checked)
            {
                for (int i = 65; i <= 90; i++)
                {
                    karakterler += ((char)i).ToString() + "";
                }
            }
            if (cbkucukharf.Checked)
            {
                for (int i = 97; i < 122; i++)
                {
                    karakterler += ((char)i).ToString() + "";
                }
            }
            if (cbrakam.Checked)
            {
                for (int i = 48; i < 57; i++)
                {
                    karakterler += ((char)i).ToString() + "";
                }
            }
            if (cbozelkarakter.Checked)
            {
                for (int i = 33; i < 47; i++)
                {
                    karakterler += ((char)i).ToString() + "";
                }
            }

            Random rnd = new Random();
            StringBuilder sifreler = new StringBuilder();

            for (int j = 0; j < sifressayisi; j++)
            {
                sifre = $" {j + 1}. şifre : ";
                for (int k = 0; k < sifreuzunlugu; k++)
                {
                    int giris = rnd.Next(karakterler.Length);
                    sifre += karakterler[giris];
                }
                sifreler.AppendLine(sifre);

                txtsifreekranı.Text =sifreler.ToString();
            }
            

        }
    }
}
using System.Diagnostics.Metrics;
using System.Drawing.Text;

namespace licznikznakow
{
    public partial class Form1 : Form
    {
        public Dictionary<char, int> slownik = new Dictionary<char, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            slownik.Clear();
            int ilelit = 0;
            for (int i = 0; i < textBox1.Text.Length; i++) {
                char lz = textBox1.Text.ToLower()[i];
                
                if(lz >="a")
                if (slownik.ContainsKey(lz))
                {
                    slownik[lz]++;
                }
                else
                {
                    slownik.Add(lz, 1);
                }
            }

            textBox2.Clear();
            foreach (var k in slownik.Keys)
            {
                textBox2.Text += $"{k}: {slownik[k]} \r\n";
            }

        }
    }
}

namespace AdisyonTakip
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        Form2 ikinciForm;

        Veriler veri;

        public Form1()
        {
            InitializeComponent();
        }

        void button1_Click(object sender, EventArgs e)
        {
            if (ikinciForm == null)
            {
                ikinciForm = new Form2 { ilkForm = this };
                ikinciForm.Show();
                Hide();
            }
            else if (ikinciForm.IsDisposed)
            {
                ikinciForm = new Form2 { ilkForm = this };
                ikinciForm.Show();
            }
            else
            {
                if (ikinciForm.Visible)
                {
                    ikinciForm.Hide();
                }
                else
                {
                    ikinciForm.Show();
                }
            }
        }

        void Form1_Load(object sender, EventArgs e)
        {
            // var veri = new Veriler();
            // gridControl1.DataSource = veri;
            // gridControl1.DataMember = "Urunler";
            verilerBindingSource.DataSource = new Veriler();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdisyonTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Veriler veri;

        Form2 ikinciForm;

        private void Form1_Load(object sender, EventArgs e)
        {
            var veri = new Veriler();
            gridControl1.DataSource = veri;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ikinciForm == null)
            {
                ikinciForm = new Form2();
                ikinciForm.ilkForm = this;
                ikinciForm.Show();
                Hide();
            }
            else if (ikinciForm.IsDisposed)
            {
                ikinciForm = new Form2();
                ikinciForm.ilkForm = this;
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programmingLanguage
{
    public partial class examples : Form
    {
        public examples()
        {
            InitializeComponent();
        }

        private void toplama_Click(object sender, EventArgs e)
        {
            toplama topla = new toplama();
            topla.ShowDialog();
        }

        private void cikarma_Click(object sender, EventArgs e)
        {
            cikarma cikar = new cikarma();
            cikar.ShowDialog();
        }

        private void carpma_Click(object sender, EventArgs e)
        {
            carpma carp = new carpma();
            carp.ShowDialog();
        }

        private void bolme_Click(object sender, EventArgs e)
        {
            bolme bol = new bolme();
            bol.ShowDialog();
        }
    }
}

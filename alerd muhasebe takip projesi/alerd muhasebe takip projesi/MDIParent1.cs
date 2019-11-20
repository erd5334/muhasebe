using System;
using System.Windows.Forms;

namespace alerd_muhasebe_takip_projesi
{
    public partial class MDIParent1 : Form
    {

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void stokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var stok = new Formlar.stok();
            stok.MdiParent = this;
            stok.WindowState= FormWindowState.Maximized;
            stok.Show();
        }

        private void cariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cari = new Formlar.cari();
            cari.MdiParent = this;
            cari.WindowState= FormWindowState.Maximized;
            cari.Show();
        }

        private void bankaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var banka = new Formlar.banka();
            banka.MdiParent = this;
            banka.WindowState = FormWindowState.Maximized;
            banka.Show();
        }

        private void kasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var kasa = new Formlar.kasa();
            kasa.MdiParent = this;
            kasa.WindowState = FormWindowState.Maximized;
            kasa.Show();
        }

        private void faturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fatura = new Formlar.fatura();
            fatura.MdiParent = this;
            fatura.WindowState = FormWindowState.Maximized;
            //fatura.BackgroundImage= Properties.Resources.arkaplan;
            fatura.Show();
        }

        private void irsaliyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var irsaliye = new Formlar.irsaliye();
            irsaliye.MdiParent = this;
            irsaliye.WindowState = FormWindowState.Maximized;
            //irsaliye.BackgroundImage= Properties.Resources.arkaplan;
            irsaliye.Show();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

           // this.BackgroundImage = Properties.Resources.arkaplan;
        }
    }
}

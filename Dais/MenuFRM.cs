using Dais.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dais
{
    public partial class MenuFRM : Form
    {
        public Daire daire { get; set; }
        public MenuFRM()
        {
            InitializeComponent();

        }
      
        private void daimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            daimiUC1.Visible = true;
        }

        private void müvəqqətiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            daimiUC1.Visible = false;
        }

        private void MenuFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            //GirisFRM giris = new GirisFRM();
            //giris.Show();
        }

        private void MenuFRM_Load(object sender, EventArgs e)
        {
            if (daire != null)
            {
                lbldskadi.Text = daire.DaireAdi;
            }
        }
    }
}

using Dais.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dais
{
    public partial class GirisFRM : Form
    {
        //Thread thr;
        
       
        public GirisFRM()
        {
            InitializeComponent();
        }
        
        private void btngiris_Click(object sender, EventArgs e)
        {
            using (EntityDataModels db = new EntityDataModels())
            {
               Daire daire = (from ist in db.Istifadecilers
                         join d in db.Daires on ist.DaireKodu equals d.DaireKodu
                         where ist.Ist_ad == txtlogin.Text
                         && ist.Parol == txtparol.Text
                         select d).FirstOrDefault<Daire>();
                if (daire != null)
                {
                    MenuFRM menu = new MenuFRM();
                    menu.daire = daire;
                    this.Hide();
                    menu.Show();
                    //this.Close();
                    //thr = new Thread(yeniform);
                    //thr.TrySetApartmentState(ApartmentState.STA);
                    //thr.Start();

                }
                else
                {
                    lblmessage.Text = "İstifadəçi adı və ya parol səhvdir.";
                }
            }
        }


        private void pnlgiris_Paint(object sender, PaintEventArgs e)
        {
            this.AcceptButton = btngiris;

        }
        //private void yeniform()
        //{
        //    Application.Run(new Menu());
        //}
    }
}

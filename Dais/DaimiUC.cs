using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dais.EntityModel;
using Dais.Models;

namespace Dais
{
    public partial class DaimiUC : UserControl
    {
        EntityDataModels db = new EntityDataModels();
        ForComponentLoad fcl = new ForComponentLoad();
        public DaimiUC()
        {
            InitializeComponent();
        }

        private void DaimiUC_Load_1(object sender, EventArgs e)
        {
            MenuFRM menu = this.Parent as MenuFRM;
            cmbmenteqeload(menu.daire.DaireKodu);
            cmbbinamertebeload();
            cmbsebeblaod();
            cmbdogumiliload();
            cmbdogumayload();
            cmbdogumgunuload();
            cmbseriyaload();
            cmbstatuslaod();



        }
        void cmbseriyaload()
        {
            cmbseriya.DataSource = fcl.seriyaload();
            cmbseriya.ValueMember = "VesiqeSeriyaID";
            cmbseriya.DisplayMember = "VesiqeSeriyaAdi";
        }
        void cmbdogumgunuload()
        {
            cmbdogumgunu.DataSource = fcl.dogumgunuload();
            cmbdogumgunu.ValueMember = "ID";
            cmbdogumgunu.DisplayMember = "Dogumgunu";
        }
        void cmbdogumayload()
        {
            cmbdogumay.DataSource = fcl.dogumayiload();
            cmbdogumay.ValueMember = "ID";
            cmbdogumay.DisplayMember = "Dogumayi";
        }
        void cmbdogumiliload()
        {
            cmbdogumili.DataSource = fcl.dogumiliload();
            cmbdogumili.ValueMember = "ID";
            cmbdogumili.DisplayMember = "Dogumili";
        }

        void cmbmenteqeload(byte dairekodu)
        {
            cmbmenteqe.DataSource = fcl.menteqeload(dairekodu);
            cmbmenteqe.ValueMember = "MenteqeID";
            cmbmenteqe.DisplayMember = "Menteqekodu";
        }
        void cmbprospkuceload(short MenteqeID)
        {
            cmbprospkuce.DataSource = fcl.prospektkucheload(MenteqeID);
            cmbprospkuce.ValueMember = "ProspKucheDaireMentID";
            cmbprospkuce.DisplayMember = "ProspektKucheAdi";
        }
        void cmbbinamertebeload()
        {
            cmbbinamertebe.DataSource = fcl.binamertebeload();
            cmbbinamertebe.ValueMember = "ID";
            cmbbinamertebe.DisplayMember = "Mertebenomresi";
        }
        void cmbsebeblaod()
        {
            cmbsebeb.DataSource = fcl.sebebload();
            cmbsebeb.ValueMember = "QeydiyyatSebebID";
            cmbsebeb.DisplayMember = "QeydiyyatSebebAdi";
        }
        void cmbstatuslaod()
        {
            cmbstatus.DataSource = fcl.statusload();
            cmbstatus.ValueMember = "SeciciStatusID";
            cmbstatus.DisplayMember = "SeciciStatusAdi";
        }

        private void cmbmenteqe_SelectedIndexChanged(object sender, EventArgs e)
        {
            short number = 0;
            if (short.TryParse(cmbmenteqe.SelectedValue.ToString(), out number))
            {
                short MenteqeID = short.Parse(cmbmenteqe.SelectedValue.ToString());
                lblseherqesebekend.Text = fcl.unvanload(MenteqeID);
                cmbprospkuceload(MenteqeID);
                grvdaimi.DataSource = (from d in db.Daimis
                                       where d.MenteqeID == MenteqeID
                                       select d).ToList();
            }  
        }

        private void cmbprospkuce_SelectedIndexChanged(object sender, EventArgs e)
        {
            short number = 0;
            if (short.TryParse(cmbprospkuce.SelectedValue.ToString(), out number))
            {
                int ProspKucheDaireMentID = int.Parse(cmbprospkuce.SelectedValue.ToString());
                cmbev.DataSource = fcl.evload(ProspKucheDaireMentID);
                cmbev.ValueMember = "EvID";
                cmbev.DisplayMember = "EvAdi";
            }
        }
    }
}

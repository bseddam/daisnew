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
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Dais
{
    public partial class DaimiUC : UserControl
    {

        ForComponentLoad fcl = new ForComponentLoad();
        Daimi daimi = new Daimi();


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
            cmbqurumadiload();
            
        }
        void cmbqurumadiload()
        {
            cmbqurumadi.DataSource = fcl.qurumload();
            cmbqurumadi.ValueMember = "QurumID";
            cmbqurumadi.DisplayMember = "QurumAdi";
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
        void cmbyasmenload(short MenteqeID)
        {
            cmbyasmen.DataSource = fcl.YashayishMenteqesiload(MenteqeID);
            cmbyasmen.ValueMember = "YashMenDaireMentID";
            cmbyasmen.DisplayMember = "YashayishMenteqesiAdi";
        }
        void cmbprospkuceload(short YashMenDaireMentID)
        {
            cmbprospkuce.DataSource = fcl.prospektkucheload(YashMenDaireMentID);
            cmbprospkuce.ValueMember = "ProspKucheDaireMentID";
            cmbprospkuce.DisplayMember = "ProspektKucheAdi";
        }
        void cmbevload(int ProspKucheDaireMentID)
        {
            cmbev.DataSource = fcl.evload(ProspKucheDaireMentID);
            cmbev.ValueMember = "EvID";
            cmbev.DisplayMember = "EvAdi";
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
        void grvdaimiload(short MenteqeID)
        {
            gcdaimi.DataSource = fcl.daimiload(MenteqeID);
            grvdaimi.Columns["SeciciID"].Visible = false;
            grvdaimi.Columns["MenteqeKodu"].Caption = "Məntəqə";
            grvdaimi.Columns["Soyad"].Caption = "Soyad";
            grvdaimi.Columns["Ad"].Caption = "Ad";
            grvdaimi.Columns["AtaAdi"].Caption = "Ata Adi";
            grvdaimi.Columns["Dogumili"].Caption = "Doğum ili";
            grvdaimi.Columns["Pinkod"].Caption = "Finkod";
            grvdaimi.Columns["VesiqeNomresi"].Caption = "Vəsiqə Nömrəsi";
            grvdaimi.Columns["Cins"].Caption = "Cins";
        }

        private void cmbmenteqe_SelectedIndexChanged(object sender, EventArgs e)
        {
            short number = 0;
            if (short.TryParse(cmbmenteqe.SelectedValue.ToString(), out number))
            {
                short MenteqeID = short.Parse(cmbmenteqe.SelectedValue.ToString());
                cmbyasmenload(MenteqeID);
                grvdaimiload(MenteqeID);
            }  
        }

        private void cmbprospkuce_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbprospkuce.SelectedValue != null)
            {
                short number = 0;
                if (short.TryParse(cmbprospkuce.SelectedValue.ToString(), out number))
                {
                    int ProspKucheDaireMentID = int.Parse(cmbprospkuce.SelectedValue.ToString());
                    cmbevload(ProspKucheDaireMentID);
                }
            }
        }

        private void btntesdiqdaimi_Click(object sender, EventArgs e)
        {
            using (EntityDataModels db = new EntityDataModels())
            {
                
                short number = 0;
                byte number1 = 0;
                string mesajlar = "";
                if (cmbmenteqe.SelectedValue != null)
                {
                    if (short.Parse(cmbmenteqe.SelectedValue.ToString()) != 0)
                    {
                        daimi.MenteqeID = short.Parse(cmbmenteqe.SelectedValue.ToString());
                    }
                    else
                    {
                        mesajlar = mesajlar + "Məntəqə boş ola bilməz.";
                    }
                }
                if (cmbyasmen.SelectedValue != null)
                {
                    if (int.Parse(cmbyasmen.SelectedValue.ToString()) != 0)
                    {
                        daimi.YashMenDaireMentID = short.Parse(cmbyasmen.SelectedValue.ToString());
                    }
                    else
                    {
                        mesajlar = mesajlar + " Yaşayış məntəqəsi boş ola bilməz.";
                    }
                }
                if (cmbprospkuce.SelectedValue != null)
                {
                    //if (int.Parse(cmbprospkuce.SelectedValue.ToString()) != 0)
                    {
                        daimi.ProspKucheDaireMentID = int.Parse(cmbprospkuce.SelectedValue.ToString());
                    }
                    //else
                    {
                        //mesajlar = mesajlar + " Prospekt küçə boş ola bilməz.";
                    }
                }
                if (cmbev.SelectedValue != null)
                {
                    if (int.Parse(cmbev.SelectedValue.ToString()) != 0)
                    {
                        daimi.EvID = int.Parse(cmbev.SelectedValue.ToString());
                    }
                }

                daimi.Soyad = txtsoyad.Text;
                daimi.Ad = txtad.Text;
                daimi.AtaAdi = txtataadi.Text;
                if (cmbdogumgunu.SelectedValue != null)
                {
                    if (byte.TryParse(cmbdogumgunu.SelectedValue.ToString(), out number1))
                    {
                        daimi.DogumGunu = byte.Parse(cmbdogumgunu.SelectedValue.ToString());
                    }
                }
                if (cmbdogumay.SelectedValue != null)
                {
                    if (byte.TryParse(cmbdogumay.SelectedValue.ToString(), out number1))
                    {
                        daimi.DogumAyi = byte.Parse(cmbdogumay.SelectedValue.ToString());
                    }
                }
                if (cmbdogumili.SelectedValue != null)
                {
                    if (short.TryParse(cmbdogumili.SelectedValue.ToString(), out number))
                    {
                        daimi.DogumIli = short.Parse(cmbdogumili.SelectedValue.ToString());
                    }
                }
                if (rbqadin.Checked)
                {
                    daimi.Cins = false;
                    
                }
                else if (rbkisi.Checked)
                {
                    daimi.Cins = true;
                }
                else
                {
                    mesajlar = mesajlar + " Cins boş ola bilməz.";
                }
                if (cmbbinamertebe.SelectedValue != null)
                {
                    if (byte.TryParse(cmbbinamertebe.SelectedValue.ToString(), out number1))
                    {
                        daimi.Mertebe = byte.Parse(cmbbinamertebe.SelectedValue.ToString());
                    }
                }

                daimi.Menzil = txtmenzil.Text;
                if (cmbstatus.SelectedValue != null)
                {
                    if (byte.TryParse(cmbstatus.SelectedValue.ToString(), out number1))
                    {
                        daimi.SeciciStatusID = byte.Parse(cmbstatus.SelectedValue.ToString());
                    }
                }
                if (cmbsebeb.SelectedValue != null)
                {
                    if (byte.TryParse(cmbsebeb.SelectedValue.ToString(), out number1))
                    {
                        daimi.QeydiyyatSebebID = byte.Parse(cmbsebeb.SelectedValue.ToString());
                    }
                }
                if (cmbseriya.SelectedValue != null)
                {
                    if (byte.TryParse(cmbseriya.SelectedValue.ToString(), out number1))
                    {
                        daimi.VesiqeSeriyaID = byte.Parse(cmbseriya.SelectedValue.ToString());
                    }
                }
                daimi.VesiqeNomresi = txtvesiqenomresi.Text;
                //if (byte.TryParse(cmbqurumadi.SelectedValue.ToString(), out number1))
                //{
                //    daimi.VesiqeVerenQurum = byte.Parse(cmbqurumadi.SelectedValue.ToString());
                //}

                daimi.VesiqeVerilmeTarixi = DateTime.Parse(dtpvesverilmetar.Text);
                daimi.VesiqeEtibarliqTarixi = DateTime.Parse(dtpvesverilmetar.Text);
                daimi.DaxiledilmeTarixi =DateTime.Now;
                daimi.Pinkod = txtfinkod.Text;
                daimi.QeyCixmaVereqi = false;

                ValidationContext context = new ValidationContext(daimi, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();


                if (!Validator.TryValidateObject(daimi, context, errors, true) || mesajlar != "")
                {
                    foreach (ValidationResult result in errors)
                    {
                        mesajlar = mesajlar + " " + result.ErrorMessage;
                    }
                    MessageBox.Show(mesajlar);
                }
                else
                {
                    if (daimi.SeciciID == 0)
                    {
                        db.Daimis.Add(daimi);
                        MessageBox.Show("Seçici əlavə olundu");
                    }
                    else
                    {
                        db.Entry(daimi).State = EntityState.Modified;
                        MessageBox.Show("Seçici düzəliş olundu");
                    }
                    db.SaveChanges();
                    bosalt();
                    enablefalsetrue(false);
                    grvdaimiload(daimi.MenteqeID);
                }
            }
        }

        

        void bosalt()
        {
            foreach (Control item in this.pnldaimisol.Controls)
            {
                if (item.GetType().Equals(typeof(TextBox)))
                {
                    TextBox t1 = item as TextBox;
                    t1.Text = string.Empty;
                }
                if (item.GetType().Equals(typeof(ComboBox)))
                {
                    ComboBox cmb1 = item as ComboBox;
                    cmb1.SelectedIndex = 0;
                }
                if (item.GetType().Equals(typeof(DateTimePicker)))
                {
                    DateTimePicker dateTimePicker = item as DateTimePicker;
                    dateTimePicker.Text = "" ;
                }
            }
            rbkisi.Checked = false;
            rbqadin.Checked = false;
            rbyeni.Checked = false;
            rbkohne.Checked = false;
        }
        void enablefalsetrue(bool dey)
        {
            foreach (Control item in this.pnldaimisol.Controls)
            {
                if (item.GetType().Equals(typeof(TextBox)))
                {
                    TextBox t1 = item as TextBox;
                    t1.Enabled= dey;
                }
                if (item.GetType().Equals(typeof(ComboBox)))
                {
                    ComboBox cmb1 = item as ComboBox;
                    cmb1.Enabled= dey;
                }
            }
            rbkisi.Enabled = dey;
            rbqadin.Enabled = dey;
            rbyeni.Enabled = dey;
            rbkohne.Enabled = dey;
            btntesdiqdaimi.Enabled = dey;
        }
        private void btnyeni_Click(object sender, EventArgs e)
        {
            daimi.SeciciID = 0;
            bosalt();
            enablefalsetrue(true);
        }
        private void btnduzelis_Click(object sender, EventArgs e)
        {
            var index = grvdaimi.FocusedRowHandle;
            if (index != -1)
            {
                daimi.SeciciID = Convert.ToInt64(grvdaimi.GetRowCellValue(index, "SeciciID").ToString());
            }
            
            enablefalsetrue(true);
        }
        private void btnsil_Click(object sender, EventArgs e)
        {

        }

        private void grvdaimi_Click(object sender, EventArgs e)
        {
            
            var index = grvdaimi.FocusedRowHandle;

            if (grvdaimi.GetRowCellValue(index, "Soyad") != null)
            {
                txtsoyad.Text = grvdaimi.GetRowCellValue(index, "Soyad").ToString();
            }
            if (grvdaimi.GetRowCellValue(index, "Ad") != null)
            {
                txtad.Text = grvdaimi.GetRowCellValue(index, "Ad").ToString();
            }
            if (grvdaimi.GetRowCellValue(index, "AtaAdi") != null)
            {
                txtataadi.Text = grvdaimi.GetRowCellValue(index, "AtaAdi").ToString();
            }
            if (grvdaimi.GetRowCellValue(index, "Dogumili") != null)
            {
                cmbdogumili.SelectedValue = int.Parse(grvdaimi.GetRowCellValue(index, "Dogumili").ToString());
            }
            if (grvdaimi.GetRowCellValue(index, "Cins") != null)
            {
                if (grvdaimi.GetRowCellValue(index, "Cins").ToString() == "Qadın")
                {
                    rbkisi.Checked = false;
                    rbqadin.Checked = true;
                }
                else
                {
                    rbkisi.Checked = true;
                    rbqadin.Checked = false;
                }
            }

            if (grvdaimi.GetRowCellValue(index, "Pinkod") != null)
            {
                txtfinkod.Text = grvdaimi.GetRowCellValue(index, "Pinkod").ToString();
            }


        }

        private void cmbyasmen_SelectedIndexChanged(object sender, EventArgs e)
        {
            short number = 0;
            if (short.TryParse(cmbyasmen.SelectedValue.ToString(), out number))
            {
                short YashMenDaireMentID = short.Parse(cmbyasmen.SelectedValue.ToString());
                cmbprospkuceload(YashMenDaireMentID);
            }
        }


       
    }
}

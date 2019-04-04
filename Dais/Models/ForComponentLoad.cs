using Dais.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dais.Models
{
    class ForComponentLoad
    {
        public List<ModelMenteqe> menteqeload(byte dairekodu)
        {
            List<ModelMenteqe> menteqes;
            using (EntityDataModels db = new EntityDataModels())
            {
                menteqes = (from men in db.Menteqes
                            where men.DaireKodu == dairekodu
                            select new ModelMenteqe()
                            {
                                MenteqeID = men.MenteqeID,
                                MenteqeKodu = men.MenteqeKodu.ToString()
                            }).ToList<ModelMenteqe>();
                ModelMenteqe modelMenteqe = new ModelMenteqe() { MenteqeID = 0, MenteqeKodu = "" };
                menteqes.Insert(0, modelMenteqe);
            }
           
            return menteqes;
        }
        public List<ModelYashMenDaireMent> YashayishMenteqesiload(short menteqeid)
        {
            List<ModelYashMenDaireMent> yashayishMenteqesis;
            using (EntityDataModels db = new EntityDataModels())
            {
                yashayishMenteqesis = (from yasmen in db.YashayishMenteqesis
                                       join yasmendm in db.YashMenDaireMents on yasmen.YashayishMenteqesiID
                                       equals yasmendm.YashayishMenteqesiID
                                       where yasmendm.MenteqeID == menteqeid
                                       select new ModelYashMenDaireMent()
                                       {
                                           YashMenDaireMentID = yasmendm.YashMenDaireMentID,
                                           YashayishMenteqesiAdi = yasmen.YashayishMenteqesiAdi
                                       }).ToList<ModelYashMenDaireMent>();
                ModelYashMenDaireMent modelMenteqe = new ModelYashMenDaireMent()
                { YashMenDaireMentID = 0, YashayishMenteqesiAdi = "" };
                yashayishMenteqesis.Insert(0, modelMenteqe);
            }
            return yashayishMenteqesis;
        }
        public List<ModelProspektKuce> prospektkucheload(short YashMenDaireMentID)
        {
            List<ModelProspektKuce> prospektuches;
            using (EntityDataModels db = new EntityDataModels())
            {
                prospektuches = (from pr in db.ProspektKuches
                                 join prkdm in db.ProspKucheDaireMents on pr.ProspektKucheID
                                 equals prkdm.ProspektKucheID
                                 where prkdm.YashMenDaireMentID == YashMenDaireMentID
                                 select new ModelProspektKuce()
                                 {
                                     ProspKucheDaireMentID = prkdm.ProspKucheDaireMentID,
                                     ProspektKucheAdi = pr.ProspektKucheAdi
                                 }
                     ).ToList<ModelProspektKuce>();
                ModelProspektKuce modelProspektKuce = new ModelProspektKuce() { ProspKucheDaireMentID = 0,
                    ProspektKucheAdi = "" };
                prospektuches.Insert(0, modelProspektKuce);
            }

            return prospektuches;
        }
        public List<Ev> evload(int ProspKucheDaireMentID)
        {
            List<Ev> evler;
            using (EntityDataModels db = new EntityDataModels())
            {
                evler = (from ev in db.Evs
                         where ev.ProspKucheDaireMentID == ProspKucheDaireMentID
                         orderby ev.EvAdi
                         select ev
                     ).ToList<Ev>();
                Ev modev = new Ev() { EvID = 0, EvAdi = "" };
                evler.Insert(0, modev);
            }

            return evler;
        }
        public List<ModelDaimi> daimiload(short MenteqeID)
        {
            List<ModelDaimi> daimis;
            using (EntityDataModels db = new EntityDataModels())
            {
                daimis = (from d in db.Daimis
                          join men in db.Menteqes on d.MenteqeID equals men.MenteqeID
                          where d.MenteqeID == MenteqeID
                          orderby d.SeciciID descending
                          select new ModelDaimi
                          {
                              SeciciID=d.SeciciID,
                              MenteqeKodu = men.MenteqeKodu,
                              Soyad= d.Soyad,
                              Ad= d.Ad,
                              AtaAdi= d.AtaAdi,
                              Dogumili= d.DogumIli,
                              Pinkod= d.Pinkod,
                              VesiqeNomresi= d.VesiqeNomresi,
                              Cins =(d.Cins==false?"Qadın": "Kişi")
                          }).ToList<ModelDaimi>();
            }
            return daimis;
        }
        public List<ModelQurum> qurumload()
        {
            List<ModelQurum> Qurums;
            using (EntityDataModels db = new EntityDataModels())
            {
                Qurums = (from qurum in db.Rayons orderby qurum.RayonAdi
                               select new ModelQurum()
                               { QurumID = qurum.RayonKodu, QurumAdi = qurum.RayonAdi+" RPŞ" }
                               ).ToList();
                //ModelQurum modelQurum = new ModelQurum() { QurumID = 0, QurumAdi = "" };
                //Qurums.Insert(0, modelQurum);
                ModelQurum modelQurum1 = new ModelQurum() { QurumID = 0, QurumAdi = "Asan Xidmət Mərkəzi" };
                Qurums.Insert(0, modelQurum1);
            }
            return Qurums;
        }
        public List<QeydiyyatSebeb> sebebload()
        {
            List<QeydiyyatSebeb> sebeb;
            using (EntityDataModels db = new EntityDataModels())
            {
                sebeb = (from qeysebeb in db.QeydiyyatSebebs
                         orderby qeysebeb.QeydiyyatSebebID
                         select qeysebeb).ToList();
            }
            return sebeb;
        }
        public List<SeciciStatu> statusload()
        {
            List<SeciciStatu> status;
            using (EntityDataModels db = new EntityDataModels())
            {
                status = (from stat in db.SeciciStatus
                         orderby stat.SeciciStatusID
                          select stat).ToList();
            }
            return status;
        }
        public List<VesiqeSeriya> seriyaload()
        {
            List<VesiqeSeriya> seriya;
            using (EntityDataModels db = new EntityDataModels())
            {
                seriya = (from ser in db.VesiqeSeriyas
                         orderby ser.VesiqeSeriyaID
                         select ser).ToList();
            }
            return seriya;
        }
        public List<ModelMertebe> binamertebeload()
        {
            List<ModelMertebe> mertebes = new List<ModelMertebe>();
            for (byte i = 1; i <= 50; i++)
            {
                mertebes.Add(new ModelMertebe() { ID = i, Mertebenomresi = i.ToString() });
            }
            ModelMertebe modelMertebe = new ModelMertebe() { ID = 0, Mertebenomresi="" };
            mertebes.Insert(0, modelMertebe);
            return mertebes;
        }
        public List<ModelDogumili> dogumiliload()
        {
            List<ModelDogumili> dogumili;
            using (EntityDataModels db = new EntityDataModels())
            {
                int NowYear = (from data in db.QeydiyyatSebebs select DateTime.Now.Year).FirstOrDefault();
                dogumili = new List<ModelDogumili>();
                for (int i = NowYear; i >= 1900; i--)
                {
                    dogumili.Add(new ModelDogumili() { ID = i, Dogumili = i });
                }
            }
            return dogumili;
        }
        public List<ModelDogumayi> dogumayiload()
        {
            List<ModelDogumayi> dogumayi;
            using (EntityDataModels db = new EntityDataModels())
            {
                dogumayi = new List<ModelDogumayi>();
                for (byte i = 0; i <= 12; i++)
                {
                    dogumayi.Add(new ModelDogumayi() { ID = i, Dogumayi = i });
                }
            }
            return dogumayi;
        }
        public List<ModelDogumgunu> dogumgunuload()
        {
            List<ModelDogumgunu> dogumgunu;
            using (EntityDataModels db = new EntityDataModels())
            {

                dogumgunu = new List<ModelDogumgunu>();
                for (byte i = 0; i <= 31; i++)
                {
                    dogumgunu.Add(new ModelDogumgunu() { ID = i, Dogumgunu = i });
                }
            }
            return dogumgunu;
        }
       
        
       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TamirhaneApp.Model;

namespace TamirhaneApp
{
    public partial class HomeForm : Form
    {
        TamiraneDBEntities tamiraneDBEntities = new TamiraneDBEntities();
        RandevuGuncellemeForm randevuGuncellemeForm = new RandevuGuncellemeForm();
        AracGuncellemeForm aracGuncellemeForm = new AracGuncellemeForm();
        MusteriGuncellemeForm musteriGuncellemeForm = new MusteriGuncellemeForm();
        public HomeForm()
        {
            InitializeComponent();
        }


        private void HomeForm_Load(object sender, EventArgs e)
        {


            //Datagrid lere ve ri tabanındaki dataların basıldığı kısım.
            //MusteriListesiYukle();


            if (comboBoxIslemler.Text == "" || comboBoxIslemler.Text == null)
            {
                comboBoxIslemler.SelectedText = "İşlem Seçiniz";
            }

            comboBoxIslemler.Items.Add("Müşteriler");
            comboBoxIslemler.Items.Add("Araçlar");
            comboBoxIslemler.Items.Add("Randevular");


        }

        private void comboBoxIslemler_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxIslemler.Text)
            {
                case "Araçlar":
                    AracListesiYukle();
                    break;

                case "Müşteriler":
                    MusteriListesiYukle();
                    break;

                case "Randevular":
                    RandevuListesiYukle();
                    break;
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {

            MusteriForm musteriForm = new MusteriForm();
            this.Close();
            musteriForm.Show();
        }

        private void btnNewCar_Click(object sender, EventArgs e)
        {
            AracForm aracForm = new AracForm();
            this.Close();
            aracForm.Show();

        }

        private void btnNewAppointment_Click(object sender, EventArgs e)
        {
            RandevuForm randevuForm = new RandevuForm();
            this.Close();
            randevuForm.Show();

        }

        public List<RandevuList> RandevuListesiYukle()
        {

            List<RandevuList> randevuLists = new List<RandevuList>();

            var randevuList = tamiraneDBEntities.randevu.ToList();
            foreach (randevu randevu in randevuList)
            {
                RandevuList randevu_ = new RandevuList();
                randevu_.Ad = tamiraneDBEntities.musteriler.Single(x => x.id == randevu.musteriId).ad;
                randevu_.Soyad = tamiraneDBEntities.musteriler.Single(x => x.id == randevu.musteriId).soyad;
                randevu_.Tarih = Convert.ToDateTime(randevu.tarih);
                randevu_.KayitNo = randevu.id;

                if (randevu.randevuya_geldimi == "E")
                {
                    randevu_.RandevuyaGeldiMi = "Evet";
                }
                else
                {
                    randevu_.RandevuyaGeldiMi = "Hayır";
                }

                if (randevu.kayit == "A")
                {
                    randevu_.Durum = "Aktif";
                }
                else
                {
                    randevu_.Durum = "Pasif";
                }
                randevuLists.Add(randevu_);
            }

            datagridList.DataSource = randevuLists;
            datagridList.ReadOnly = true;
            lblListName.Text = "Randevu Listesi";
            comboBoxIslemler.Text = "Randevular";
            return randevuLists;
        }

        public List<MusteriList> MusteriListesiYukle()
        {
            List<MusteriList> musteriLists = new List<MusteriList>();
            var musteriList = tamiraneDBEntities.musteriler.ToList();
            foreach (musteriler musteri in musteriList)
            {
                MusteriList musteri_ = new MusteriList();
                musteri_.KayitNo = musteri.id;
                musteri_.Ad = musteri.ad;
                musteri_.Soyad = musteri.soyad;
                musteri_.Telefon = musteri.telefon;
                musteri_.Mail = musteri.email;
                musteri_.Arac = tamiraneDBEntities.araclar.Single(x => x.id == musteri.aracid).plaka
                    + "-" + tamiraneDBEntities.araclar.Single(x => x.id == musteri.aracid).marka
                                 + "-" + tamiraneDBEntities.araclar.Single(x => x.id == musteri.aracid).model;
                musteriLists.Add(musteri_);

                if (musteri.Kayit == "A")
                {
                    musteri_.Durum = "Aktif";
                }
                else
                {
                    musteri_.Durum = "Pasif";
                }

            }

            datagridList.DataSource = musteriLists;
            datagridList.ReadOnly = true;
            lblListName.Text = "Müşteri Listesi";
            comboBoxIslemler.Text = "Müşteriler";
            return musteriLists;
        }

        public List<AracList> AracListesiYukle()
        {

            List<AracList> aracLists = new List<AracList>();
            var aracList = tamiraneDBEntities.araclar.ToList();
            foreach (araclar arac in aracList)
            {
                AracList arac_ = new AracList();
                arac_.Kayit = arac.id;
                arac_.Marka = arac.marka;
                arac_.Model = arac.model;
                arac_.model_yili = arac.model_yili;
                arac_.Plaka = arac.plaka;

                if (arac.Kayit == "A")
                {
                    arac_.Durum = "Aktif";
                }
                else
                {
                    arac_.Durum = "Pasif";
                }

                aracLists.Add(arac_);

            }

            datagridList.DataSource = aracLists;
            datagridList.ReadOnly = true;
            lblListName.Text = "Araç Listesi";
            comboBoxIslemler.Text = "Araçlar"; ;
            return aracLists;



        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AlertDeleteForm alertDeleteForm = new AlertDeleteForm();
            var rowList = datagridList.SelectedRows;
            if (rowList.Count != 0)
            {
                switch (comboBoxIslemler.Text)
                {
                    case "Araçlar":
                        for (int i = 0; i < rowList[0].Cells.Count; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    aracGuncellemeForm.txtAracKayitNo.Text = rowList[0].Cells[i].Value.ToString();
                                    break;

                                case 1:
                                    aracGuncellemeForm.txtAracGunPlaka.Text = rowList[0].Cells[i].Value.ToString();
                                    break;
                                case 2:
                                    aracGuncellemeForm.txtAracGunMarka.Text = rowList[0].Cells[i].Value.ToString();
                                    break;
                                case 3:
                                    aracGuncellemeForm.txtAracGunModel.Text = rowList[0].Cells[i].Value.ToString();
                                    break;
                                case 4:
                                    aracGuncellemeForm.txtAracGunModelyili.Text = rowList[0].Cells[i].Value.ToString();
                                    break;

                            }
                        }
                        aracGuncellemeForm.Show();
                        this.Close();
                        break;
                    case "Müşteriler":
                        musteriGuncellemeForm.Show();

                        for (int i = 0; i < rowList[0].Cells.Count; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    musteriGuncellemeForm.txtMusteriKayitNo.Text = rowList[0].Cells[i].Value.ToString();
                                    break;

                                case 1:
                                    musteriGuncellemeForm.txtMusteriGunAd.Text = rowList[0].Cells[i].Value.ToString();
                                    break;
                                case 2:
                                    musteriGuncellemeForm.txtMusteriGunSoyad.Text = rowList[0].Cells[i].Value.ToString();
                                    break;
                                case 3:
                                    musteriGuncellemeForm.txtMusteriGunTelefon.Text = rowList[0].Cells[i].Value.ToString();
                                    break;
                                case 4:
                                    musteriGuncellemeForm.txtMusteriGunMail.Text = rowList[0].Cells[i].Value.ToString();
                                    break;
                                case 5:
                                    musteriGuncellemeForm.cmbMusteriGunAraclar.DataSource = tamiraneDBEntities.araclar.ToList();
                                    musteriGuncellemeForm.cmbMusteriGunAraclar.DisplayMember = "arac_tam_adi";
                                    musteriGuncellemeForm.cmbMusteriGunAraclar.ValueMember = "id";
                                    break;

                            }
                        }

                        this.Close();
                        break;

                    case "Randevular":
                        randevuGuncellemeForm.Show();
                        for (int i = 0; i < rowList[0].Cells.Count; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    randevuGuncellemeForm.txtRandevuGunKayitNo.Text = rowList[0].Cells[i].Value.ToString();
                                    break;
                                case 1:
                                    randevuGuncellemeForm.txtRandevuGunAd.Text = rowList[0].Cells[i].Value.ToString();
                                    break;
                                case 2:
                                    randevuGuncellemeForm.txtRandevuGunSoyad.Text = rowList[0].Cells[i].Value.ToString();
                                    break;
                                case 3:
                                    randevuGuncellemeForm.txtRandevuGunTarih.Text = rowList[0].Cells[i].Value.ToString();
                                    break;
                                case 4:
                                    randevuGuncellemeForm.txtRandevuGunDurum.Text = rowList[0].Cells[i].Value.ToString();
                                    break;
                                case 5:
                                    randevuGuncellemeForm.txtRandevuGunRandevuGirisi.Text = rowList[0].Cells[i].Value.ToString();
                                    break;

                            }
                        }
                        this.Hide();
                        break;

                }

            }
        }


    }
}

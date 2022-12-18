using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamirhaneApp
{
    public partial class RandevuGuncellemeForm : Form
    {
        TamiraneDBEntities dBEntities = new TamiraneDBEntities();
        //SuccesForm succesForm = new SuccesForm();
        //HomeForm homeForm = new HomeForm();
        public RandevuGuncellemeForm()
        {
            InitializeComponent();
        }

        private void RandevuGuncellemeForm_Load(object sender, EventArgs e)
        {
            txtRandevuGunAd.ReadOnly = true;
            txtRandevuGunSoyad.ReadOnly = true;
            txtRandevuGunDurum.ReadOnly = true;
            txtRandevuGunRandevuGirisi.ReadOnly = true;
        }

        private void btnRandevuGuncelle_Click(object sender, EventArgs e)
        {
            var randevuId = Convert.ToInt32(txtRandevuGunKayitNo.Text);
            randevu editedItem = (from r in dBEntities.randevu  where r.id == randevuId  select r).SingleOrDefault();
            editedItem.tarih = Convert.ToDateTime(txtRandevuGunTarih.Text);
            dBEntities.SaveChanges();
            //this.Close();
            //succesForm.lblSuccesDurum.Text = "Randevu_Guncelleme";
            //succesForm.lblSucces.Text = "Randevu güncelleme başarılı.";
            //succesForm.Show();
            //homeForm.RandevuListesiYukle();
            //homeForm.Show();

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            SuccesForm succesForm = new SuccesForm();
            var randevuId = Convert.ToInt32(txtRandevuGunKayitNo.Text);
            randevu editedItem = (from r in dBEntities.randevu where r.id == randevuId select r).SingleOrDefault();
            editedItem.randevuya_geldimi = "E";
            dBEntities.SaveChanges();
            this.Close();
            succesForm.Show();
            succesForm.lblSucces.Text = "İşlem başarılı.";
            succesForm.lblSuccesDurum.Text = "Randevu_Kabul";
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            AlertDeleteForm alertDeleteForm = new AlertDeleteForm();
            alertDeleteForm.lblDeletedItemId.Text = txtRandevuGunKayitNo.Text;
            alertDeleteForm.lblSelectedOperation.Text = "Randevu";
            this.Close();
            alertDeleteForm.Show();
        }
    }
}


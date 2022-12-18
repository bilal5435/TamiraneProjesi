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
    public partial class MusteriGuncellemeForm : Form
    {
        TamiraneDBEntities dBEntities = new TamiraneDBEntities();
        public MusteriGuncellemeForm()
        {
            InitializeComponent();
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            AlertDeleteForm alertDeleteForm = new AlertDeleteForm();
            alertDeleteForm.lblDeletedItemId.Text = txtMusteriKayitNo.Text;
            alertDeleteForm.lblSelectedOperation.Text = "Müşteriler";
            this.Close();
            alertDeleteForm.Show();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            SuccesForm succesForm = new SuccesForm();
            var MusteriId = Convert.ToInt32(txtMusteriKayitNo.Text);
            musteriler editedItem = (from r in dBEntities.musteriler where r.id == MusteriId select r).SingleOrDefault();
            editedItem.ad = txtMusteriGunAd.Text;
            editedItem.soyad = txtMusteriGunSoyad.Text;
            editedItem.telefon = txtMusteriGunTelefon.Text;
            editedItem.email = (txtMusteriGunMail.Text);
            editedItem.aracid = Convert.ToInt32(cmbMusteriGunAraclar.SelectedValue);
            dBEntities.SaveChanges();

            this.Close();
            succesForm.lblSuccesDurum.Text = "Musteri_Guncelleme";
            succesForm.lblSucces.Text = "Müşteri güncelleme başarılı.";
            succesForm.Show();
        }
    }
}

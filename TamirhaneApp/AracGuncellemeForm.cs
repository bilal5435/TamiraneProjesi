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
    public partial class AracGuncellemeForm : Form
    {
        TamiraneDBEntities dBEntities = new TamiraneDBEntities();
        public AracGuncellemeForm()
        {
            InitializeComponent();
        }

        private void btnAracGuncelle_Click(object sender, EventArgs e)
        {
            SuccesForm succesForm = new SuccesForm();
            var aracId = Convert.ToInt32(txtAracKayitNo.Text);
            araclar editedItem = (from r in dBEntities.araclar where r.id == aracId select r).SingleOrDefault();
            editedItem.plaka = txtAracGunPlaka.Text;
            editedItem.marka = txtAracGunMarka.Text;
            editedItem.model = txtAracGunModel.Text;
            editedItem.model_yili = Convert.ToInt32(txtAracGunModelyili.Text);
            dBEntities.SaveChanges();

            this.Close();
            succesForm.lblSuccesDurum.Text = "Arac_Guncelleme";
            succesForm.lblSucces.Text = "Araç güncelleme başarılı.";
            succesForm.Show();
        }



        private void btnAracSil_Click(object sender, EventArgs e)
        {
            AlertDeleteForm alertDeleteForm = new AlertDeleteForm();
            alertDeleteForm.lblDeletedItemId.Text = txtAracKayitNo.Text;
            alertDeleteForm.lblSelectedOperation.Text = "Araç";
            this.Close();
            alertDeleteForm.Show();
        }
    }
}

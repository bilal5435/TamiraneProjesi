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
    public partial class AlertDeleteForm : Form
    {
        HomeForm homeForm = new HomeForm();

        //SuccesForm succesForm = new SuccesForm();
        public AlertDeleteForm()
        {
            InitializeComponent();
        }

        private void btnHayir_Click(object sender, EventArgs e)
        {
            this.Close();
            homeForm.RandevuListesiYukle();
            homeForm.Show();
        }

        private void btnEvet_Click(object sender, EventArgs e)
        {
            TamiraneDBEntities dBEntities = new TamiraneDBEntities();
            HomeForm homeForm = new HomeForm();
            AracGuncellemeForm aracGuncellemeForm = new AracGuncellemeForm();
            var selectedItemId = Convert.ToInt32(lblDeletedItemId.Text);
            switch (lblSelectedOperation.Text)
            {
                case "Randevu":
                    randevu randevuEditedItem = (from r in dBEntities.randevu where r.id == selectedItemId select r).SingleOrDefault();
                    randevuEditedItem.kayit = "P";
                    this.Close();
                    homeForm.RandevuListesiYukle();
                    break;
                case"Araç":
                    var aracEditedItem = (from r in dBEntities.araclar where r.id == selectedItemId select r).SingleOrDefault();
                    aracEditedItem.Kayit = "P";
                    this.Close();
                    homeForm.AracListesiYukle();
                    break;
                case "Müşteriler":
                    var musteriEditedItem = (from r in dBEntities.musteriler where r.id == selectedItemId select r).SingleOrDefault();
                    musteriEditedItem.Kayit = "P";
                    this.Close();
                    homeForm.MusteriListesiYukle();
                    break;

            }
            dBEntities.SaveChanges();
            homeForm.Show();
        }
    }
}

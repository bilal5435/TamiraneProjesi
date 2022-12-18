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
    public partial class AracForm : Form
    {
        SuccesForm succesForm = new SuccesForm();
        TamiraneDBEntities dBEntities = new TamiraneDBEntities();
        public AracForm()
        {
            InitializeComponent();
        }

        private void btnNewCar_Click(object sender, EventArgs e)
        {
            araclar arac = new araclar();
            arac.plaka = txtPlaka.Text;
            arac.marka = txtMarka.Text;
            arac.model = txtModel.Text;
            arac.model_yili = Convert.ToInt32(txtModelyili.Text);
            arac.arac_tam_adi = txtPlaka.Text + "-" + txtMarka.Text + "-" + txtModel.Text;
            
            dBEntities.araclar.Add(arac);
            dBEntities.SaveChanges();
            this.Close();
            succesForm.Show();
            succesForm.lblSucces.Text = "Yeni araç oluşturuldu.";
            succesForm.lblSuccesDurum.Text = "Arac_Ekleme";
        }
    }
}

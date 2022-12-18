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
    public partial class MusteriForm : Form
    {
        SuccesForm succesForm = new SuccesForm();
        HomeForm homeForm = new HomeForm();
        TamiraneDBEntities dBEntities = new TamiraneDBEntities();
        
        public MusteriForm()
        {
            InitializeComponent();
        }

        //Yeni müşteri ekleme event ı.
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            musteriler musteri = new musteriler();

            musteri.ad = txtAd.Text;
            musteri.soyad = txtSoyad.Text;
            musteri.telefon = txtTelefon.Text;
            musteri.email = txtMail.Text;
            musteri.aracid = Convert.ToInt32(cmbAraclar.SelectedValue);

            dBEntities.musteriler.Add(musteri);
            dBEntities.SaveChanges();

            this.Close();
            succesForm.Show();
            succesForm.lblSucces.Text = "Yeni müşteri oluşturuldu.";
            succesForm.lblSuccesDurum.Text = "Musteri_Ekleme";

        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            cmbAraclar.DataSource = dBEntities.araclar.ToList();
            cmbAraclar.DisplayMember = "arac_tam_adi";
            cmbAraclar.ValueMember =  "id";
        }

        private void cmbAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

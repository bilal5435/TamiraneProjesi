using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamirhaneApp
{
    public partial class RandevuForm : Form
    {
        HomeForm homeForm = new HomeForm();
        TamiraneDBEntities dBEntities = new TamiraneDBEntities();


        public RandevuForm()
        {
           
            InitializeComponent();
        }

        private void btnNewAppointment_Click(object sender, EventArgs e)
        {
            SuccesForm succesForm = new SuccesForm();
           
            randevu randevu = new randevu();
            randevu.musteriId = Convert.ToInt32(cmbMusteriId.SelectedValue);
            randevu.tarih = txtDateTime.Value;
            randevu.kayit = "A";
            randevu.randevuya_geldimi = "H";
            dBEntities.randevu.Add(randevu);
            dBEntities.SaveChanges();
            this.Close();
            succesForm.Show();
            succesForm.lblSucces.Text = "Randevu oluşturuldu.";
            succesForm.lblSuccesDurum.Text = "Randevu_Ekleme";


            //MailMessage mesaj = new MailMessage();

            //mesaj.From = new MailAddress("akbasbilal114@gmail.com");
            //mesaj.To.Add(dBEntities.musteriler.Single(x => x.id == randevu.musteriId).email.ToString());
            //mesaj.Subject = "Randevu Bildirimi";
            //mesaj.Body = "Merhaba ," + dBEntities.musteriler.Single(x => x.id == randevu.musteriId).ad+
            //             " bey randevunuz başarıyla oluşturulmuştur randevu tarihiniz : " + txtDateTime;


            //SmtpClient a = new SmtpClient();
            //a.Credentials = new System.Net.NetworkCredential("akbasbilal114@gmail.com", "Bilal.3543");
            //a.Port = 25;
            //a.Host = "akbasbilal114@gmail.com";
            //a.EnableSsl = true;
            //object userState = mesaj;

            //try
            //{
            //    a.SendAsync(mesaj, (object)mesaj);
            //    MessageBox.Show("Mail Gönderilmiştir");
            //}

            //catch (SmtpException ex)
            //{

            //    System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            //}


        }

        private void RandevuForm_Load(object sender, EventArgs e)
        {
            cmbMusteriId.DataSource = dBEntities.musteriler.ToList();
            cmbMusteriId.DisplayMember = "ad";
            cmbMusteriId.ValueMember = "id";
        }
    }
}

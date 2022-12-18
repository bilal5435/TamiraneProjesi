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
    public partial class SuccesForm : Form
    {
        RandevuForm randevuForm = new RandevuForm();
        HomeForm homeForm = new HomeForm();
        public SuccesForm()
        {
            InitializeComponent();
        }

        private void btnSuccesFormClose_Click(object sender, EventArgs e)
        {
            if(lblSuccesDurum.Text == "Musteri_Ekleme" || lblSuccesDurum.Text == "Musteri_Guncelleme")
            {
                homeForm.MusteriListesiYukle();
            }
            else if(lblSuccesDurum.Text == "Randevu_Ekleme" || lblSuccesDurum.Text == "Randevu_Guncelleme" || lblSuccesDurum.Text == "Randevu_Kabul")
            {
                homeForm.RandevuListesiYukle();
            }
            else if (lblSuccesDurum.Text == "Arac_Ekleme" || lblSuccesDurum.Text == "Arac_Guncelleme")
            {
                homeForm.AracListesiYukle();
            }
      
            this.Close();
            homeForm.Show();
        
        }

        
    }
}

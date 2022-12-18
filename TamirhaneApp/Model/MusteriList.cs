using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamirhaneApp.Model
{
    public class MusteriList
    {
        [DisplayName("Kayıt No")]
        public int KayitNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        [DisplayName("Mail Adresi")]
        public string Mail { get; set; }

        [DisplayName("Araç Adı")]
        public string Arac { get; set; }

        public string Durum { get; set; }
    }
}

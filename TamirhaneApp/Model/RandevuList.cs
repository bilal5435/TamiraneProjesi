using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamirhaneApp.Model
{
    public class RandevuList
    {
        [DisplayName("Kayıt No")]
        public int KayitNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime Tarih { get; set; }
        public string Durum { get; set; }
        [DisplayName("Randevuya Geldi mi?")]
        public string RandevuyaGeldiMi { get; set; }
    }
}

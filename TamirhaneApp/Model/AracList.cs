using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamirhaneApp.Model
{
    public class AracList
    {
        [DisplayName("Kayıt No")]
        public int Kayit { get; set; }
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        [DisplayName("Model Yılı")]
        public Nullable<int> model_yili { get; set; }

        public string Durum { get; set; }
    }
}

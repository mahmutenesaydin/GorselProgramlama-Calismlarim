using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7Çalışma.Entity
{
    public class Urunler:EntityBase
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int TedarikciID { get; set; }
        public int KategoriID { get; set; }
        public string BirimdekiMiktar { get; set; }
        public decimal BirimFiyati { get; set; }
        public short HedefStokDuzeyi { get; set; }
        public short YeniSatis { get; set; }
        public short EnAzYenidenSatisMikatari { get; set; }
        public bool Sonlandi { get; set; }

        public override string PrimaryColumn
        {
            get
            {
                return "UrunID";
            }
        }
    }
}

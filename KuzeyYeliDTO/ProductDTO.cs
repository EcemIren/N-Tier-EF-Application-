using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeliDTO
{
    public class ProductDTO
    {
        public int UrunID { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string UrunAdi { get; set; }
        public Nullable<int> TedarikciID { get; set; }
        public Nullable<int> KategoriID { get; set; }
        public string BirimdekiMiktar { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public Nullable<short> Stok { get; set; }
        public Nullable<short> YeniSatis { get; set; }
        public Nullable<short> EnAzYenidenSatisMikatari { get; set; }
        public bool Sonlandi { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class SiparisDetay
    {
        public int SiparisDetayID { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public Nullable<int> UrunID { get; set; }
        public Nullable<int> MusteriID { get; set; }
        public Nullable<int> SiparisID { get; set; }
    
        public virtual Musteri Musteri { get; set; }
        public virtual Sipari Sipari { get; set; }
        public virtual Urunler Urunler { get; set; }
    }
}

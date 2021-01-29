﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7Çalışma.Entity
{
    public class Tedarikciler:EntityBase
    {
        public int TedarikciID { get; set; }
        public string SirketAdi { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriUnvani { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Bolge { get; set; }
        public string PostaKodu { get; set; }
        public string Ulke { get; set; }
        public string Telefon { get; set; }
        public string Faks { get; set; }
        public string WebSayfası { get; set; }

        public override string PrimaryColumn
        {
            get
            {
                return "TedarikciID";
            }
        }
    }
}

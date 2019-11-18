using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kutuphane
{
    class Talep
    {
        public Ogrenci okur { get; set; }
        public Kitap kitap { get; set; }
        public DateTime alisTarihi { get; set; }
        public DateTime teslimTarihi { get; set; }
        public DateTime teslimEdilenTarih { get; set; }
    }
}

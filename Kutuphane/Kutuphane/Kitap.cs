using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kutuphane
{
    class Kitap
    {
        public string Barkod { get; set; }
        public string Ad { get; set; }
        public int SayfaSayisi { get; set; }
        public string Dil { get; set; }
        public List<Kategori> Kategoriler { get; set; }
        public Yazar Yazari { get; set; } 
    }
}

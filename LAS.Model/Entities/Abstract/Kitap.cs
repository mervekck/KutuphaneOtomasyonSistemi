using LAS.Model.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LAS.Model.Entities.Abstract
{
    public abstract class Kitap : BaseEntity
    {
        public int ISBN { get; set; }
        public string Baslik { get; set; }
        public Yazar Yazar { get; set; }
        public int YazarID { get; set; }
        public DateTime YayinYili { get; set; }
        public Durum Durum { get; set; }
        public abstract void KitapBilgisi();
    }
}

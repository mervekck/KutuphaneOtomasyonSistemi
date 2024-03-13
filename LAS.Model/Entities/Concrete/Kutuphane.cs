using LAS.Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAS.Model.Entities.Concrete
{
    public class Kutuphane : BaseEntity
    {
        public List<Abstract.Kitap> Kitaplar { get; set; }
        public List<Uye> Uyeler { get; set; }
        public Kutuphane() 
        {
            Kitaplar = new List<Abstract.Kitap>();
            Uyeler = new List<Uye>();
        }
    }
}

using LAS.Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAS.Model.Entities.Contract
{
    public interface IUye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int UyeNumarasi { get; set; }
        public List<Kitap> OduncAlinanKitaplar { get; set; }
        void KitapOduncAlabilirMi(Kitap kitap);
        void KitapİadeEdilebilir(Kitap kitap);
    }
}

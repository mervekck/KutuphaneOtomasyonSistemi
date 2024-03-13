using LAS.Model.Entities.Abstract;
using LAS.Model.Entities.Contract;
using LAS.Model.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAS.Model.Entities.Concrete
{
    public class Uye : BaseEntity, IUye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int UyeNumarasi { get; set; }
        public List<Abstract.Kitap> OduncAlinanKitaplar { get; set; }

        public Uye(string ad, string soyad, int uyeNumarasi)
        {
            Ad = ad;
            Soyad = soyad;
            UyeNumarasi = uyeNumarasi;
            OduncAlinanKitaplar = new List<Abstract.Kitap>();
        }
        public void KitapOduncAlabilirMi(Abstract.Kitap kitap) 
        { 
            if (kitap.Durum == Durum.Mevcut)
            {
                kitap.Durum = Durum.OduncVerildi;
                OduncAlinanKitaplar.Add(kitap);
                Console.WriteLine($"{kitap.Baslik} kitabı ödünç alındı.");
            }
            else
            {
                Console.WriteLine($"{kitap.Baslik} kitabı mevcut olmadığı için mevcut olduğu zaman deneyiniz.");
            }
        }
        public void KitapIadeEdilebilir(Abstract.Kitap kitap)
        {
            if (OduncAlinanKitaplar.Contains(kitap))
            {
                kitap.Durum = Durum.Mevcut;
                OduncAlinanKitaplar.Remove(kitap);
                Console.WriteLine($"{kitap.Baslik} kitabı iade işlemi gerçekleşti.");
            }
            else
            {
                Console.WriteLine($"{kitap.Baslik} kitabı ödünç alınmamıştır yeniden kontrol ediniz.");
            }

        }

    }
}

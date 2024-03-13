using LAS.Model.Entities.Abstract;
using LAS.Model.Entities.Enums;
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
        public void KutuphaneMevcutDurum()
        {
            Console.WriteLine("Kütüphane");
            Console.WriteLine($"Kitap Sayısı: {Kitaplar.Count}");
            Console.WriteLine($"Üye Sayısı: {Uyeler.Count}");
            Console.WriteLine("Kitap Listesi:");
            foreach (var kitap in Kitaplar)
            {
                Console.WriteLine($"Kitap Başlık: {kitap.Baslik}, Yazar: {kitap.Yazar.Adi}, Durum: {kitap.Durum}");
            }
            Console.WriteLine("Üye Listesi:");
            foreach (var uye in Uyeler)
            {
                Console.WriteLine($"Üye Adı: {uye.Ad}, Üye Soyadı: {uye.Soyad}, Üye Numarası: {uye.UyeNumarasi}");
            }
        }
        public void KitapOduncVer(Abstract.Kitap kitap,Uye uye)
        {
            if (Kitaplar.Contains(kitap) && kitap.Durum == Durum.Mevcut) //Kitap kitaplarda varsa ve kitap durumu mevcut ise ödünç verebilirsin
            {
                uye.KitapOduncAlabilirMi(kitap);
            }
            else
            {
                Console.WriteLine($"{kitap.Baslik} kitabı ödünç verilemez.");
            }
        }
        public void KitapIadeEt(Abstract.Kitap kitap, Uye uye)
        {
            if (uye.OduncAlinanKitaplar.Contains(kitap))
            {
                uye.KitapIadeEdilebilirMi(kitap);
            }
            else
            {
                Console.WriteLine($"{kitap.Baslik} kitabı ödünç alınmamıştır yeniden kontrol ediniz.");
            }
        }
    }
}
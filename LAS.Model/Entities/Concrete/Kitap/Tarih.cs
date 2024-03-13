using LAS.Model.Entities.Abstract;
using LAS.Model.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAS.Model.Entities.Concrete.Kitap
{
    public class Tarih : Abstract.Kitap
    {
        public override void KitapBilgisi()
        {
            Console.WriteLine($"Tarih Kitabı \n Başlık:{Baslik} Yazar:{Yazar.Adi} Yayın Yılı:{YayinYili}");
        }
    }
}

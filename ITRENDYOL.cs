using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TREDYOL_WEB_PROJESİ
{
    public interface ITRENDYOL
    {
        void Ekleme(Ürünler eklenecekürün);
        List<Ürünler> Listeleme();
        void ÜrünleriSil(int id);
        void Güncelle(Ürünler güncelenecekürün);
        
    }
}

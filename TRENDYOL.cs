using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TREDYOL_WEB_PROJESİ
{
    public class TRENDYOL : ITRENDYOL
    {
        List<Ürünler> Ürünlers = new List<Ürünler>();
        public void Ekleme(Ürünler eklenecekürün)
        {
            Ürünlers.Add(eklenecekürün);
        }

        public void Güncelle(Ürünler güncelenecekürün)
        {
            int index = Ürünlers.FindIndex(x => x.ID == güncelenecekürün.ID);
            if (index != -1)
            {
                Ürünlers[index] = güncelenecekürün;
            }
        }

        public List<Ürünler> Listeleme()
        {
            return Ürünlers;
        }

        public void ÜrünleriSil(int id)
        {
            Ürünler silinecekürün = Ürünlers.FirstOrDefault(x => x.ID== id);
            if(null != silinecekürün )
            {
                Ürünlers.Remove(silinecekürün);
            }
        }
    }
}

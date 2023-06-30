using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    internal class SepetManager
    {
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi: " + urun.Adi);
        }

        public void Ekle2(string urunAdi, double fiyat, string aciklama, int StokAdedi ) 
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi: " + urunAdi);

        }
    
    }
}

// See https://aka.ms/new-console-template for more information
using Metodlar;

string urunAdi = "Elma";
double fiyati  =15;
string aciklama  = "Amasya Elması";

string[] meyveler = new string[] {"Elma", "Karpuz" };

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elması";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır Karpuzu";

Urun[] urunler = new Urun[] {urun1, urun2 };

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("------------------------");
}

Console.WriteLine("-------------------METODLAR------------------");

SepetManager sepetManager = new SepetManager();

sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Armut", 12, "Yeşil armut", 10);
sepetManager.Ekle2("Elma", 12, "Yeşil elma", 9);
sepetManager.Ekle2("Karpuz", 12, "Diyarbakır karpuzu", 8);


// See https://aka.ms/new-console-template for more information

string adi = "Engin";
int yas = 36;

kurs kurs1 = new kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Engin Demiroğ";
kurs1.İzlenmeOrani = "68";

kurs kurs2 = new kurs();
kurs2.KursAdi = "Python";
kurs2.Egitmen = "Ahmet Tümkaya";
kurs2.İzlenmeOrani = "70";

kurs kurs3 = new kurs();
kurs3.KursAdi = "java";
kurs3.Egitmen = "Mete Çeliktürk";
kurs3.İzlenmeOrani = "77";

//Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3 };

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);    
}

class kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public string İzlenmeOrani { get; set; }
}

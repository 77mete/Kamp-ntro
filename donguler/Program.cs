// See https://aka.ms/new-console-template for more information
string kurs1 = "Yazılım Geliştirici Yerleştirme Kampı";
string kurs2 = "Proglamlamaya Başlangıç İçin Temel Kurs";
string kurs3 = "java";
string kurs4 = "python";
string kurs5 = "C#";

Console.WriteLine(kurs1);
Console.WriteLine(kurs2);   
Console.WriteLine(kurs3);   
Console.WriteLine(kurs4);  
Console.WriteLine(kurs5); 

//array - dizi

string[] kurslar = new string[] { "Yazılım Geliştirici Yerleştirme Kampı", 
    "Proglamlamaya Başlangıç İçin Temel Kurs", 
    "java", "python", "C#" };


for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("for bitti");

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs); 
}

Console.WriteLine("Sayfa sonu - footer");
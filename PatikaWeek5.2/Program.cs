// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

Console.WriteLine("Merhabalar hoşgeldiniz içmek istediğiniz kahveleri giriniz kahve seçiminiz bittiğinde teşekkürler demeniz yeterli");
List<string> coffe = new List<string>();
int i = 1;//kahve istekleri için i tanımlanır 
while (true)
{
    Console.WriteLine(i+". kahvenim");
   
    string control=Console.ReadLine();
    if (control.ToLower() == "teşekkürler")//döngüden çıkmak istediğinde çıkmasını sağlar
    {

        Console.WriteLine("Siparişleriniz hazırlanıyor ");
        break;
    }
    coffe.Add(control);//listeye yeni ekleme yapmak 
    i++;//her döngü sonunda artrılır 
}
foreach (string item in coffe)//kahveleri ekrena yazdırır
{
    Console.WriteLine(item);
}

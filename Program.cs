internal class Program
{
    private static void Main(string[] args)
    {
        // Tanımlama

        string [] renkler = new string [5];
        string [] hayvanlar = {"kedi","köpek","kuş","aslan","maymun"};
        int [] dizi;
        dizi = new int [5];

        // Değer atama ve erişim 

        renkler [0] = "mavi";
        dizi [3] = 10;

        System.Console.WriteLine(hayvanlar[2] + " " + dizi [3]+" "+renkler[0]);

        //Döngüler dizi kullanımı 
        //Klavyeden girilen n sayının ortalaması

        System.Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
        int diziuzunlugu = int.Parse(Console.ReadLine());
        int [] sayidizisi = new int [diziuzunlugu];

        for (int i = 0; i < diziuzunlugu; i++)
        {
            System.Console.Write("Lütfen {0}. sayıyı giriniz. ", i+1);
            sayidizisi [i] = int.Parse(Console.ReadLine());            
        }

        int toplam = 0;
        foreach (var sayi in sayidizisi)
        
           toplam += sayi;
            System.Console.WriteLine("Ortalama =" + toplam/diziuzunlugu);
        















    }
}
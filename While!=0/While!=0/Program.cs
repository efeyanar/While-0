internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Sistemi Kapatmak İçin '0' Giriniz.");
        int i, toplam, sayi;
        i = 1;

        Console.Write("1. Sayıyı Giriniz  = ");
        sayi = (int)Convert.ToInt64(Console.ReadLine());
        toplam = sayi;

        while (sayi != 0)
        {
            i++;
            Console.Write(i + ". Sayıyı Giriniz = ");
            sayi = (int)Convert.ToInt64(Console.ReadLine());
            toplam = toplam + sayi;
        }

        Console.WriteLine("");
        Console.WriteLine(i + " Sayı Girişi Yaptınız,");
        Console.WriteLine("Girdiğiniz Sayıların Toplamı = " + toplam);

        Console.ReadKey();
    }
}
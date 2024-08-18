using System;
class program
{
    static void Main()
    {

        EnSevdiğinŞarkıSözü();
        int kalan = RastgeleSayı();
        Console.WriteLine("Rastgele sayının 2'ye bölümünden kalan: " + kalan);
        int çarpım = SayılarınÇarpımı(4, 5);
        Console.WriteLine("Sayıların çarpımı: " + çarpım);
        HoşgeldinMesajı("Bilge Su", "Kuzucular");
    }

    static void EnSevdiğinŞarkıSözü()
    {
        Console.WriteLine("Lady in red");
    }

    static int RastgeleSayı()
    {
        Random rnd= new Random();
        int number = rnd.Next(1, 100);
        return number % 2;
    }
    static int SayılarınÇarpımı(int x, int y)
    {
        return x * y;
    }

    static void HoşgeldinMesajı(string adı, string soyadı)
    {
        Console.WriteLine("Hoşgeldiniz " + adı + " " + soyadı + " ");
    }



}


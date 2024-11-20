using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan ders notlarını al
        Console.Write("1. ders notunu girin: ");
        double ders1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("2. ders notunu girin: ");
        double ders2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("3. ders notunu girin: ");
        double ders3 = Convert.ToDouble(Console.ReadLine());

        // Ortalamayı hesapla
        double ortalama = (ders1 + ders2 + ders3) / 3;

        // Sonucu kontrol et
        if (ortalama > 50)
        {
            Console.WriteLine("Geçtiniz! Ortalama: " + ortalama);
        }
        else
        {
            Console.WriteLine("Kaldınız! Ortalama: " + ortalama);
        }
    }
}

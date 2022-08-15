using System;

namespace metot_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string girilenSayi = "1905";
            int sayimiz;
            bool sonuc = int.TryParse(girilenSayi, out sayimiz);
            if (sonuc)
            {
                Console.WriteLine("Dönüşüm başarılı.");
                Console.WriteLine("Sayı: {0}", sayimiz);
            }
            else
            {
                Console.WriteLine("Dönüşüm başarısız.");
            }
        }
    }
}

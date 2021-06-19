using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a=int.Parse("-20000000000000");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Boş Değer Girdiniz");
                Console.WriteLine(ex);
            }
             catch (FormatException ex)
            {
                Console.WriteLine("Veri Tipi Uygun Değil");
                Console.WriteLine(ex);
            }
             catch (OverflowException ex)
            {
                Console.WriteLine("Çok büyük yada çok küçük bir değer girdiniz");
                Console.WriteLine(ex);
            }

            finally
            {
                Console.WriteLine("İşlem Başarıyla Tamamlandı");
            }
        }
    }
}

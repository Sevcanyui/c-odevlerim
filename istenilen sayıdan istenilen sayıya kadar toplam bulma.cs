namespace _20.NSayısınaKadarToplam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayi giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for (int i = 1; i < n; i++)
            {
                toplam += i;
            }
            Console.WriteLine("1'den " + n + " sayısına kadar olan sayıların toplamı = " + toplam);

            Console.ReadLine();
        }
    }
}

//Sevcan kaya 

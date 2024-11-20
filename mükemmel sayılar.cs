Console.WriteLine("Sayı giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());
int toplam = 0;
for (int i = 1; i < sayi; i++)
{
    if (sayi % i == 0)
    {
        toplam = toplam + i;
    }
}
if (toplam == sayi)
{
    Console.WriteLine(sayi + "sayı Mükemmel Sayıdır");
}
else
{
    Console.WriteLine(sayi + "sayı Mükemmel Sayı Değildir");
}
Console.ReadLine();

//Sevcan kaya
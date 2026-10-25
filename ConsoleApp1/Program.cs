


Random rd = new Random();

int enkucuksayi = int.MaxValue;

int kucuksira = 0;

int enbuyuksayi = int.MinValue;

int buyuksira = 0;

int ciftsayiadedi = 0;

int teksayiadedi = 0;

Console.WriteLine("bir sayı girin");
string girilensayi = Console.ReadLine();
int girilmissayi = int.Parse(girilensayi);

Console.WriteLine("rastgele 10 sayı");
Console.WriteLine("");

for (int i = 0; i < 10; i++)
{
    int rand_num = rd.Next(0, 100);
    int sira = i + 1;

    Console.WriteLine(rand_num);

    if (rand_num < enkucuksayi)
    {
        enkucuksayi = rand_num;
        kucuksira = sira;
    }

    if (rand_num > enbuyuksayi)
    {
        enbuyuksayi = rand_num;
        buyuksira = sira;
    }



    if (rand_num % 2 == 0)
    {
        ciftsayiadedi++;
    }

    else
    {
        teksayiadedi++;
    }

    if (rand_num > girilmissayi)
    {
        Console.WriteLine((i + 1) + ". sayı: " + rand_num + " -> girilen sayıdan büyük");
    }
    else if (rand_num < girilmissayi)
    {
        Console.WriteLine((i + 1) + ". sayı: " + rand_num + " -> girilen sayıdan küçük");
    }
    else
    {
        Console.WriteLine((i + 1) + ". sayı: " + rand_num + " -> girilen sayıya eşit");
    }







}
Console.WriteLine("");

Console.WriteLine("en küçük sayı: " + enkucuksayi + ", sırası: " + kucuksira);
Console.WriteLine("en büyük sayı: " + enbuyuksayi + ", sırası: " + buyuksira);
Console.WriteLine("");

Console.WriteLine("çift sayı adedi : " + ciftsayiadedi);
Console.WriteLine("tek sayı adedi : " + teksayiadedi);







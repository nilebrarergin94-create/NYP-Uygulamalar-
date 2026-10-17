
using System;

bool oduncte = false;

if (oduncte)
{
    Console.WriteLine("Ekipman ödünçte.");
}
else
{
    int gun;
    bool gecerliMi = false;

    do
    {
        Console.Write("Kaç günlüğüne ödünç almak istiyorsunuz? ");
        string giris = Console.ReadLine();

        if (int.TryParse(giris, out gun) && gun >= 1 && gun <= 7)
        {
            gecerliMi = true;
            Console.WriteLine($"Talep uygun! Ödünç süresi: {gun} gün.");
        }
        else
        {
            Console.WriteLine("1 ile 7 arasında bir sayı girin.");
        }

    } while (!gecerliMi);
}

Console.WriteLine("Program sona erdi.");
Console.ReadKey();


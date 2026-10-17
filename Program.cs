
using System;
using System.Collections.Generic;

List<string> numaralar = new List<string>
{
    "LAB1",
    "LAB2",
    "LAB3"
};

Console.Write("Aramak istediğiniz numarayı girin: ");
string? aranan = Console.ReadLine();

bool bulundu = NumaraVarMi(numaralar, aranan ?? "");

Console.WriteLine(bulundu ? "Numara bulundu." : "Numara bulunamadı.");

static bool NumaraVarMi(List<string> liste, string aranan)
{
    foreach (string numara in liste)
    {
        if (numara == aranan)
        {
            return true;
        }
    }

    return false;
}

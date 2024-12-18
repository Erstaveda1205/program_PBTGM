using System;
using System.Collections.Generic; // Namespace untuk Dictionary

class Program
{
    static void Main()
    {
        // 1. Membuat Dictionary untuk menyimpan nama negara dan ibukotanya
        Dictionary<string, string> negaraDanIbukota = new Dictionary<string, string>();
        // 2. Menambahkan lima negara beserta ibukotanya
        negaraDanIbukota.Add("Indonesia", "Jakarta");
        negaraDanIbukota.Add("Jepang", "Tokyo");
        negaraDanIbukota.Add("Amerika Serikat", "Washington D.C.");
        negaraDanIbukota.Add("Australia", "Canberra");
        negaraDanIbukota.Add("Jerman", "Berlin");
        // 3. Menampilkan ibukota dari negara "Indonesia"
        string ibukotaIndonesia = negaraDanIbukota["Indonesia"];
        Console.WriteLine($"Ibukota Indonesia adalah: {ibukotaIndonesia}");
        // Menunggu input sebelum menutup program
        Console.ReadKey();
    }
}

using System;

class Program
{
    static void Main()
    {
        // Membuat array yang menyimpan nama-nama hari dalam seminggu
        string[] hari = { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu" };

        // Menampilkan nama hari ketiga
        Console.WriteLine("Hari ketiga dalam seminggu adalah: " + hari[2]);

        // Menunggu input sebelum menutup program
        Console.ReadKey();
    }
}

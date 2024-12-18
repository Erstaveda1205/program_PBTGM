using System;

class Program
{
    static void Main()
    {
        // 1. Meminta input dari pengguna untuk panjang sisi kubus
        Console.Write("Masukkan panjang sisi kubus (dalam satuan cm): ");
        int sisi = Convert.ToInt32(Console.ReadLine());

        // 2. Menghitung volume kubus (volume = sisi^3)
        double volume = Math.Pow(sisi, 3);

        // 3. Menampilkan hasil perhitungan volume kubus
        Console.WriteLine($"Volume kubus dengan sisi {sisi} cm adalah {volume} cm³");

        // Menunggu input sebelum menutup program
        Console.ReadKey();
    }
}

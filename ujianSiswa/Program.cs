using System;
using System.Collections.Generic; // Namespace untuk List
using System.Linq; // Namespace untuk fungsi-fungsi seperti Average

class Program
{
    static void Main()
    {
        // Membuat List untuk menyimpan nilai ujian siswa
        List<int> nilaiUjian = new List<int>();
        bool selesai = false;
        while (!selesai)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Tambah nilai");
            Console.WriteLine("2. Hapus nilai");
            Console.WriteLine("3. Hitung rata-rata nilai");
            Console.WriteLine("4. Keluar");
            Console.Write("Pilih opsi: ");
            int opsi = Convert.ToInt32(Console.ReadLine());
            switch (opsi)
            {
                case 1:
                    // Tambah nilai baru
                    Console.Write("Masukkan nilai yang ingin ditambahkan: ");
                    int nilaiBaru = Convert.ToInt32(Console.ReadLine());
                    nilaiUjian.Add(nilaiBaru);
                    Console.WriteLine("Nilai berhasil ditambahkan.");
                    break;
                case 2:
                    // Hapus nilai tertentu
                    Console.Write("Masukkan nilai yang ingin dihapus: ");
                    int nilaiHapus = Convert.ToInt32(Console.ReadLine());
                    if (nilaiUjian.Contains(nilaiHapus))
                    {
                        nilaiUjian.Remove(nilaiHapus);
                        Console.WriteLine("Nilai berhasil dihapus.");
                    }
                    else
                    {
                        Console.WriteLine("Nilai tidak ditemukan.");
                    }
                    break;
                case 3:
                    // Hitung rata-rata nilai
                    if (nilaiUjian.Count > 0)
                    {
                        double rataRata = nilaiUjian.Average();
                        Console.WriteLine($"Rata-rata nilai: {rataRata}");
                    }
                    else
                    {
                        Console.WriteLine("Tidak ada nilai yang tersedia.");
                    }
                    break;
                case 4:
                    // Keluar dari program
                    selesai = true;
                    Console.WriteLine("Keluar dari program.");
                    break;
                default:
                    Console.WriteLine("Opsi tidak valid, coba lagi.");
                    break;
            }
        }
        // Menunggu input sebelum menutup program
        Console.ReadKey();
    }
}

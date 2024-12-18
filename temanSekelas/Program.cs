using System;
using System.Collections.Generic; // Namespace untuk List

class Program
{
    static void Main()
    {
        // 1. Membuat List untuk menyimpan nama-nama teman sekelas
        List<string> temanKelas = new List<string> { "Andi", "Budi", "Cici", "Dodi" };
        // 2. Menambahkan nama "Bara" ke dalam list
        temanKelas.Add("Bara");
        // 3. Menampilkan semua nama yang ada dalam list
        Console.WriteLine("Nama-nama teman sekelas:");
        foreach (string nama in temanKelas)
        {
            Console.WriteLine(nama);
        }
        // Menunggu input sebelum menutup program
        Console.ReadKey();
    }
}

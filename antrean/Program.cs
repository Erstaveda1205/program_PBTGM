using System;
using System.Collections.Generic; // Namespace untuk Stack

class Program
{
    static void Main()
    {
        // 1. Membuat Stack untuk menyimpan nomor antrian
        Stack<int> nomorAntrian = new Stack<int>();
        // 2. Menambahkan tiga nomor antrian ke dalam stack
        nomorAntrian.Push(101);
        nomorAntrian.Push(102);
        nomorAntrian.Push(103);
        // 3. Menampilkan nomor antrian terakhir yang masuk
        int terakhirMasuk = nomorAntrian.Peek();
        Console.WriteLine($"Nomor antrian terakhir yang masuk: {terakhirMasuk}");
        // Menunggu input sebelum menutup program
        Console.ReadKey();
    }
}

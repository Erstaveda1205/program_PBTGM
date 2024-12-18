using System;
using System.Collections.Generic; // Namespace untuk Queue

class Program
{
    static void Main()
    {
        // 1. Membuat Queue untuk menyimpan nama-nama dalam antrian bank
        Queue<string> antrianBank = new Queue<string>();
        // 2. Menambahkan tiga nama ke dalam antrian
        antrianBank.Enqueue("Ali");
        antrianBank.Enqueue("Budi");
        antrianBank.Enqueue("Citra");
        // 3. Menampilkan nama pertama yang akan dilayani
        string pertamaDilayani = antrianBank.Peek();
        Console.WriteLine($"Nama pertama yang akan dilayani: {pertamaDilayani}");
        // Menunggu input sebelum menutup program
        Console.ReadKey();
    }
}

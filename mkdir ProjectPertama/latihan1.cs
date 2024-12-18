using System;
class Biodata 
{
    static void Main(string[] args)
    {
        // // Perbedaan penggunaan WriteLine() dan Write
        // Console.WriteLine("BIODATA XI RPL");
        // Console.WriteLine("========================================");
        // Console.Write("Nama: ");
        // Console.WriteLine("ERSTA"); // Menggunakan WriteLine agar pindah ke baris baru
        // Console.Write("Kelas: ");
        // Console.WriteLine("XI RPL C"); // Menggunakan WriteLine agar pindah ke baris baru
        // // fungsi input Read(), ready(), dan ReaLine()
        // Console.Write("Tuliskan Alamat Kamu: ");
        // string alamat = Console.ReadLine();
        // Console.WriteLine("Alamat rumah kamu di {0}", alamat);
        // Console.WriteLine("Tuliskan makanan favorit kamu: ");
        // string makanan = Console.ReadLine();
        // Console.WriteLine($"Makanan favorit kamu {makanan}");
        // Console.Write("Tuliskan warna favorit kamu: ");
        // string warna = Console.ReadLine();
        // Console.WriteLine($"Warna favorit kamu "+warna+"");
        string nama,kelas,alamat;
        int umur;

        Console.WriteLine("DAFTAR SISWA RPL 2024/2025");
        Console.WriteLine("========================================");
        Console.Write("Masukan Nama: ");
        nama = Console.ReadLine();
        Console.Write("Masukan kelas: ");
        kelas = Console.ReadLine();
        Console.Write("Masukan alamat: ");
        alamat = Console.ReadLine();
        Console.Write("Masukan umur: ");
        umur = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("MATUR NUWUN!");
        Console.WriteLine("Data Berikut: ");
        Console.WriteLine($"Nama: {nama}");
        Console.WriteLine($"Kelas: {kelas}");
        Console.WriteLine($"Alamat: {alamat}");
        Console.WriteLine($"Umur: {umur}tahun");
        Console.WriteLine("TELAH TERSIMPAN");
    }
}

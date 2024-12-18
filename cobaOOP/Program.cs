using System;
using System.Collections.Generic;
using System.IO.Compression;

namespace cobaOOP
{
    class Buku {
        public string? Judul {get; set; } 
        public string? Pengarang {get; set; } 
        public int TahunTerbit {get; set; } 
        
        public void TampilkanInfo() // Method untuk menampilkan informasi buku
        {
            Console.WriteLine($"Judul: {Judul}");
            Console.WriteLine($"Pengarang: {Pengarang}");
            Console.WriteLine($"Tahun Terbit: {TahunTerbit}");
        }
    }

    class Program {
        static void Main(String[] args) 
        {
            // Pembentukan (intansiasi objek dengan sintak new)
            List<Buku> bukuList = new List<Buku>();

            Buku buku1 = new Buku();
            buku1.Judul = "Laskar Pelangi";
            buku1.Pengarang = "Andrea Hirata";
            buku1.TahunTerbit = 2005;
            bukuList.Add(buku1);

            // tambahkan buku lain kedalam list 

            foreach (Buku buku in bukuList){
                buku.TampilkanInfo();
                Console.WriteLine();
            }
        }
    }
}
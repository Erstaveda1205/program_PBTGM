using System;
using System.Collections.Generic;
using System.IO.Compression;

namespace mainanOOP
{
    class Mainan {
        public string? Nama {get; set; } 
        public string? Merk {get; set; } 
        public int Stok {get; set; } 
        public int Harga {get; set; } 
        
        public void TampilkanInfo() // Method untuk menampilkan informasi buku
        {
            Console.WriteLine($"Nama Mainan: {Nama}");
            Console.WriteLine($"Merk Mainan: {Merk}");
            Console.WriteLine($"Stok Mainan: {Stok}");
            Console.WriteLine($"Harga Mainan: {Harga}");
        }
    }

    class Program {
        static void Main(String[] args) 
        {
            // Pembentukan (intansiasi objek dengan sintak new)
            List<Mainan> mainList = new List<Mainan>();

            Mainan mainan1 = new Mainan();
            mainan1.Nama = "Alat mancing";
            mainan1.Merk = "Apa aja";
            mainan1.Stok = 200;
            mainan1.Harga = 1000;
            mainList.Add(mainan1);

            // tambahkan buku lain kedalam list 

            foreach (Mainan mainan in mainList){
                mainan.TampilkanInfo();
                Console.WriteLine();
            }
        }
    }
}
using System;
using System.ComponentModel;

class Kalkulator
{
    public double Add(double a, double b)
    {
        return a + b;
    }
    public double Subtract(double a, double b)
    {
        return a - b;
    }
    public double Multiply(double a, double b)
    {
        return a * b;
    }
    public double Divide(double a, double b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Kesalahan: Pembagian dengan nol tidak diperbolehkan");
            return 0;
        }
    }
}
// Kelas Program untuk menjalankan Aplikasi
class Program {
    static void Main(string[] args)
{
    Kalkulator calculator = new Kalkulator();
    //Membaca dua angka dari pengguna
    Console.Write("Masukkan angka pertama: ");
    double angka1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Masukan Angka kedua: ");
    double angka2 = Convert.ToDouble(Console.ReadLine());
    //Memilih operasi yang akan dilakukan 
    Console.WriteLine("Pilih operasi: ");
    Console.WriteLine("1. Penjumlahan");
    Console.WriteLine("2. Pengurangan");
    Console.WriteLine("3. Perkalian");
    Console.WriteLine("4. Pembagian");
    Console.Write("Pilih (1/2/3/4): ");
    int pilihan = Convert.ToInt32(Console.ReadLine());
    //Memanggil metode kalkulator sesuai dnegan pilihan pengguna dan mencetak hasil 
    switch (pilihan)
    {
        case 1:
        Console.WriteLine("Hasil penjumlahan: " + calculator.Add(angka1, angka2));
        break;
        case 2:
        Console.WriteLine("Hasil pengurangan: " + calculator.Subtract(angka1, angka2));
        break;
        case 3:
        Console.WriteLine("Hasil perkalian: " + calculator.Multiply(angka1, angka2));
        break;
        case 4:
        Console.WriteLine("Hasil Pembagian: " + calculator.Divide(angka1, angka2));
        break;
        default: 
        Console.WriteLine("Pilihan tidak valid");
        break;
    }
}
}
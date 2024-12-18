using System;

class Kalkulator{
    public double Add(double a, double b){
        return a + b;
    }
    public double Subtract(double a, double b){
        return a - b;
    }
    public double Multiply(double a, double b){
        return a * b;
    }
    public double Divide(double a, double b){
        if (b != 0){
            return a / b;
        } else{
            Console.WriteLine("Kesalahan: Pembagian dengan nol tidak diperbolehkan");
            return 0;
        }
    }
}

class KalkulatorLagi
{
    static void Main()
    {
        Kalkulator kalkulator = new Kalkulator();

        // Membaca dua angka dari pengguna 
        Console.Write("Masukan Angka pertama: ");
        double angka1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Masukan Angka Kedua: ");
        double angka2 = Convert.ToDouble(Console.ReadLine());

        // Memilih Operasi yang akan di lakukan
        Console.WriteLine("Pilih Operasi: ");
        Console.WriteLine("1. Penjumlahan");
        Console.WriteLine("2. Pengurangan");
        Console.WriteLine("3. Perkalian");
        Console.WriteLine("4. Pembagian");
        Console.Write("Masukan pilihan anda (1/2/3/4): ");
        int pilihan = Convert.ToInt32(Console.ReadLine());

        // Memanggil fungsi yang sesuai dan mencetak hasil
        switch (pilihan)
        {
            case 1:
                Console.WriteLine($"{angka1} + {angka2} = {kalkulator.Add(angka1, angka2)}");
                break;
            case 2:
                Console.WriteLine($"{angka1} - {angka2} = {kalkulator.Subtract(angka1, angka2)}");
                break;
            case 3:
                Console.WriteLine($"{angka1} * {angka2} = {kalkulator.Multiply(angka1, angka2)}");
                break;
            case 4:
                Console.WriteLine($"{angka1} / {angka2} = {kalkulator.Divide(angka1, angka2)}");
                break;
            default:
                Console.WriteLine("Pilihan tidak valid");
                break;
        }
    }
}

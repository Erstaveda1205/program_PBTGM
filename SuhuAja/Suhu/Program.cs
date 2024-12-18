using System;

// Pemrograman berbasis objek
class Suhu
{
    // Properti untuk menyimpan suhu dalam skala Celsius
    public double Celsius { get; set; }

    // Properti untuk menyimpan suhu dalam skala Fahrenheit
    public double Fahrenheit { get; set; }

    // Fungsi untuk mengonversi suhu dari Celsius ke Fahrenheit
    public double ConvertCelsiusToFahrenheit()
    {
        // Rumus: Fahrenheit = (Celsius * 9 / 5) + 32
        return (Celsius * 9 / 5) + 32;
    }

    // Fungsi untuk mengonversi suhu dari Fahrenheit ke Celsius
    public double ConvertFahrenheitToCelsius()
    {
        // Rumus: Celsius = (Fahrenheit - 32) * 5 / 9
        return (Fahrenheit - 32) * 5 / 9;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Membuat objek dari kelas Suhu
        Suhu suhu = new Suhu();

        // Menampilkan menu konversi suhu
        Console.WriteLine("Konversi Suhu");
        Console.WriteLine("1. Celsius ke Fahrenheit");
        Console.WriteLine("2. Fahrenheit ke Celsius");
        
        // Meminta pengguna untuk memilih opsi konversi
        Console.Write("Pilih opsi (1/2): ");
        int pilihan = Convert.ToInt32(Console.ReadLine());

        // Jika pengguna memilih opsi 1 (Celsius ke Fahrenheit)
        if (pilihan == 1)
        {
            // Meminta input suhu dalam Celsius
            Console.Write("Masukkan suhu dalam Celsius: ");
            suhu.Celsius = Convert.ToDouble(Console.ReadLine());

            // Melakukan konversi ke Fahrenheit
            double fahrenheit = suhu.ConvertCelsiusToFahrenheit();

            // Menampilkan hasil konversi
            Console.WriteLine($"{suhu.Celsius} °C = {fahrenheit} °F");
        }
        // Jika pengguna memilih opsi 2 (Fahrenheit ke Celsius)
        else if (pilihan == 2)
        {
            // Meminta input suhu dalam Fahrenheit
            Console.Write("Masukkan suhu dalam Fahrenheit: ");
            suhu.Fahrenheit = Convert.ToDouble(Console.ReadLine());

            // Melakukan konversi ke Celsius
            double celsius = suhu.ConvertFahrenheitToCelsius();

            // Menampilkan hasil konversi
            Console.WriteLine($"{suhu.Fahrenheit} °F = {celsius} °C");
        }
        // Jika input pengguna tidak valid
        else
        {
            Console.WriteLine("Pilihan tidak valid.");
        }
    }
}

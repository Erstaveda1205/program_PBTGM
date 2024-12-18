using System;

// Pemrograman terstruktur

class Program
{
    // Fungsi untuk mengonversi suhu dari Celsius ke Fahrenheit
    static double CelsiusToFahrenheit(double celsius)
    {
        // Rumus: Fahrenheit = (Celsius * 9/5) + 32
        return (celsius * 9 / 5) + 32;
    }

    // Fungsi untuk mengonversi suhu dari Fahrenheit ke Celsius
    static double FahrenheitToCelsius(double fahrenheit)
    {
        // Rumus: Celsius = (Fahrenheit - 32) * 5/9
        return (fahrenheit - 32) * 5 / 9;
    }

    static void Main(string[] args)
    {
        // Menampilkan menu pilihan konversi suhu
        Console.WriteLine("Konversi Suhu");
        Console.WriteLine("1. Celsius ke Fahrenheit");
        Console.WriteLine("2. Fahrenheit ke Celsius");

        // Meminta pengguna memilih opsi
        Console.Write("Pilih opsi (1/2): ");
        int pilihan = Convert.ToInt32(Console.ReadLine());

        // Jika pengguna memilih opsi 1, konversi dari Celsius ke Fahrenheit
        if (pilihan == 1)
        {
            // Meminta input suhu dalam Celsius
            Console.Write("Masukkan suhu dalam Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            // Mengonversi suhu ke Fahrenheit
            double fahrenheit = CelsiusToFahrenheit(celsius);

            // Menampilkan hasil konversi
            Console.WriteLine($"{celsius} °C = {fahrenheit} °F");
        }
        // Jika pengguna memilih opsi 2, konversi dari Fahrenheit ke Celsius
        else if (pilihan == 2)
        {
            // Meminta input suhu dalam Fahrenheit
            Console.Write("Masukkan suhu dalam Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            // Mengonversi suhu ke Celsius
            double celsius = FahrenheitToCelsius(fahrenheit);

            // Menampilkan hasil konversi
            Console.WriteLine($"{fahrenheit} °F = {celsius} °C");
        }
        // Jika input pilihan tidak valid
        else
        {
            Console.WriteLine("Pilihan tidak valid.");
        }
    }
}

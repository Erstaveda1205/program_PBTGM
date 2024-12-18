using System;

class Program
{
    static void Main()
    {
        // Deklarasi konstanta untuk nilai pi
        const double pi = 3.14159;

        // Meminta pengguna untuk memasukkan jari-jari lingkaran
        Console.Write("Masukkan jari-jari lingkaran: ");
        double jariJari = Convert.ToDouble(Console.ReadLine());

        // Menghitung keliling lingkaran
        double keliling = 2 * pi * jariJari;

        // Menghitung luas lingkaran
        double luas = pi * jariJari * jariJari;

        // Mencetak hasil keliling dan luas
        Console.WriteLine($"Keliling lingkaran: {keliling}");
        Console.WriteLine($"Luas lingkaran: {luas}");

        // Menunggu input sebelum menutup program
        Console.ReadKey();
    }
}

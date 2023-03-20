// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Penjumlahan Jumlah = new Penjumlahan();
        double hasilPerjumlahan = Jumlah.JumlahTigaAngka<double>(13,02,21);
        Console.WriteLine(hasilPerjumlahan);    
    }
}

ImageProcessor imageProcessor = new ImageProcessor();

imageProcessor.Resize(-20);
imageProcessor.Resize(80);
imageProcessor.Resize(150);
imageProcessor.Resize(100);
imageProcessor.Resize(40, 60);
imageProcessor.Resize("Folio");
class ImageProcessor
{
    public void Resize(int persentase)
    {
        if (persentase <= 0)
        {
            Console.WriteLine("Error! Presentase tidak boleh nol(0) atau negatif ");
        }
        else if (persentase < 100)
        {
            Console.WriteLine($"Mengecilkan gambar menjadi {persentase}% ");
        }
        else if (persentase > 100)
        {
            Console.WriteLine($"Membesarkan gambar menjadi {persentase}% ");
        }
        else
        {
            Console.WriteLine("Ukuran tetap (100%). Tidak ada perubahan");
        }
    }

    public void Resize(int lebar, int tinggi)
    {
        Console.WriteLine($"Mengubah ukuran gambar {lebar}PX X {tinggi}PX ");
    }

    public void Resize(string ukuran_kertas)
    {
        Console.WriteLine($"Menyesuaikan ke format kertas ke {ukuran_kertas} ");
    }
}
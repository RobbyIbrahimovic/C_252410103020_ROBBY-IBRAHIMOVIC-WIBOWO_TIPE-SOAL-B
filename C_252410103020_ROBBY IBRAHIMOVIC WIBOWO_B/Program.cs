using System.ComponentModel.Design;
using System.Diagnostics.SymbolStore;
using System.Runtime.CompilerServices;
public class Agen
{
    public string idAgen;
    public string namaAgen;
    public int stokAgen;
    public void TampilinInfo()
    {
        Console.WriteLine($"Menampilkan Ingpo Agen Dengan Id: {idAgen}, Nama: {namaAgen}, Stok: {stokAgen}");
    }

}

public class ProdukGalon
{
    private string idProduk { get; set; }
    private string namaProduk { get; set; }
    private int stokGudang { get; set; }
    public void KurangiStock(int jumlah)
    {
        if (stokGudang < 0)
            Console.WriteLine("Stok gak boleh mines");
        else stokGudang -= jumlah;
    }

    public virtual void HitungBiaya(int jumlah)
    {

    }
}

public class GalonAkua : ProdukGalon
{
    public int hargaGalonAkua = 20000;

    public override void HitungBiaya(int jumlah)
    {
        jumlah = jumlah * hargaGalonAkua;
    }
}

 class GalonBerkeran : ProdukGalon
{
    public string jenisKeran;
    public int hargaGalonKeran = 12000;

    public override void HitungBiaya(int jumlah)
    {
        jumlah = jumlah * hargaGalonKeran;
    }
}

class Program()
{
    static void Main()
    {
     
    }
}

public interface DapatDidistribusikan
{
    public void KirimPaket();
}

public class DistribusiGalon : DapatDidistribusikan
{
    public string IngfoAgen;
    public string ProdukGalon;
    public int jumlahGalon;
    public int stokGalon;
   public void KirimPaket()
    {
        if (jumlahGalon <= 0)
            Console.WriteLine("Galon yang dikirim gak boleh 0 atau minus");
        else if (jumlahGalon > stokGalon)
            Console.WriteLine("Galon yang dikirim gak boleh  melebihi stoknya");
        else Console.WriteLine($"Paket berhasil dikirimkan ke agen {IngfoAgen}");
    }
}


// Mohon maaf karena banyak yang error dan banyak yang gak jelas / gak masuk akal dari kode di atas yang telah saya buat kak :] (sowwy)
// Maaf juga karena tidak ada abstraksi karena saya sudah lupa caranya :[ (sowwy again)

class ProgramA
{
    static void Main(string[]args)
    {
        Agen Agn1 = new Agen();
        Agn1.idAgen = "69";
        Agn1.namaAgen = "Bima Si Bob";
        Agn1.stokAgen = 69;
        Agn1.TampilinInfo();

        GalonAkua Galon1 = new GalonAkua();
        Galon1.HitungBiaya(10);

        GalonBerkeran Galon2 = new GalonBerkeran();
        Galon2.jenisKeran = "Keran PDAM";
        Galon2.HitungBiaya(3);
        
    }
}

// Maaf kak saya juga bingung ini kok error padahal sisa warning doang : (
KodePaket k1 = new KodePaket();
Console.WriteLine(k1.getKodePaket("Basic"));
Console.WriteLine(k1.getKodePaket("Premium"));

public class KodePaket
{
    enum Paket { Basic, Standard, Premium, Unlimited, Gaming, Streaming, Family, Student, Traveler}
    public string getKodePaket(String namaPaket)
    {
        string[] kode = ["P201", "P202", "P203", "P204", "P205", "P206", "P207", "P208", "P209", "P2010",];
        return kode[(int)Enum.Parse(typeof(Paket), namaPaket)];
    }
}
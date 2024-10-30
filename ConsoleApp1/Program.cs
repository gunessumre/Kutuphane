using System;

public class Kitap
{
    // Property tanımları
    public string Ad { get; set; }
    public string YazarAdi { get; set; }
    public string YazarSoyadi { get; set; }
    public int SayfaSayisi { get; set; }
    public string Yayinevi { get; set; }
    public DateTime KayitTarihi { get; private set; }

    // Default constructor
    public Kitap()
    {
        KayitTarihi = DateTime.Now; // Kayıt tarihi otomatik atanıyor
    }

    // Parametre alan constructor
    public Kitap(string ad, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayinevi)
    {
        Ad = ad;
        YazarAdi = yazarAdi;
        YazarSoyadi = yazarSoyadi;
        SayfaSayisi = sayfaSayisi;
        Yayinevi = yayinevi;
        KayitTarihi = DateTime.Now; // Kayıt tarihi otomatik atanıyor
    }
}

class Program
{
    static void Main()
    {
        // Farklı yazarların kitaplarını temsil eden nesneler
        Kitap kitap1 = new Kitap("Beyaz Diş", "Jack", "London", 252, "İş Bankası Kültür Yayınları");
        Kitap kitap2 = new Kitap("Martin Eden", "Jack", "London", 480, "Modern Library");
        Kitap kitap3 = new Kitap("Adsız Sansız Bir Jude", "Thomas", "Hardy", 512, "Can Yayınları");
        Kitap kitap4 = new Kitap("Uğultulu Tepeler", "Emily", "Bronte", 400, "İletişim Yayınları");
        Kitap kitap5 = new Kitap("Suç ve Ceza", "Fyodor", "Dostoyevski", 671, "İş Bankası Kültür Yayınları");

        // Kitap bilgilerini ekrana yazdırma
        Console.WriteLine($"Kitap Adı: {kitap1.Ad}, Yazar: {kitap1.YazarAdi} {kitap1.YazarSoyadi}, Sayfa Sayısı: {kitap1.SayfaSayisi}, Yayinevi: {kitap1.Yayinevi}, Kayıt Tarihi: {kitap1.KayitTarihi}");
        Console.WriteLine($"Kitap Adı: {kitap2.Ad}, Yazar: {kitap2.YazarAdi} {kitap2.YazarSoyadi}, Sayfa Sayısı: {kitap2.SayfaSayisi}, Yayinevi: {kitap2.Yayinevi}, Kayıt Tarihi: {kitap2.KayitTarihi}");
        Console.WriteLine($"Kitap Adı: {kitap3.Ad}, Yazar: {kitap3.YazarAdi} {kitap3.YazarSoyadi}, Sayfa Sayısı: {kitap3.SayfaSayisi}, Yayinevi: {kitap3.Yayinevi}, Kayıt Tarihi: {kitap3.KayitTarihi}");
        Console.WriteLine($"Kitap Adı: {kitap4.Ad}, Yazar: {kitap4.YazarAdi} {kitap4.YazarSoyadi}, Sayfa Sayısı: {kitap4.SayfaSayisi}, Yayinevi: {kitap4.Yayinevi}, Kayıt Tarihi: {kitap4.KayitTarihi}");
        Console.WriteLine($"Kitap Adı: {kitap5.Ad}, Yazar: {kitap5.YazarAdi} {kitap5.YazarSoyadi}, Sayfa Sayısı: {kitap5.SayfaSayisi}, Yayinevi: {kitap5.Yayinevi}, Kayıt Tarihi: {kitap5.KayitTarihi}");
    }
}
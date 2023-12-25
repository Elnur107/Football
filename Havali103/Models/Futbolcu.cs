namespace Interfaces.Models;
public interface IFutbolcu
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public string FormaNumarasi { get; set; }
    public string Takim { get; set; }
    public string Mevki { get; set; }
    public byte SutGucu { get; set; }
    public byte Agresiflik { get; set; }
    public bool MilliFutbolcu { get; set; }
    public void SutCek();

}

public class Kaleci : IFutbolcu // Qapici
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public string FormaNumarasi { get; set; }
    public string Takim { get; set; }
    public string Mevki { get; set; }
    public byte SutGucu { get; set; }
    public byte Agresiflik { get; set; }
    public bool MilliFutbolcu { get; set; }
    public byte ElleTopKontrolu { get; set; }
    public void SutCek()
    {
        System.Console.WriteLine("Ortalama Şut hızı : " + SutGucu / 2);
    }
}

public class Forvet : IFutbolcu // Hucumcu
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public string FormaNumarasi { get; set; }
    public string Takim { get; set; }
    public string Mevki { get; set; }
    public byte SutGucu { get; set; }
    public byte Agresiflik { get; set; }
    public bool MilliFutbolcu { get; set; }

    public void SutCek()
    {
        System.Console.WriteLine("Ortalama Şut hızı : " + SutGucu / 2);
    }
}

public class Defans //Mudafiyeci
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public string FormaNumarasi { get; set; }
    public string Takim { get; set; }
    public string Mevki { get; set; }
    public byte SutGucu { get; set; }
    public byte Agresiflik { get; set; }
    public bool MilliFutbolcu { get; set; }

    public void SutCek()
    {
        System.Console.WriteLine("Ortalama Şut hızı : " + SutGucu / 2);
    }
}
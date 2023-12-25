using Interfaces.Models;
using System.Collections;

namespace Interfaces;
public class Program
{
    public static void Main(string[] arg)
    {
        // Intance and initializer
        Kaleci kaleci = new Kaleci();
        kaleci.Adi = "Tafarel";
        kaleci.Soyadi = "Tefal";
        kaleci.FormaNumarasi = "1";
        kaleci.Agresiflik = 10;
        kaleci.Mevki = "Kale";
        kaleci.Takim = "Galatasaray";
        kaleci.MilliFutbolcu = false;
        kaleci.SutGucu = 60;
        kaleci.ElleTopKontrolu = 100;
        kaleci.SutCek();

        // Object initializer
        Forvet forvet = new Forvet  // () -> Constructor optional ( parametreli constructor yoksa zorunlu değil)
        {
            Adi = "Sabri",
            Soyadi = "Sarıoğlu",
            FormaNumarasi = "11",
            Agresiflik = 100,
            Mevki = "Forvet",
            Takim = "Galatasaray",
            MilliFutbolcu = true,
            SutGucu = 10
        };
        forvet.SutCek();



        Defans defans = new();
        defans.Adi = "Reşad";
        defans.Soyadi = "Sadiqov";
        defans.FormaNumarasi = "100";
        defans.Agresiflik = 10;
        defans.Mevki = "Müdafiye Genel Merkezi";
        defans.Takim = "Qarabağ";
        defans.MilliFutbolcu = true;
        defans.SutGucu = 90;
        defans.SutCek();


        var items = new ArrayList();
        items.Add(kaleci);
        items.Add(forvet);
        items.Add(defans);

        #region Ornek1
        // while (true)
        // {
        //   Console.Clear();
        //   Console.WriteLine("Lütfen Seçim Yapınız");
        //   Console.WriteLine("Kaleci için 1");
        //   Console.WriteLine("Forvet için 2");
        //   Console.Write("Lütfen Seçiminizi Giriniz : ");
        //   string secim = Console.ReadLine();
        //   switch (secim)
        //   {
        //     case "1":
        //       {
        //         foreach (var item in items)
        //         {
        //           if (item is Kaleci)
        //           {
        //             Kaleci kaleci1 = (Kaleci)item;
        //             // Console.WriteLine("Kaleci Adı : " + kaleci1.Adi);
        //             // Console.WriteLine("Kaleci Soyadı : " + kaleci1.Soyadi);
        //             // Console.WriteLine("Kaleci Forma Numarası : " + kaleci1.FormaNumarasi);
        //             // Console.WriteLine("Kaleci Agresiflik : " + kaleci1.Agresiflik);
        //             // Console.WriteLine("Kaleci Mevki : " + kaleci1.Mevki);
        //             // Console.WriteLine("Kaleci Takım : " + kaleci1.Takim);
        //             // Console.WriteLine("Kaleci Milli Futbolcu : " + kaleci1.MilliFutbolcu);
        //             // Console.WriteLine("Kaleci Şut Gücü : " + kaleci1.SutGucu);

        //             foreach (var _kaleci in kaleci1.GetType().GetProperties())
        //             {
        //               Console.WriteLine(_kaleci.Name + " : " + _kaleci.GetValue(kaleci1));
        //             }
        //           }
        //         }
        //         break;
        //       }
        //     case "2":
        //       {
        //         foreach (var item in items)
        //         {
        //           if (item is Forvet)
        //           {
        //             Forvet forvet1 = (Forvet)item;
        //             // Console.WriteLine("Forvet Adı : " + forvet1.Adi);
        //             // Console.WriteLine("Forvet Soyadı : " + forvet1.Soyadi);
        //             // Console.WriteLine("Forvet Forma Numarası : " + forvet1.FormaNumarasi);
        //             // Console.WriteLine("Forvet Agresiflik : " + forvet1.Agresiflik);
        //             // Console.WriteLine("Forvet Mevki : " + forvet1.Mevki);
        //             // Console.WriteLine("Forvet Takım : " + forvet1.Takim);
        //             // Console.WriteLine("Forvet Milli Futbolcu : " + forvet1.MilliFutbolcu);
        //             // Console.WriteLine("Forvet Şut Gücü : " + forvet1.SutGucu);
        //             foreach (var _forvet in forvet1.GetType().GetProperties())
        //             {
        //               Console.WriteLine(_forvet.Name + " : " + _forvet.GetValue(forvet1));
        //             }
        //           }
        //         }
        //         break;
        //       }
        //   }
        //   Console.WriteLine("Yeni bir seçim için bir tuşa basınız");
        //   Console.ReadKey();
        // }
        #endregion
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Lütfen Seçim Yapınız");
            Console.WriteLine("Kaleci için 1");
            Console.WriteLine("Forvet için 2");
            Console.WriteLine("Forvet için 3");
            Console.Write("Lütfen Seçiminizi Giriniz : ");
            string secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    {
                        foreach (var item in items)
                        {
                            if (item is Kaleci)
                            {
                                Kaleci kaleci1 = (Kaleci)item;

                                foreach (var _kaleci in kaleci1.GetType().GetProperties())
                                {
                                    Console.WriteLine(_kaleci.Name + " : " + _kaleci.GetValue(kaleci1));
                                }
                            }
                        }
                        break;
                    }
                case "2":
                    {
                        foreach (var item in items)
                        {
                            if (item is Forvet)
                            {
                                Forvet forvet1 = (Forvet)item;
                                foreach (var _forvet in forvet1.GetType().GetProperties())
                                {
                                    Console.WriteLine(_forvet.Name + " : " + _forvet.GetValue(forvet1));
                                }
                            }
                        }
                        break;
                    }
                case "3":
                    {
                        foreach (var item in items)
                        {
                            if (item is Defans)
                            {
                                Defans _item = (Defans)item;
                                foreach (var _defans in _item.GetType().GetProperties())
                                {
                                    Console.WriteLine(_defans.Name + " : " + _defans.GetValue(_item));
                                }
                            }
                        }
                        break;
                    }
            }
            Console.WriteLine("Yeni bir seçim için bir tuşa basınız");
            Console.ReadKey();
        }

    }
}
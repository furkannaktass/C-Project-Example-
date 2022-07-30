using System;
using System.Collections;

namespace ArrayListProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            string kullaniciSecim = string.Empty;
            ArrayList degerlistesi = new ArrayList();
            do
            {


                Console.WriteLine("Menü");
                Console.WriteLine("1 - Deger Ekle");
                Console.WriteLine("2 - Deger Listele");
                Console.WriteLine("3 - Deger Ara");
                Console.WriteLine("4 - Deger Düzenle");
                Console.WriteLine("5 - Deger Sil");
                Console.WriteLine("6 - Uygulama Çıkış");
                Console.Write("Seçiniz:");

                kullaniciSecim = Console.ReadLine();


                

                switch (kullaniciSecim)
                {
                    case "1":
                        Console.Write("Lütfen eklemek istediginiz degeri giriniz");
                        string kullanicideger = Console.ReadLine();
                        degerlistesi.Add(kullanicideger);
                        Console.WriteLine("Degeriniz başarılı şekilde eklendi");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "2":
                    {
                        for (int i = 0 ;  i < degerlistesi.Count; i++)
                        {
                                Console.WriteLine("Dizi Listesi: {0}", degerlistesi[i]);
                        }
                        Console.WriteLine("Devam etmek icin bir tusu basiniz");
                        Console.ReadLine();

                        break;
                    }
                    case "3":
                        Console.WriteLine("Aramak istediginiz degeri giriniz:");
                        string kullaniciAramaDeger = Console.ReadLine();
                        bool kontrol = degerlistesi.Contains(kullaniciAramaDeger);
                        if (kontrol)
                        {
                            int bulunanIndex = degerlistesi.IndexOf(kullaniciAramaDeger);
                            string bulunandeger = degerlistesi[bulunanIndex].ToString();

                            Console.WriteLine("Degeriniz bulundu : index sırasi {0} Deger {1}",bulunanIndex,bulunandeger);
                        }
                        else
                        {
                            Console.WriteLine("Aradıgınız deger bulunamadı");
                        }
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "4":
                        Console.WriteLine("Guncellemek isteginiz degeri giriniz:");
                        string kullaniciDuzenlenecekDeger = Console.ReadLine();
                        Console.WriteLine("{0} degerini hangi deger ile guncellemek istiyorsunuz?",kullaniciDuzenlenecekDeger);
                        string kullaniciYeniDeger = Console.ReadLine();
                        if (degerlistesi.Contains(kullaniciDuzenlenecekDeger))
                        {
                            int kullaniciHedefIndex = degerlistesi.IndexOf(kullaniciDuzenlenecekDeger);
                            degerlistesi[kullaniciHedefIndex] = kullaniciYeniDeger;
                            Console.WriteLine("Degeriniz guncellendi");


                        }
                        else
                        {
                            Console.WriteLine("Aradiginiz deger liste icerisinde bulunamadı");
                        }

                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "5":
                        Console.WriteLine("Tüm degerleri mi silmek istiyorsunuz ? ");
                        string kullaniciSilCevap = Console.ReadLine();

                        if (kullaniciSilCevap.ToUpper() == "E")
                        {
                            degerlistesi.Clear();
                            Console.WriteLine("Tum degerler silindi");
                        }
                        else
                        {
                            Console.WriteLine("Girmek istediginiz degeri giriniz");
                            string kullaniciSilDeger = Console.ReadLine();
                            if (degerlistesi.Contains(kullaniciSilDeger))
                            {
                                degerlistesi.Remove(kullaniciSilDeger);
                                Console.WriteLine("Degeriniz Silinöistir");

                            }
                            else
                            {
                                Console.WriteLine("Silmek istediginiz deger mevcut degil");
                            }
                        }

                        break;
                    default:
                        break;

                }
            } while (kullaniciSecim != "6");

        }

        }
        }
    




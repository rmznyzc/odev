using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramazan_Yazici
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger, toplamA = 0, toplamB = 0, sayi1 = 0, sayi2 = 0, sayac = 0, faktöryel = 1;
            double ort = 0.0, yaricap, cevresi, kuzunluk, kyukseklik, alan, not, not2, not3, kilo, boy, indeks, s1, s2, s3, vize, final;
            int sno = 0;
            Console.WriteLine("Soru numarasını giriniz");
            sno = Convert.ToInt32(Console.ReadLine());
            
                switch (sno)
                {
                    case 1:
                        Console.WriteLine("Sayı biri giriniz.");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Sayı ikiyi giriniz.");
                        sayi2 = Convert.ToInt32(Console.ReadLine());
                        toplamA = sayi1 + sayi2;
                        ort = toplamA / 2;
                        Console.WriteLine("Ortalamanız =" + ort);
                        break;
                    case 2:
                        Console.WriteLine("Sayı giriniz. ");
                        deger = Convert.ToInt32(Console.ReadLine());
                        if (deger > 0)
                        {
                            Console.WriteLine("Girdiğiniz sayı pozitiftir. Sayı=" + deger);
                        }

                        else
                        {
                            Console.WriteLine("Girdiğiniz sayı negatiftir. Sayı=" + deger);
                        }

                        break;
                    case 3:
                        Console.WriteLine("Kenar uzunluğu giriniz");
                        kuzunluk = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Kenarın yüksekliğini giriniz");
                        kyukseklik = Convert.ToDouble(Console.ReadLine());
                        alan = (kyukseklik * kuzunluk) / 2;
                        Console.WriteLine("Üçgenin alanı = " + alan);
                        break;
                    case 4:
                        Console.WriteLine("Birinci sayıyı giriniz ");
                        s1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("İkinci sayıyı giriniz ");
                        s2 = Convert.ToDouble(Console.ReadLine());
                        if (s1 > s2)
                        {
                            Console.WriteLine("Girdiğiniz " + s1 + " sayısı " + s2 + " sayısından büyüktür");
                        }
                        else if (s1 < s2)
                        {
                            Console.WriteLine("Girdiğiniz " + s1 + "sayısı " + s2 + " sayısından küçüktür");
                        }
                        else
                        {
                            Console.WriteLine("Girdiğiniz sayıların ikisi birbirine eşittir.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Vize notunuzu giriniz");
                        vize = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Final notunuzu giriniz");
                        final = Convert.ToDouble(Console.ReadLine());
                        ort = vize * 0.3 + final * 0.7;
                        Console.WriteLine("Not ortalamanız = " + ort);
                        break;
                    case 6:
                        Console.WriteLine("Dairenin yarıçapını giriniz ");
                        yaricap = Convert.ToDouble(Console.ReadLine());
                        alan = 3.14 * yaricap * yaricap;
                        cevresi = 2 * 3.14 * yaricap;
                        Console.WriteLine("Dairenin alanı = " + alan);
                        Console.WriteLine("Dairenin çevresi = " + cevresi);
                        break;
                    case 7:
                        Console.WriteLine("Bir sayı giriniz");
                        deger = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i <= 10; i++)
                        {
                            if (deger > 50)
                            {
                                toplamB = toplamB + 1;
                                Console.WriteLine("Sayı giriniz");
                                deger = Convert.ToInt32(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("Sayı giriniz");
                                deger = Convert.ToInt32(Console.ReadLine());
                            }

                        }
                        Console.WriteLine("50'den büyük sayılar = " + toplamB);
                        break;
                    case 8:
                        Console.WriteLine("Sayı giriniz ");
                        deger = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= 10; i++)
                        {
                            if (deger > 100)
                            {
                                toplamB = toplamB + 1;
                                Console.WriteLine("Sayı giriniz");
                                deger = Convert.ToInt32(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("Sayı giriniz");
                                deger = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        Console.WriteLine("100'den büyük sayılar = " + toplamB);
                        break;
                    case 9:
                        while (true)
                        {
                            Console.WriteLine("Sayı giriniz.");
                            deger = Convert.ToInt32(Console.ReadLine());
                            if (deger == 0)
                            {
                                break;
                            }
                            toplamA = toplamA + deger;
                            sayac++;
                            ort = toplamA / sayac;
                        }
                        break;
                    case 10:
                        Console.WriteLine("1. Notu giriniz");
                        not = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("2. Notu giriniz");
                        not2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("3. Notu giriniz");
                        not3 = Convert.ToDouble(Console.ReadLine());
                        if (not >= 0 && not <= 100 && not2 >= 0 && not2 <= 100 && not3 >= 0 && not3 <= 100)
                        {
                            ort = (not + not2 + not3) / 3;
                            Console.WriteLine("Notlarınız  ortalaması" + ort);
                        }
                        else
                        {
                            Console.WriteLine("Girdiğiniz not değerleri 0-100 arasında olmalıdır.");
                        }
                        break;
                    case 11:
                        for (int i = 1; i <= 1000; i++)
                        {
                            Console.WriteLine(i);
                        }

                        break;
                    case 12:
                        Console.WriteLine("Sayı giriniz.");
                        deger = Convert.ToInt32(Console.ReadLine());
                        if (deger >= 0 && deger <= 100)
                        {
                            Console.WriteLine("Girdiğiniz sayı 0-100 arasındadır.");

                        }
                        else
                        {
                            Console.WriteLine("Girdiğiniz sayı 0-100 arasında değildir.");
                        }
                        break;

                    case 13:
                        Console.WriteLine("Sayı giriniz. ");
                        deger = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= deger; i++)
                        {
                            toplamA += i;
                        }
                        Console.WriteLine("Birden " + deger + "'e kadar olan sayıların toplamı = " + toplamA);
                        break;
                    case 14:
                        Console.WriteLine("10. Soru ile aynı");
                        break;
                    case 15:
                        int derece, radyan, grad;
                        double pi = 3.14;
                        Console.WriteLine("Açıyı giriniz ");
                        derece = Convert.ToInt32(Console.ReadLine());

                        radyan = Convert.ToInt32(derece * pi / 180);
                        grad = derece * 200 / 180;

                        Console.WriteLine("Radyan = " + radyan);
                        Console.WriteLine("Grad = " + grad);
                        break;
                    case 16:
                        Console.WriteLine("Sayı giriniz");
                        deger = Convert.ToInt32(Console.ReadLine());
                        if (deger % 2 == 0)
                        {
                            Console.WriteLine("Girdiğiniz sayı çift bir sayıdır." + deger);
                        }
                        else
                        {
                            Console.WriteLine("Girdiğiniz sayı tek bir sayıdır." + deger);
                        }
                        break;
                    case 17:
                        Console.WriteLine("Sayı giriniz");
                        deger = Convert.ToInt32(Console.ReadLine());
                        int mdeger = Math.Abs(deger);
                        Console.WriteLine("Girilen sayı mutlak değerdir. " + mdeger);
                        break;
                    case 18:
                        Console.WriteLine("Birinci sayıyı giriniz. ");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("İkinci sayıyı giriniz. ");
                        sayi2 = Convert.ToInt32(Console.ReadLine());
                        if (sayi1 % sayi2 == 0)
                        {
                            Console.WriteLine("Girdiğiniz " + sayi1 + " sayısı " + sayi2 + " sayısına tam bölünür");
                        }
                        else
                        {
                            Console.WriteLine("Girdiğiniz " + sayi1 + " sayısı " + sayi2 + " sayısına tam bölünmez");
                        }
                        break;
                    case 19:
                        int cift = 0;
                        Console.WriteLine("Bir sayı giriniz ");
                        s1 = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < s1; i++)
                        {
                            if (i % 2 == 0)
                            {
                                cift += i;
                            }

                        }
                        Console.WriteLine(s1 + " Sayısına kadar çift sayıların toplamı = " + cift);
                        break;
                    case 20:
                        Console.WriteLine("A Değerini Giriniz  ");
                        s1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("B Değerini Giriniz  ");
                        s2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("C Değerini Giriniz  ");
                        s3 = Convert.ToInt32(Console.ReadLine());
                        double d = (s2 * s2) - (4 * s1 * s3);
                        if (d == 0)
                        {
                            double yukseklık = -s2 / (2 * s1);
                            Console.WriteLine("Denklemin Bir Kökü Vardır ");
                            Console.WriteLine("x =" + yukseklık);
                        }
                        else
                        {
                            Console.WriteLine("Sanal Kök Vardır");
                        }

                        break;
                    case 21:

                        break;
                    case 22:
                        Console.WriteLine("Kilonuzu giriniz ");
                        kilo = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Boyunuzu giriniz ");
                        boy = Convert.ToDouble(Console.ReadLine());
                        indeks = kilo / (boy * boy);
                        Console.WriteLine("Vücut kitle indexiniz : {0}", indeks);
                        if (indeks < 18)
                        {
                            Console.WriteLine("Zayıf");
                        }
                        else if (indeks >= 18.5 && indeks < 24.9)
                        {
                            Console.WriteLine("Normal");
                        }
                        else if (indeks >= 24.9 && indeks < 34.9)
                        {
                            Console.WriteLine("fazla kilolu");
                        }
                        else if (indeks >= 24.9 && indeks < 39.9)
                        {
                            Console.WriteLine("1.derece obez");
                        }
                        else if (indeks >= 39.9 && indeks < 40)
                        {
                            Console.WriteLine("2.derece obez");
                        }
                        else if (indeks >= 40 && indeks < 45)
                        {
                            Console.WriteLine("3.derece obez");
                        }
                        break;
                    case 23:
                        double csaati, ucret;
                        Console.WriteLine("Kaç saat çalıştığınızı yazınız  ");
                        csaati = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Saat ücreti giriniz ");
                        ucret = Convert.ToDouble(Console.ReadLine());
                        if (csaati < 40)
                        {
                            ucret = csaati * ucret;
                        }
                        else
                        {
                            ucret = (csaati * 2) * ucret;
                        }
                        Console.WriteLine("Alacağınız ücret : " + ucret + " TL ");
                        Console.ReadLine();
                        break;
                    case 24:
                        Console.WriteLine("Sayı giriniz ");
                        s1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Girdiğiniz sayının tam bölenleri ");
                        for (int i = 1; i <= s1; i++)
                        {
                            if (s1 % i == 0)
                                Console.WriteLine(i + " - ");
                        }
                        break;
                    case 25:
                        Console.WriteLine("Faktöriyeli bulunması istenen sayıyı giriniz ");
                        s1 = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= s1; i++)
                        {
                            faktöryel = faktöryel * i;
                        }
                        Console.WriteLine(s1 + "! = " + faktöryel);
                        break;                
            }
            Console.ReadLine();
        }
    }
}

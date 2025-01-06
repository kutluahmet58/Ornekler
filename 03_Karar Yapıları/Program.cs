using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Karar_Yapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Karar Yapıları(İF-ELSE)

            // If Else(EĞER-DEĞİLSE) Yapısı Karar Yapıları içerisinde en çok kullanılan yapıdır.
            // If Else Yapısı şu şekilde çalışır:
            // Eğer koşul sağlanıyorsa if bloğu çalışır, sağlanmıyorsa else bloğu çalışır.
            // if (koşul)doğruysa yapılacak işlemler;else yapılacak işlemler;
            // Koşul kısmı bool veri tipinde bir ifade olmalıdır. Yani sonucu true ya da false olmalıdır.
            // Koşul kısmı true ise if bloğu çalışır, false ise else bloğu çalışır.
            // Koşul kısmı true ise else bloğu çalışmaz, false ise if bloğu çalışmaz.
            // if bloğu tek başına kullanılabilir, else bloğu tek başına kullanılamaz.
            // if bloğu tek başına kullanıldığında koşul sağlanıyorsa if bloğu çalışır, sağlanmıyorsa hiçbir işlem yapılmaz.


            //Console.WriteLine("Şifreyi Giriniz:");
            //string password = Console.ReadLine();

            //if (password == "1234")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;

            //Console.Write("Ülkeyi Giriniz:");
            //country = Console.ReadLine();

            //Console.Write("Başkenti Giriniz:");
            //capital = Console.ReadLine();

            //if(country == "Türkiye" & capital == "Ankara")
            //{
            //    Console.WriteLine("Doğru Cevap");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış Cevap");
            //}

            //int number;

            //Console.Write("Bir Sayı Giriniz:");
            //number=int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış");
            //}

            //string city;
            //Console.Write("Bir Şehir Giriniz :");
            //city = Console.ReadLine();

            //if(city=="Bursa" | city == "İstanbul"| city == "SİVAS" | city == "Balıkesir")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else 
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "HATA!";

            //Console.Write("1. Sınav Notunu Giriniz:");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Notunu Giriniz:");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3. Sınav Notunu Giriniz:");
            //exam3 = int.Parse(Console.ReadLine());


            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Ortalama : " + average);

            //if (average > 0 & average <= 49)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average > 49 & average <= 69)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 69 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average > 84 & average <= 100)
            //{
            //    result = "Sonuç Çok İyi";
            //}


            //Console.WriteLine(result);


            //Console.Write("Kullanıcı Adını Giriniz: ");
            //string username = Console.ReadLine();

            //if(username!= "admin")
            //{
            //    Console.WriteLine("Kullanıcı Adı Hatalı");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz");
            //}

            //**********Char İF-ELSE Kullanımı**********

            //char team;

            //Console.Write("Takımınızı Giriniz: ");
            //team = char.Parse(Console.ReadLine());


            //if (team == 'b' | team == 'B') 
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //if (team == 'g' | team == 'G') 
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if(team=='f'|team=='F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if(team=='s'|team == 'S')
            //{
            //    Console.WriteLine("Sivasspor");
            //}
            //else
            //{
            //    Console.WriteLine("Takım Bulunamadı");
            //}

            #endregion


            #region Mod İşlemleri(Operatörü)

            //Mod İşlemleri İki Sayının Bölümünden Kalanı Bulmamızı Sağlar.
            //Mod İşlemi % işareti ile yapılır.


            //int number = 26 ;
            //int result = number % 5;
            //Console.WriteLine(result);

            //burda yapılan işlem 26 sayısını 5 e böler ve
            //kalanı bulur. 26/5 = 5 kalan 1 olur.

            //Console.Write("1.Sayıyı Giriniz:");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("2.Sayıyı Giriniz:");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 / number2;
            //int result2 = number1 % number2;
            //Console.WriteLine("1.Sayının 2.Sayıya Bölümü : " + result+" / "+"Kalan Sonuç: " +result2);

            //********************************İF-ELSE Yapısı ile Mod İşlemi Kullanımı********************************

            //Console.WriteLine("Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if(number%2==0)
            //{
            //    Console.WriteLine("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tektir");
            //}




            #endregion


            #region Örnek Menü Uygulaması

            char karakter;

            Console.WriteLine("**********A/B Restoranına Hoşgeldiniz**********");
            Console.WriteLine();
            Console.WriteLine("Menüyü Görmek İçin Bir Tuşa Basınız");
            karakter = char.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("**********MENÜ LİSTEMİZ**********");
            Console.WriteLine("1-Çorba");
            Console.WriteLine("2-Ana Yemek");
            Console.WriteLine("3-Tatlı");
            Console.WriteLine("4-İçecek");
            Console.WriteLine("-----------------------");
            Console.WriteLine();

            string menuİtem;
            Console.Write("Görmek İstediğiniz Menüyü Seçiniz:");
            menuİtem=Console.ReadLine();
            

            if (menuİtem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("-Çorba Menüsü-");
                Console.WriteLine("1-Mercimek Çorbası");
                Console.WriteLine("2-Tarhana Çorbası");
                Console.WriteLine("3-Ezogelin Çorbası");
                
            }
            if (menuİtem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("-Ana Yemek Menüsü-");
                Console.WriteLine("1-Karnıyarık");
                Console.WriteLine("2-Köfte");
                Console.WriteLine("3-Tavuk");
            }
            if (menuİtem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("-Tatlı Menüsü-");
                Console.WriteLine("1-Kadayıf");
                Console.WriteLine("2-Baklava");
                Console.WriteLine("3-Kazandibi");
            }
            if (menuİtem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("-İçecek Menüsü-");
                Console.WriteLine("1-Ayran");
                Console.WriteLine("2-Kola");
                Console.WriteLine("3-Şalgam");
                Console.WriteLine("4-Su");
            }
            if(menuİtem != "1" & menuİtem != "2" & menuİtem != "3" & menuİtem != "4")
            {
                Console.WriteLine("Menü Bulunamadı");
                Console.WriteLine("Çıkış Yapılıyor...");
            }

            #endregion
            Console.Read();
        }
    }
}

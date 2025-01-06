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

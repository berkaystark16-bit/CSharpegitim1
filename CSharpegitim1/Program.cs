using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpegitim1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region YazdırmaKomutları

            //Console.WriteLine("Hello World!");
            //Console.Write("Selam");



            //Console.WriteLine("***** YEMEK KATEGORİLERİ *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** YEMEK KATEGORİLERİ *****");
            //Console.WriteLine();

            #endregion

            #region stringDeğişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Berkay";
            //Console.WriteLine(name);

            //string customerName="Burak";
            //string customerSurname= "Bitkin";
            //string customerPhone="05347542323";
            //string customerEmail = "deneme@gmail.com";
            //string district = "kadıköy";
            //string city = "istanbul";

            //Console.WriteLine("**** Rezarvasyon Kartı **** ");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Müşteri Adı: " + customerName + "" + customerSurname);
            //Console.WriteLine("Müşteri Telefon: " + customerPhone);
            //Console.WriteLine("Müşteri Email: " + customerEmail);
            //Console.WriteLine("Müşteri İl: " + district+"/"+city);
            //Console.WriteLine("--------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "kaya";
            //customerPhone= "05347542323";
            //customerEmail = "aysegul.kaya@gmail.com";
            //district = "sapanca";
            //city = "sakarya";

            //Console.WriteLine("**** Rezarvasyon Kartı **** ");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Müşteri Adı: " + customerName + "" + customerSurname);
            //Console.WriteLine("Müşteri Telefon: " + customerPhone);
            //Console.WriteLine("Müşteri Email: " + customerEmail);
            //Console.WriteLine("Müşteri İl: " + district + "/" + city);
            //Console.WriteLine("--------------------------------");

















            #endregion

            # region Int değişkenler
            //int
            //int number=24;
            //Console.WriteLine(number);

            int hamburgerPrice = 25;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("****Restaurant Menu Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger Fiyatı: " + hamburgerPrice + "TL");
            Console.WriteLine("-----Coke Fiyatı: " + cokePrice + "TL");
            Console.WriteLine("-----Water Fiyatı: " + waterPrice + "TL");
            Console.WriteLine("-----Fries Fiyatı: " + friesPrice + "TL");
            Console.WriteLine("-----Pizza Fiyatı: " + pizzaPrice + "TL");
            Console.WriteLine("-----Lemonade Fiyatı: " + lemonadePrice + "TL");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalhamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalhamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("---------------");
            Console.WriteLine("Hamburger Fiyatı :" + totalhamburgerPrice + "TL");
            Console.WriteLine("Kola Fiyatı :" + totalCokePrice + "TL");
            Console.WriteLine("Su Fiyatı :" + totalWaterPrice + "TL");
            Console.WriteLine("Kızartma Fiyatı :" + totalFriesPrice + "TL");
            Console.WriteLine("Pizza Fiyatı :" + totalPizzaPrice + "TL");
            Console.WriteLine("limonata Fiyatı: " + totalLemonadePrice + "TL");
            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalhamburgerPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;
            Console.WriteLine("Toplam Tutar: " + totalPrice + "TL");

            Console.WriteLine("Toplam Ödencek Tutar: " + totalPrice + "TL");
            Console.Read();
            # endregion
        }
    }
}

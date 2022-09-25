using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            CustomerFollower customer1 = new CustomerFollower();
            customer1.Name = "Burak";
            customer1.SurName = "xx";
            customer1.Id = 1;
            customer1.AccountMoney = 0;
            customer1.AccountNo = 123456789;

            CustomerFollower customer2 = new CustomerFollower();
            customer2.Name = "Burhan";
            customer2.SurName = "xxx";
            customer2.Id = 2;
            customer2.AccountMoney = 12000;
            customer2.AccountNo = 135792468;

            CustomerFollower customer3 = new CustomerFollower();
            customer3.Name = "Abdullah";
            customer3.SurName = "xxxx";
            customer3.Id = 3;
            customer3.AccountMoney = 1409;
            customer3.AccountNo = 987654321;

            CustomerFollower customer4 = new CustomerFollower();
            customer4.Name = "Azat";
            customer4.SurName = "xxxxx";
            customer4.Id = 4;
            customer4.AccountMoney = 10;
            customer4.AccountNo = 121212121;


            Console.WriteLine("Hoş geldiniz.");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("1 - Müşteri Görüntüle        2 - Müşteri Ekle       3 - Müşteri Sil");
            int output = Convert.ToInt32(Console.ReadLine());

            if (output == 1)
            {
                Console.Clear();

                CustomerFollower[] customers = new CustomerFollower[] { customer1, customer2, customer3 };

                foreach (var showInfo in customers)
                {
                    Console.WriteLine("Müşteri adı: " + showInfo.Name + " - " + "Soy adı: " + showInfo.SurName + " - " + "Hesap bakiye: " + showInfo.AccountMoney + " - " + "Hesap numarası: " + showInfo.AccountNo);
                }

            }
            else if (output == 2)
            {
                CustomerFollower[] customers = new CustomerFollower[] { customer1, customer2, customer3, customer4 };
                Console.WriteLine("Başarıyla eklenmiştir.. ");
                Console.WriteLine("Müşteri Bilgileri: " + customer4.Name + " " + customer4.SurName + " - Hesap bakiyesi: " + customer4.AccountMoney + " - Hesap No: " + customer4.AccountNo);
                Console.WriteLine("");
                Console.WriteLine("Müşterileri görüntülemek ister misiniz?");
                Console.WriteLine("1.Evet - 2.Hayır");
                int OutputAgain = int.Parse(Console.ReadLine());

                switch (OutputAgain)
                {
                    case 1:
                        foreach (CustomerFollower customer in customers)
                        {
                            Console.WriteLine("Müşteri adı: " + customer.Name + " - " + "Soy adı: " + customer.SurName + " - " + "Hesap bakiye: " + customer.AccountMoney + " - " + "Hesap numarası: " + customer.AccountNo);
                        }
                        break;
                    
                    case 2:
                        Console.WriteLine("Çıkış Yapılmıştır..");
                        break;

                    default:
                        Console.WriteLine("Hatalı Kodlama!");
                        break;
                }

            }
            else if (output == 3)
            {
                CustomerFollower[] customers = new CustomerFollower[] { customer1, customer2, customer3, customer4 };
                Console.WriteLine("Hesap başarıyla silinmiştir... ");
                Console.WriteLine("Silinen Müşteri Bilgileri: " + customer4.Name + " " + customer4.SurName + " - Hesap bakiyesi: " + customer4.AccountMoney + " - Hesap No: " + customer4.AccountNo);
                Console.WriteLine("Paranız telefonunuz üzerinden diğer kartınıza aktarılmıştır..");
            }

            Console.Read();


        }
    }
}

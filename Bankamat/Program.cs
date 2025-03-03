namespace Bankamat
{
    internal class Program
    {
        static string correctPin = "1111";
        static decimal balance = 100000m;
        //static string code = "+998";

        static void Main(string[] args)
        {
            Console.WriteLine("Pin kodni kiriting: ");
            string kiritilganParol = Convert.ToString(Console.ReadLine());

            if (kiritilganParol == correctPin)
            {
                Console.WriteLine("Muvaffaqiyatli");

            }
            else
            {
                Console.WriteLine("Siz noto'gri Pin kod kiritdingiz");
            }
            Menu();
            KartaBalance();
            PulYechish();
            SmsXabarnomaUlash();

        }
        static void Menu()
        {
            while (true)
            {
                Console.WriteLine("/nBankamat menyusi:");
                Console.Write("1. Karta balansi  ");
                Console.WriteLine("     2. Pul yechish  ");
                Console.Write("3. S xabarnoma ulash   ");
                Console.WriteLine("   4. Tranzaksiyalar tarixi  ");
                Console.WriteLine("5. Chiqish");

                Console.WriteLine("Operatsiyani tanlang: ");
                string Tanlash = Console.ReadLine();
                switch (Tanlash)
                {
                    case "1":
                        KartaBalance();
                        break;
                    case "2":
                        PulYechish();
                        break;
                    case "3":
                        SmsXabarnomaUlash();
                        break;
                    case "4":
                        Console.WriteLine("TranzaksiyalarTarixi()"); //TranzaksiyalarTarixi(); method yaratish kk
                        break;
                    case "5":
                        Console.WriteLine("Dasturdan chiqildi.");
                        return;
                    default:
                        Console.WriteLine("Noto'g'ri tanlov! Qayta urinib ko'ring.");
                        break;

                }

            }

        }
        static void KartaBalance()
        {
            Console.WriteLine($"Sizning hisobingizda: {balance} so'm mavjud.");
        }

        static void PulYechish()
        {
            Console.Write("Qancha pul yechmoqchisiz? ");
            decimal summa = decimal.Parse(Console.ReadLine());
            if (summa < balance)
            {
                Console.WriteLine($"Siz{summa} so'm pul yechib oldingiz");
            }
            else
            {
                Console.WriteLine("Hisobingizda mablag' yetarli emas");
            }
        }
        static void SmsXabarnomaUlash()
        {
            Console.Write("Raqamingizni kiriting: +998");
            int raqam = int.Parse(Console.ReadLine());

            Console.WriteLine("SMS xabarnoma ulash muvafaqqiyatli amalga oshirildi ");
        }


    }
}

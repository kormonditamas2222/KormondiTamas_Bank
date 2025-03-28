namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Owner tulaj = new Owner();
            Bank otp = new Bank(10);
            otp.NewAccount(tulaj, -100000);
            BankCard bankkartya = new BankCard(tulaj, 5000000, "8041235356711042");
            bankkartya.Purchase(20000);
            otp.NewAccount(tulaj, 0);
            Console.WriteLine(otp.TotalBalance(tulaj));
            
        }
    }
}

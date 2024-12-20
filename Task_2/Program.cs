using System;

namespace Task_2
{
    class Converter
    {
        private double UsdRate;
        private double EurRate;
        private double PlnRate;

        public Converter(double usd, double eur, double pln)
        {
            UsdRate = usd;
            EurRate = eur;
            PlnRate = pln;
        }

        public double ConvertFromUah(double amount, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return amount / UsdRate;
                case "eur":
                    return amount / EurRate;
                case "pln":
                    return amount / PlnRate;
                default:
                    throw new Exception("Невідома валюта");
            }
        }

        public double ConvertToUah(double amount, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return amount * UsdRate;
                case "eur":
                    return amount * EurRate;
                case "pln":
                    return amount * PlnRate;
                default:
                    throw new Exception("Невідома валюта");
            }
        }
    }


    class Program
    {
        static void Main()
        {
            Converter converter = new Converter(42.14, 43.67, 10.29);

            Console.WriteLine("Виберіть тип операції:\n\t1 - грн в iноземну валюту\n\t2 - iноземну валюту в грн");
            int choice = int.Parse(Console.ReadLine());
            if (choice != 1 || choice != 2) {
                Console.WriteLine("Невірний вибір операції. Потрібно натиснути: '1' або '2'!");
                Console.ReadLine();
                return;
            }
            Console.Write("Введіть суму: ");
            double amount = double.Parse(Console.ReadLine());

            Console.Write("Введіть валюту (usd/eur/pln): ");
            string currency = Console.ReadLine();

            if (choice == 1)
            {
                double result = converter.ConvertFromUah(amount, currency);
                Console.WriteLine($"Результат: {result:F2} {currency.ToUpper()}");
            }
            else if (choice == 2)
            {
                double result = converter.ConvertToUah(amount, currency);
                Console.WriteLine($"Результат: {result:F2} грн");
            }
            else
            {
                Console.WriteLine("Невірний вибір операції.");
            }
        }
    }
}

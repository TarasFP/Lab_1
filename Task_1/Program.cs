using System;

namespace Task_1
{
    class Address
    {
        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

        public override string ToString()
        {
            return $"Адреса: {Country}, {City}, {Street}, {House}, кв.{Apartment}, Індекс: {Index}";
        }
    }

    class Program
    {
        static void Main()
        {
            Address address = new Address
            {
                Index = 12345,
                Country = "Україна",
                City = "Київ",
                Street = "Хрещатик",
                House = "10",
                Apartment = "5"
            };

            Console.WriteLine(address);
            Console.ReadLine();
        }
    }
}

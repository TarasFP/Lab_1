using System;

namespace Task_3
{
    class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Position { get; set; }
        public int Experience { get; set; }

        private const double TaxRate = 0.2; // 20% податок

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public double CalculateSalary()
        {
            double baseSalary;

            switch (Position.ToLower())
            {
                case "junior":
                    baseSalary = 15000;
                    break;
                case "middle":
                    baseSalary = 30000;
                    break;
                case "senior":
                    baseSalary = 50000;
                    break;
                default:
                    baseSalary = 20000;
                    break;
            }

            return baseSalary + (Experience * 1000); // Додаткові бонуси за стаж
        }

        public double CalculateTax()
        {
            return CalculateSalary() * TaxRate;
        }

        public override string ToString()
        {
            return $"Ім'я: {FirstName}, Прізвище: {LastName}, Посада: {Position}, Стаж: {Experience} років";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Введіть ім'я: ");
            string firstName = Console.ReadLine();

            Console.Write("Введіть прізвище: ");
            string lastName = Console.ReadLine();

            Console.Write("Введіть посаду (junior/middle/senior): ");
            string position = Console.ReadLine();

            Console.Write("Введіть стаж (років): ");
            int experience = int.Parse(Console.ReadLine());

            Employee employee = new Employee(firstName, lastName)
            {
                Position = position,
                Experience = experience
            };

            Console.WriteLine("\nІнформація про співробітника:");
            Console.WriteLine(employee);
            Console.WriteLine($"Оклад: {employee.CalculateSalary():F2} грн");
            Console.WriteLine($"Податковий збір: {employee.CalculateTax():F2} грн");
        }
    }
}

using System;

namespace Task_4
{
    class User
    {
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime RegistrationDate { get; }

        public User()
        {
            RegistrationDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Логін: {Login}\nІм'я: {FirstName}\nПрізвище: {LastName}\nВік: {Age}\nДата реєстрації: {RegistrationDate}";
        }
    }

    class Program
    {
        static void Main()
        {
            User user = new User();

            Console.Write("Введіть логін: ");
            user.Login = Console.ReadLine();

            Console.Write("Введіть ім'я: ");
            user.FirstName = Console.ReadLine();

            Console.Write("Введіть прізвище: ");
            user.LastName = Console.ReadLine();

            Console.Write("Введіть вік: ");
            user.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("\nІнформація про користувача:");
            Console.WriteLine(user);
        }
    }
}

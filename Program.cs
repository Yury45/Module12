namespace Module12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            for (int i = 1; i <= 4; i++)
            {
                users.Add(new User()
                {
                    Name = $"Имя{i}",
                    Login = $"Login{i}",
                    IsPremium = i%2 == 0,
                }); 
            }

            foreach (var user in users)
            {
                Greeting(user);
            }
        }

        static void Greeting(User user)
        {
            Console.WriteLine($"Доброе пожаловать, {user.Name}!");
            if(user.IsPremium) ShowAds();
            Console.WriteLine();
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}
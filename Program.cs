using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SFyCSm012p1e5;

class Program
{

    /// <summary>
    /// Метод реализущий показ рекламы
    /// </summary>
    static void ShowAds()
    {
        var ads = new[]
        {
            "Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com",
            "Купите подписку на МыКомбо и слушайте музыку везде и всегда.",
            "Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу."
        };

        foreach (var ad in ads)
        {
            Console.WriteLine(ad);

            Thread.Sleep(500);
        }
    }

    /// <summary>
    /// Процедура реализующая основной алгоритм работы приложения.
    /// </summary>
    static void PerformMain()
    {
        List<User> users = new List<User>()
        {
            new() {Name = "Пользователь 1", Login = "User1", IsPremium = true},
            new() {Name = "Пользователь 2", Login = "User2", IsPremium = false},
            new() {Name = "Пользователь 3", Login = "User3", IsPremium = false},
        };

        foreach (var user in users)
        {
            Console.WriteLine("Приветствую {0}", user.Name);

            if (!user.IsPremium)
                ShowAds();
        }
    }

    /// <summary>
    /// Главная точка входа приложения
    /// </summary>
    /// <param name="args">Аргументы командной строки при запуске приложения.</param>
    static void Main(string[] args)
    {
        PerformMain();
    }
}
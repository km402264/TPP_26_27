using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите начальный баланс: ");
        double balance = 0;
        List<string> history = new List<string>();

        bool rabota = true;
        while (rabota)
        {
            Console.WriteLine("1 - Показать баланс");
            Console.WriteLine("2 - Пополнить счёт");
            Console.WriteLine("3 - Снять деньги");
            Console.WriteLine("4 - Показать историю операций");
            Console.WriteLine("5 - Выйти");
            Console.Write("Выберите пункт: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PrintBalance(balance);
                    break;

                case "2":
                    Dep(balance, history);
                    break;

                case "3":
                    Snat(balance, history);
                    break;

                case "4":
                    PrintHistory(history);
                    break;

                case "5":
                    rabota = false;
                    break;

                default:
                    Console.WriteLine("Неверный ввод");
                    break;
            }
        }
    }
    static void PrintBalance(double balance)
    {
        Console.WriteLine($"Баланс: {balance} $");
    }
    static void Dep(double balance, List<string> history)
    {
        Console.WriteLine("Пополнить на:");
        double dep = double.Parse(Console.ReadLine());
        if (dep => 0)
        {
            balance += dep;
            history.Add($"Пополнение на {dep}$ ");
            Console.WriteLine("Счёт пополнен");
        }
    }
    static void Snat(double balance, List<string> history)
    {
        Console.WriteLine("Списать: ");
        double snat = double.Parse(Console.ReadLine());
        if (snat > balance)
        {
            Console.WriteLine("Недостаточно средств");
            return;
        }
        if (snat => 0)
        balance -= snat;
        history.Add($"Снято {snat}$");
        Console.WriteLine($"Снято {snat}$");
    }
    static void PrintHistory(List<string> history)
    {

        Console.WriteLine("История операций:");
        for (int i = 0; i < history.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {history[i]}");
        }
    }
}
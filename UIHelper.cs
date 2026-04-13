using System;
using System.Linq;
using System.Threading;

public static class UIHelper
{
    private static readonly Random rand = new Random();

    public static void DisplayHeader()
    {
        Console.Clear();

        string[] logo =
        {
"===========================================================================",
"||                                                                       ||",
"||   ██████╗██╗   ██╗██████╗ ███████╗██████╗                              ||",
"||  ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗                             ||",
"||  ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝                             ||",
"||  ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗                             ||",
"||  ╚██████╗   ██║   ██████╔╝███████╗██║  ██║                             ||",
"||   ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝                             ||",
"||                                                                       ||",
"||        ██████╗██╗  ██╗ █████╗ ████████╗██████╗  ██████╗ ████████╗      ||",
"||       ██╔════╝██║  ██║██╔══██╗╚══██╔══╝██╔══██╗██╔═══██╗╚══██╔══╝      ||",
"||       ██║     ███████║███████║   ██║   ██████╔╝██║   ██║   ██║         ||",
"||       ██║     ██╔══██║██╔══██║   ██║   ██║  ██╗██║   ██║   ██║         ||",
"||       ╚██████╗██║  ██║██║  ██║   ██║   ██████╔╝╚██████╔╝   ██║         ||",
"||        ╚═════╝╚═╝  ██║██║  ██║   ██║   ██████╔╝╚██████╔╝   ██║         ||",
"||        ╚═════╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═════╝  ╚═════╝    ╚═╝         ||",
"||                                                                       ||",
"||                  CYBERSECURITY AWARENESS BOT                          ||",
"||                                                                       ||",
"||                 PROTECTING YOU IN THE DIGITAL WORLD                   ||",
"||                                                                       ||",
"==========================================================================="
        };

        int width = Console.WindowWidth;
        int maxLen = logo.Max(l => l.Length);

        foreach (string line in logo)
        {
            int padding = Math.Max((width - maxLen) / 2, 0);

            Console.ForegroundColor = (ConsoleColor)rand.Next(1, 16);
            Console.WriteLine(new string(' ', padding) + line);
            Thread.Sleep(30);
        }

        Console.ResetColor();

        Console.WriteLine();
        Console.WriteLine("────────────────────────────────────────────────────────────");
        Console.WriteLine("                 CHAT SESSION STARTED");
        Console.WriteLine("────────────────────────────────────────────────────────────");
        Console.WriteLine();
    }

    public static void UserSay(string name, string message)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{name}: {message}");
        Console.ResetColor();
    }

    public static void TypingEffect(string message)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("Bot: ");

        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(15);
        }

        Console.WriteLine();
        Console.ResetColor();
    }

    public static void BotSay(string message)
    {
        TypingEffect(message);
    }

    public static void BotSayPhishing(string message)
    {
        TypingEffect(message);
    }

    public static void WelcomeUser(string name)
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine($"Welcome {name}! 👋");
        Thread.Sleep(300);
        Console.WriteLine("I am your Cybersecurity Awareness Assistant.");
        Thread.Sleep(300);
        Console.WriteLine("Ask me anything about staying safe online.");

        Console.ResetColor();
        Console.WriteLine();
    }
    // Final cleanup for submission
    public static void UnknownResponse(string name)
    {
        TypingEffect($"Sorry {name}, I didn't understand that. Try asking about cybersecurity topics or type 'help'.");
    }
}
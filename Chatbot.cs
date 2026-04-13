using System;

public class Chatbot
{
    public string UserName { get; set; }

    public void Start()
    {
        AskName();
        UIHelper.WelcomeUser(UserName);
        ShowMenu();
        ChatLoop();
    }

    private void AskName()
    {
        Console.Write("Enter your name: ");
        UserName = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(UserName))
        {
            Console.Write("Name cannot be empty. Try again: ");
            UserName = Console.ReadLine();
        }
    }

    private void ShowMenu()
    {
        Console.WriteLine("\n=== Cybersecurity Topics I Can Help With ===\n");
        Console.WriteLine("- Password safety");
        Console.WriteLine("- Phishing scams");
        Console.WriteLine("- Malware protection");
        Console.WriteLine("- Safe browsing");
        Console.WriteLine("- Social engineering");
        Console.WriteLine("- Two-factor authentication\n");
    }

    private void ChatLoop()
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"\n{UserName}: ");
            string input = Console.ReadLine();
            Console.ResetColor();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Please enter a valid question.");
                continue;
            }

            input = input.ToLower();

            if (input.Contains("how are you"))
                UIHelper.TypingEffect("I'm just a bot, but I'm here to help you stay safe online.");

            else if (input.Contains("purpose"))
                UIHelper.TypingEffect("My purpose is to educate users about cybersecurity threats.");

            else if (input.Contains("password"))
                UIHelper.TypingEffect("Use strong, unique passwords and never share them.");

            else if (input.Contains("phishing"))
                UIHelper.TypingEffect("Phishing scams trick you into giving personal information.");

            else if (input.Contains("malware"))
                UIHelper.TypingEffect("Malware can harm your device. Avoid unknown downloads.");

            else if (input.Contains("safe browsing"))
                UIHelper.TypingEffect("Only visit secure websites (https) and avoid suspicious links.");

            else if (input.Contains("social engineering"))
                UIHelper.TypingEffect("Hackers manipulate people to gain access to information.");

            else if (input.Contains("two-factor"))
                UIHelper.TypingEffect("Enable 2FA for extra account security.");

            else if (input.Contains("exit"))
            {
                Console.WriteLine($"Goodbye {UserName}! Stay safe online.");
                break;
            }
            else
            {
                Console.WriteLine("I didn’t understand that. Try asking about cybersecurity topics.");
            }
        }
    }
}
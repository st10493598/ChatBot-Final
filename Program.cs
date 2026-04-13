using System;

class Program
{
    static void Main()
    {
        Console.Title = "Cybersecurity Awareness Bot";

        // Start greeting audio
        AudioPlayer.PlayGreeting();

        // Display application header
        UIHelper.DisplayHeader();

        // Start chatbot
        Chatbot bot = new Chatbot();
        bot.Start();
    }
}
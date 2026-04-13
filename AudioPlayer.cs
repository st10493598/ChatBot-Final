using System;
using System.IO;
using NAudio.Wave;

public static class AudioPlayer
{
    public static void PlayGreeting()
    {
        try
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");

            if (!File.Exists(path))
            {
                Console.WriteLine("Audio file not found. Please ensure greeting.wav is in the correct folder.");
                return;
            }

            Console.WriteLine("Playing welcome audio...");

            using (var audioFile = new AudioFileReader(path))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();

                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    System.Threading.Thread.Sleep(100);
                }
            }

            Console.WriteLine("Audio playback finished.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Audio error occurred: " + ex.Message);
        }
    }
}
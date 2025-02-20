using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Webhook_Spammer
{
//this program is only for educational and fun purpose.Please do not take it seriously.
//I, the creator of this program,will not take any responsibility for what you've done/what damage you've caused with this program
    class Program
    {
        static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        static void shutdown()
        {
            Thread.Sleep(300);
            Console.WriteLine("          5");
            Thread.Sleep(1000);
            Console.WriteLine("          4");
            Thread.Sleep(1000);
            Console.WriteLine("          3");
            Thread.Sleep(1000);
            Console.WriteLine("          2");
            Thread.Sleep(1000);
            Console.WriteLine("          1");
            Thread.Sleep(1000);
            Console.WriteLine("Shutting down now!");
            Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            int pop = 0;
            Console.WriteLine("░█▀▄░█░▄▀▀░▄▀▀░▄▀▄▒█▀▄░█▀▄░░░█░░▒█▒██▀░██▄░█▄█░▄▀▄░▄▀▄░█▄▀░░░▄▀▀▒█▀▄▒▄▀▄░█▄▒▄█░█▄▒▄█▒██▀▒█▀▄");
            Console.WriteLine("▒█▄▀░█▒▄██░▀▄▄░▀▄▀░█▀▄▒█▄▀▒░░▀▄▀▄▀░█▄▄▒█▄█▒█▒█░▀▄▀░▀▄▀░█▒█▒░▒▄██░█▀▒░█▀█░█▒▀▒█░█▒▀▒█░█▄▄░█▀▄");
            Console.WriteLine("Made By Elytride#3807");
            Console.WriteLine("Important note : this project is only made for fun! " + Environment.NewLine + "I am not responsible for what damage/what you've done with this program!");
            Console.Write("Paste the Webhook Link Here : ");
            string eh1 = Console.ReadLine();

            Console.Write("Input the bot's name of your choice : ");
            string eh4 = Console.ReadLine();
            Console.Write("Input the amount of times this webhook will be spammed (must be numbers or it won't work) : ");
            string eh2 = Console.ReadLine();
            {
                if (IsDigitsOnly(eh2) == false)
                {
                    Console.WriteLine("Warning! the input amount is not valid.The program will shut down in 5 seconds!");
                    shutdown();
                }
            }
            Console.Write("Input the text that is going to be sent to that webhook : ");
            string eh3 = Console.ReadLine();
            while (true)
            {
                try
                {
                    {
                        HttpClient client = new HttpClient();
                        Dictionary<string, string> contents = new Dictionary<string, string>
                                        {
                { "content", eh3 },
                { "username", eh4 },
                { "avatar_url", "" }
            };


                        var myhook = eh1;

                        client.PostAsync(myhook, new FormUrlEncodedContent(contents)).GetAwaiter().GetResult();
                    }

                    Task.WaitAll();
                    pop = pop + 1;
                    Console.WriteLine("[" + string.Format("{0:HH:mm:ss tt}", DateTime.Now) + "]" + "[" + pop + "] Discord Webhook Sent!");
                    if (pop == Int32.Parse(eh2))
                    {
                        Console.WriteLine("Amount of webhook requested has reached! Program will shut down in 5 seconds!");
                        shutdown();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Error Detected! Program will shut down in 5 seconds");
                    shutdown();
                }
            }

        }

    }
}

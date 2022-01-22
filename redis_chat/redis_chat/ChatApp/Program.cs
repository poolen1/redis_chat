using System;
using StackExchange.Redis;

namespace redis_chat.ChatApp
{
    class Program
    {
        private const string RedisConnectionString = "172.16.36.94";
        private static ConnectionMultiplexer connection =
            ConnectionMultiplexer.Connect(RedisConnectionString);

        private const string ChatChannel =
            "RedisChat-Channel";
        private static string userName = string.Empty;

        static void Main()
        {
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();
        }
    }
}

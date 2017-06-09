using MauticApiClient.Net;
using System;

namespace ConsoleAppExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = "plop";
            var password = "plop";

            var contactService = new ContactService(new HttpClientProvider("http://213.32.67.38:8888/mautic/api/", username, password));

            contactService.GetById(1).Wait();

            Console.Read();
        }
    }
}

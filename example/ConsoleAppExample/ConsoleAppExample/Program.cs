using MauticApiClient.Net;
using System;

namespace ConsoleAppExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = "";
            var password = "";
            var url = "";
            var httpProvider = new HttpClientProvider(url, username, password);

            var categoryService = new CategoryService(httpProvider);
            var categories = categoryService.Get().Result;
            foreach (var category in categories.Data)
                Console.WriteLine("Category {0}# {1}", category.Id, category.Title);


            var contactService = new ContactService(httpProvider);
            var contacts = contactService.Get().Result;
            foreach (var contact in contacts.Data)
                Console.WriteLine(contact.Id);

            var emailService = new EmailService(httpProvider);
            var emails = emailService.Get().Result;
            foreach (var email in emails.Data)
                Console.WriteLine(email.Name);

            Console.Read();
        }
    }
}

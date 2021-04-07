using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IMail skatMail = new Mail()
            {
                ReceiverList = new List<string>() {"testMail@gmail.dk"},
                Sender = "skat@skat.dk",
                Title = "Årsopgørelse",
                Message = "Du har fået ny årsopgørelse. Besøg skat.dk for at se nærmere"
            };

            IMail spamMail = new Mail()
            {
                ReceiverList = new List<string>() {"testMail@gmail.dk", "PeterMail@gmail.dk"},
                Sender = "skat@skatru.ru",
                Title = "You have money to collect",
                Message = "Du står til at få 22.000 kr. Besøg www.fakeWebsite.ru og få dine penge udbetalt"
            };



        }
    }
}

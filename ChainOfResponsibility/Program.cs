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

            // The other part of the client code constructs the actual chain.
            var business = new BusinessMailHandler();
            var complaint = new ComplaintMailHandler();
            var job = new JobApplicationMailHandler();
            var spam = new SpamMailHandler();

            spam.SetNext(business).SetNext(job).SetNext(complaint);

            // The client should be able to send a request to any handler, not
            // just the first one in the chain.
            Console.WriteLine("Chain: Spam > Business > Job > Complaint\n");
            MailClient.MailClientRequest(spam, "Complaint mail");
            Console.WriteLine();

            Console.WriteLine("Subchain: Job > Complaint\n");
            MailClient.MailClientRequest(job, "Job Application mail");


        }
    }
}

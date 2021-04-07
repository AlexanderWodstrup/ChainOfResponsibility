using System;
using ChainOfResponsibility.EmailHandlers;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
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

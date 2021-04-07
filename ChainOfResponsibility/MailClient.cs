using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class MailClient
    {
        public static void MailClientRequest(BaseHandler handler, string mail)
        {
                Console.WriteLine($"Client: Who wants a {mail}?");

                var result = handler.Handle(mail);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {mail} was not handled.");
                }
        }
    }
}
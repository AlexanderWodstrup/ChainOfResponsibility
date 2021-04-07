using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class MailClient
    {
        public static void MailClientRequest(BaseHandler handler, Mail mail)
        {
                Console.WriteLine($"Client: Who wants a {mail.Type}?");

                var result = handler.Handle(mail);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {mail.Type} was not handled.");
                }
        }
    }
}
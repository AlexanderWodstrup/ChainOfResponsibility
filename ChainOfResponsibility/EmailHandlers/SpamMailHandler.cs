using System;

namespace ChainOfResponsibility.EmailHandlers
{
    class SpamMailHandler : BaseHandler
    {
        public override object Handle(Mail request)
        {
            
            if (request.Type == "Spam mail")
            {
                return $"{request.Type} detected - inserting mail into spam folder\n";
            }
            else
            {
                Console.WriteLine($"SpamHandler can't handle {request.Type}");
                
                return base.Handle(request);
            }
        }
    }
}
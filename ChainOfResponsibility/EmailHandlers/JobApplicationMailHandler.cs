using System;

namespace ChainOfResponsibility.EmailHandlers
{
    class JobApplicationMailHandler : BaseHandler
    {
        public override object Handle(Mail request)
        {
            if (request.Type == "Job Application mail")
            {
                return $"{request.Type} detected - sending to H/R department\n";
            }
            else
            {
                Console.WriteLine($"JobApplicationHandler can't handle {request.Type}");
                return base.Handle(request);
            }
        }
    }
}
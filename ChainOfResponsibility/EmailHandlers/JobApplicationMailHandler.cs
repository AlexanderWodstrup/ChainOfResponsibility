using System;

namespace ChainOfResponsibility.EmailHandlers
{
    class JobApplicationMailHandler : BaseHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Job Application mail")
            {
                return $"{request.ToString()} detected - sending to H/R department\n";
            }
            else
            {
                Console.WriteLine($"JobApplicationHandler can't handle {request.ToString()}");
                return base.Handle(request);
            }
        }
    }
}
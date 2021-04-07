using System;

namespace ChainOfResponsibility.EmailHandlers
{
    class ComplaintMailHandler : BaseHandler
    {
        public override object Handle(Mail request)
        {
            if (request.Type == "Complaint mail")
            {
                return $"{request.Type} detected - sending to Q/A department\n";
            }
            else
            {
                Console.WriteLine($"ComplaintHandler can't handle {request.Type}");
                return base.Handle(request);
            }
        }
    }
}
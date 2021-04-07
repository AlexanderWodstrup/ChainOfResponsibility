using System;

namespace ChainOfResponsibility.EmailHandlers
{
    class ComplaintMailHandler : BaseHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Complaint mail")
            {
                return $"{request.ToString()} detected - sending to Q/A department\n";
            }
            else
            {
                Console.WriteLine($"ComplaintHandler can't handle {request.ToString()}");
                return base.Handle(request);
            }
        }
    }
}
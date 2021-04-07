using System;

namespace ChainOfResponsibility.EmailHandlers
{
    class SpamMailHandler : BaseHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Spam mail")
            {
                return $"{request.ToString()} detected - deleting mail\n";
            }
            else
            {
                Console.WriteLine($"SpamHandler can't handle {request.ToString()}");
                return base.Handle(request);
            }
        }
    }
}
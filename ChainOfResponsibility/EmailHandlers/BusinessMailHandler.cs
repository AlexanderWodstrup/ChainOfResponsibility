using System;

namespace ChainOfResponsibility.EmailHandlers
{
    class BusinessMailHandler : BaseHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Business mail")
            {
                return $"{request.ToString()} detected - sending to CEO\n";
            }
            else
            {
                Console.WriteLine($"BusinessHandler can't handle {request.ToString()}");
                return base.Handle(request);
            }
        }
    }
}
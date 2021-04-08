using System;

namespace ChainOfResponsibility.EmailHandlers
{
    class BusinessMailHandler : BaseHandler
    {
        public override object Handle(Mail request)
        {
            if (request.Type == "Business mail")
            {
                return $"{request.Type} detected - sending to CEO\n";
            }
            else
            {
                Console.WriteLine($"BusinessHandler can't handle mail: {request.Type}");
                return base.Handle(request);
            }
        }
    }
}
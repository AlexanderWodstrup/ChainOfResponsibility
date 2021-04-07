namespace ChainOfResponsibility.EmailHandlers
{
    class BusinessMailHandler : BaseHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Business mail")
            {
                return $"{request.ToString()} detected - sending to CEO";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
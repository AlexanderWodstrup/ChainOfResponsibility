namespace ChainOfResponsibility.EmailHandlers
{
    class SpamMailHandler : BaseHandler
    {
        public override object Handle(object request)
        {
            
            if (request.ToString() == "Spam mail")
            {
                return $"{request.ToString()} detected - deleting mail";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
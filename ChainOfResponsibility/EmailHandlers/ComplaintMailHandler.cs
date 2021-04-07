namespace ChainOfResponsibility.EmailHandlers
{
    class ComplaintMailHandler : BaseHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Complaint mail")
            {
                return $"{request.ToString()} detected - sending to Q/A department";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
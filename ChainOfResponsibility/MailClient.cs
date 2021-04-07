using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class MailClient
    {
        public static void MailClientRequest(BaseHandler handler)
        {
            foreach (var mail in new List<string>
                {"Spam mail", "Job Application mail", "Complaint mail", "Business mail"})
            {

            }
        }
    }
}
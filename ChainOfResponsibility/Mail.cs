using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Mail
    {
        // fyld
        public IEnumerable<string> ReceiverList { get; set; }
        public string Sender { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }

        // Vigtig
        public string Type { get; set; }    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    abstract class BaseHandler
    {
        private BaseHandler _nextHandler;

        public BaseHandler SetNext(BaseHandler handler)
        {
            this._nextHandler = handler;

            return handler;
        }

        public virtual object Handle(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}

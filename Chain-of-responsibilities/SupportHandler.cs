using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibilities
{
    public abstract class SupportHandler
    {
        protected SupportHandler _nextHandler;

        public SupportHandler SetNext(SupportHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual bool HandleRequest()
        {
            if(_nextHandler != null )
            {
                return _nextHandler.HandleRequest();
            }
            return false;
        }
    }
}

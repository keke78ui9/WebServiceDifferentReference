using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceDifferentReference
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFService" in code, svc and config file together.
    public class WCFService : IWCFService
    {
        public void DoWork()
        {
        }

        public string DoWork1()
        {
            return "hello";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceDifferentReference
{
    [ServiceContract]
    public interface IWCFService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        string DoWork1();
    }
}

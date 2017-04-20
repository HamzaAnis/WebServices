using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFLABWEB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculator" in both code and config file together.
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        int add(int n1,int n2);

        [OperationContract]
        int sub(int n1,int n2);


        [OperationContract]
        int div(int n1, int n2);

    }
}

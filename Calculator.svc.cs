using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFLABWEB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculator" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Calculator.svc or Calculator.svc.cs at the Solution Explorer and start debugging.
    public class Calculator : ICalculator
    {

        public void DoWork()
        {
        }

        public int add(int n1, int n2)
        {
            return n1 + n2;
            throw new NotImplementedException();
        }

        public int sub(int n1, int n2)
        {
            return n1 - n2;
            throw new NotImplementedException();
        }

        public int div(int n1, int n2)
        {
            return n1/n2;
            throw new NotImplementedException();
        }
    }
}

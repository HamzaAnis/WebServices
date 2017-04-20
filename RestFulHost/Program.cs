using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web.Services;

namespace RestFulHost
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServiceHost host=new WebServiceHost(typeof(RestFulApplication.IService1));
        }
    }
}

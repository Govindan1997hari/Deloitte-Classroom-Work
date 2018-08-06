using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace CalculatorLibrary
{
    [ServiceContract]
    public interface icalculator
    {
        [OperationContract]
        [FaultContract(typeof(ArgumentException))]
        int add(int x, int y);
        [OperationContract]
        [FaultContract(typeof(ArgumentException))]
        int sub(int x, int y);
    }
}

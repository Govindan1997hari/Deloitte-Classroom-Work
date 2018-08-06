using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfServiceLibrary1
{
    [ServiceContract]
    public interface icarddetail
    {
        [OperationContract]
        [FaultContract(typeof(ArgumentException))]
        bool DateValidate(int cardno);
        [OperationContract]
        [FaultContract(typeof(ArgumentException))]
        bool CvvValidate(int cardno, int cvv);
        [OperationContract]
        [FaultContract(typeof(ArgumentException))]
        bool BalValidation(int cardno, int bal);
    }
}

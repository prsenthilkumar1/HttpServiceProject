using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HttpServiceProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBasicHttp" in both code and config file together.
    [ServiceContract]
    public interface IBasicHttp
    {

        //[OperationContract]
        //string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here


        [OperationContract]
        string SayHello(string name);

        [OperationContract]
        JobModel OpeningJobs();

        [OperationContract]
        JobModel OpeningJobsByRole(string Role);

        [OperationContract]
        decimal Addition(decimal firstNumber, decimal secondNumber);

        [OperationContract]
        decimal Subtraction(decimal firstNumber, decimal secondNumber);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}

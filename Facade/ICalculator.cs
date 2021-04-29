using System.ServiceModel;

namespace Facade
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract(Action = "http://tempuri.org/Add", ReplyAction = "*")]
        int Add(int intA, int intB);

        [OperationContract(Action = "http://tempuri.org/Subtract", ReplyAction = "*")]
        int Subtract(int intA, int intB);

        [OperationContract(Action = "http://tempuri.org/Multiply", ReplyAction = "*")]
        int Multiply(int intA, int intB);

        [OperationContract(Action = "http://tempuri.org/Divide", ReplyAction = "*")]
        int Divide(int intA, int intB);
    }
}

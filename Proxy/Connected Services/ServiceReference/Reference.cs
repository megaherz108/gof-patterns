using System.ServiceModel;

namespace ServiceReference
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

    public partial class CalculatorFacade : ClientBase<ICalculator>, ICalculator
    {
        public CalculatorFacade() : base(GetBindingForEndpoint(), GetEndpointAddress())
        {
            this.Endpoint.Name = "CalculatorSoap";
        }

        public int Add(int intA, int intB)
        {
            return base.Channel.Add(intA, intB);
        }

        public int Subtract(int intA, int intB)
        {
            return base.Channel.Subtract(intA, intB);
        }

        public int Multiply(int intA, int intB)
        {
            return base.Channel.Multiply(intA, intB);
        }

        public int Divide(int intA, int intB)
        {
            return base.Channel.Divide(intA, intB);
        }

        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint()
        {
            var result = new BasicHttpBinding()
            {
                MaxBufferSize = int.MaxValue,
                ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max,
                MaxReceivedMessageSize = int.MaxValue,
                AllowCookies = true
            };

            return result;
        }

        private static EndpointAddress GetEndpointAddress()
        {
            return new EndpointAddress("http://www.dneonline.com/calculator.asmx");
        }
    }
}

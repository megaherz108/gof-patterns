using System.ServiceModel;

namespace Facade
{
    public partial class CalculatorFacade : ClientBase<ICalculator>, ICalculator
    {
        public CalculatorFacade()
            : base(new BasicHttpBinding(), new EndpointAddress("http://www.dneonline.com/calculator.asmx"))
        {
        }

        public int Add(int intA, int intB)
        {
            return Channel.Add(intA, intB);
        }

        public int Subtract(int intA, int intB)
        {
            return Channel.Subtract(intA, intB);
        }

        public int Multiply(int intA, int intB)
        {
            return Channel.Multiply(intA, intB);
        }

        public int Divide(int intA, int intB)
        {
            return Channel.Divide(intA, intB);
        }
    }
}

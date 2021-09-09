using System;

namespace ChainOfResponsibility.Handlers
{
    class PoliceHandler : EmergencyServiceHandler
    {
        public PoliceHandler()
        {
            Description = "Police";
        }
    }
}

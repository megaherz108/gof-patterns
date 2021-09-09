using System;

namespace ChainOfResponsibility.Handlers
{
    class AmbulanceHandler : EmergencyServiceHandler
    {
        public AmbulanceHandler()
        {
            Description = "Ambulance";
        }

    }
}

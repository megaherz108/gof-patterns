using System;

namespace ChainOfResponsibility.Handlers
{
    class FireHandler : EmergencyServiceHandler
    {
        public FireHandler()
        {
            Description = "Fire department";
        }
    }
}

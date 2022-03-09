using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CommunicationService
    {
        private ICommunicate communicationMeans;
        public void SetCommunicationMeans(ICommunicate communicationMeans)
        {
            this.communicationMeans = communicationMeans;
        }

        public void Communicate(string destination)
        {
            var communicate = communicationMeans.Communicate(destination);
            Console.WriteLine(communicate);
        }
    }
}

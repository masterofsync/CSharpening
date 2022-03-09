using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CommunicateViaPhone:ICommunicate
    {
        public string Communicate(string destination)
        {
            return "communicating " + destination + " via Phone..";
        }
    }

    public class CommunicateViaEmail:ICommunicate
    {
        public string Communicate(string destination)
        {
            return "communicating " + destination + " via Email.."; 
        }
    }

    public class CommunicateViaVideo :ICommunicate
    {
        public string Communicate(string destination)
        {
            return "communicating " + destination + " via Video..";
        }
    }
}

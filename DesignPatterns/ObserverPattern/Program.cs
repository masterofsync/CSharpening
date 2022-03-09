using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // create investors
            Investor ivrInvestor1 = new Investor("ivrInvestor1");
            Investor ivrInvestor2 = new Investor("ivrInvestor2");
            Investor ivrInvestor3 = new Investor("ivrInvestor3");
            Investor ivrInvestor4 = new Investor("ivrInvestor4");
            Investor ptraInvestor1 = new Investor("ptraInvestor1");
            Investor ptraInvestor2 = new Investor("ptraInvestor2");
            
            //create stocks
            Stock ivr = new IVR("IVR", 2.1);
            Stock ptra = new PTRA("PTRA", 7.7);

            //attach investors to stock
            ivr.Attach(ivrInvestor1);
            ivr.Attach(ivrInvestor2);
            ivr.Attach(ivrInvestor3);
            ivr.Attach(ivrInvestor4);

            ptra.Attach(ptraInvestor1);
            ptra.Attach(ptraInvestor2);

            //change the price of stock
            ivr.Price = 1.9;
            ivr.Price = 1.9;
            ivr.Price = 9.9;
            ptra.Price = 7.9;
        }
    }
}

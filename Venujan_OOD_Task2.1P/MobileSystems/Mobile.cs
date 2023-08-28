using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileSystems
{
    class Mobile
    {
        private string accType, device, number;
        private double balance;

        public Mobile(string accType, string device, string number)
        {
            this.accType = accType;
            this.device = device;
            this.number = number;
            this.balance = 0.0;
        }

        //Accessor Methods
        public string getAcctype()
        {
            return this.accType;
        }

        public string getDevice()
        {
            return this.device;
        }

        public string getNumber()
        {
            return this.number;
        }

        public string getBalance()
        {
            return this.balance.ToString("C");
        }
    }
}

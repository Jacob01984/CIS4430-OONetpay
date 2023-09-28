using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OONetpay
{
    internal class Netpay
    {
        public string empName;
        public int yoe;
        public int hrs;
        public double pr;

        public double CalcGross()
        {
            return hrs * pr;
        }
        public double CalcFed()
        {
            return CalcGross() * 0.1;
        }
        public double CalcSS()
        {
            return CalcGross() * .05;
        }
        public double CalcMed()
        {
            return CalcGross() * .03;
        }

        public double CalctotalDed()
        {
            return CalcFed() + CalcSS() + CalcMed();
        }
        public double CalcLong()
        {
            if (yoe >= 10 && yoe < 15)
                return 250.00;
            else if (yoe >= 15 && yoe <= 20)
                return 500.00;
            else if (yoe > 20)
                return 1000 + 150 * (yoe - 20);
            else
                return 0.00;
        }
        public double calcNetPay()
        {
            return CalcGross() - CalctotalDed() + CalctotalDed();
        }

    }
}

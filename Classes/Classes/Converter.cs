using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Converter
    {
        public double usd;
        public double eur;
        public double rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public double UAH_to_USD(double value)
        {
            return value / usd;
        }
        public double UAH_to_EUR(double value)
        {
            return value / eur;
        }
        public double UAH_to_RUB(double value)
        {
            return value / rub;
        }
        public double USD_to_UAH(double value)
        {
            return value * usd;
        }
        public double EUR_to_UAH(double value)
        {
            return value * eur;
        }
        public double RUB_to_UAH(double value)
        {
            return value * rub;
        }
    }
}

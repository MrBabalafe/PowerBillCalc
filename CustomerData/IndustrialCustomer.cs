using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerData {
    public class IndustrialCustomer : Customer {

        public IndustrialCustomer() : base() {
            customerType = 'I';
        }

        public IndustrialCustomer(int accountNumber, string customerName) : base(accountNumber, customerName, 'I') {

        }

        public IndustrialCustomer(int accountNumber, string customerName, char customerType, decimal chargeAmount) : base(accountNumber, customerName, 'I', chargeAmount) {

        }

        public override decimal CalculateCharge(int hoursUsed) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculates charge for Industrial Customers
        /// </summary>
        /// <param name="offHoursUsed">Off peak hours kWh used</param>
        /// <param name="peakHoursUsed">Peak hours kWh used</param>
        /// <returns>Amount in dollars that Customer owes</returns>
        public override decimal CalculateCharge(int offHoursUsed, int peakHoursUsed) {
            //Base price, and extra price per kwh for both peak and off peak hours (industrial customers)
            decimal peakBasePrice = 76;
            decimal peakExtraPerKwh = 0.065m;
            decimal offBasePrice = 40;
            decimal offExtraPerKwh = 0.028m;
            decimal total;

            //Calc peak hrs first
            //If you didn't use more than 1000 kWh charge just the base price
            if (peakHoursUsed <= 1000) {
                total = peakBasePrice;

                //If you did use more than 1000 kWh then charge for the extra
            } else {
                int extraHoursUsed = peakHoursUsed - 1000;
                total = peakBasePrice + (extraHoursUsed * peakExtraPerKwh);
            }

            //Calc off hrs next
            if (offHoursUsed <= 1000) {
                total += offBasePrice;

                //If you did use more than 1000 kWh then charge for the extra
            } else {
                int extraHoursUsed = offHoursUsed - 1000;
                total += offBasePrice + (extraHoursUsed * offExtraPerKwh);
            }

            chargeAmount = total;
            return total;
        }
    }
}

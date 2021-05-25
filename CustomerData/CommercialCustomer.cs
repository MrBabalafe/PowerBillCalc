using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerData {
    public class CommercialCustomer : Customer {

        public CommercialCustomer() : base() {
            customerType = 'C';
        }

        public CommercialCustomer(int accountNumber, string customerName) : base(accountNumber, customerName, 'C') {

        }

        public CommercialCustomer(int accountNumber, string customerName, char customerType, decimal chargeAmount) : base(accountNumber, customerName, 'C', chargeAmount) {

        }

        /// <summary>
        /// Calculates charge for Commercial Customers
        /// </summary>
        /// <param name="hoursUsed">kWh used</param>
        /// <returns>Amount in dollars that Customer owes</returns>
        public override decimal CalculateCharge(int hoursUsed) {
            //Base price, and extra price per kwh for commercial customers
            decimal basePrice = 60;
            decimal extraPerKwh = 0.045m;
            decimal total;

            //If you didn't use more than 1000 kWh charge just the base price
            if (hoursUsed <= 1000) {
                total = basePrice;

                //If you did use more than 1000 kWh then charge for the extra
            } else {
                int extraHoursUsed = hoursUsed - 1000;
                total = basePrice + (extraHoursUsed * extraPerKwh);
            }
            
            chargeAmount = total;
            return total;
        }

        public override decimal CalculateCharge(int offHoursUsed, int peakHoursUsed) {
            throw new NotImplementedException();
        }
    }
}

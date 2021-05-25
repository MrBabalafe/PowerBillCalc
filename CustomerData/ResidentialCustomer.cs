using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerData {
    public class ResidentialCustomer : Customer {

        public ResidentialCustomer() : base () {
            customerType = 'R';
        }

        
        public ResidentialCustomer(int accountNumber, string customerName) : base(accountNumber, customerName, 'R') {

        }
        
        public ResidentialCustomer(int accountNumber, string customerName, char customerType, decimal chargeAmount) : base(accountNumber, customerName, 'R', chargeAmount) {

        }

        /// <summary>
        /// Calculates charge for Residential Customers
        /// </summary>
        /// <param name="hoursUsed">kWh Used</param>
        /// <returns>Amount in dollars that Customer owes</returns>
        public override decimal CalculateCharge(int hoursUsed) {
            //Base price, and extra price per kwh for residential customers
            decimal basePrice = 6;
            decimal extraPerKwh = 0.052m;
            decimal total = basePrice + (hoursUsed * extraPerKwh);
            chargeAmount = total;
            return total;
        }

        public override decimal CalculateCharge(int offHoursUsed, int peakHoursUsed) {
            throw new NotImplementedException();
        }

    }
}

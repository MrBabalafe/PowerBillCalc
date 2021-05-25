using System;

namespace CustomerData {
    public abstract class Customer {

        protected int accountNumber;
        protected string customerName;
        protected char customerType;
        protected decimal chargeAmount;

        public int AccountNumber {
            get {
                return accountNumber;
            }
            set {
                if (value > 0) {
                    accountNumber = value;
                }
            }

        }

        public string CustomerName {
            get {
                return customerName;
            }
            set {
                if (value.Length > 0) {
                    customerName = value;
                }
            }
            
        }

        public char CustomerType {
            get {
                return customerType;
            }
            /*set {
                value = Char.ToUpper(value);
                if (value == 'R' || value == 'C' || value == 'I') {
                    customerType = value;
                }
            }
            */
        }
        public decimal ChargeAmount {
            get {
                return chargeAmount;
            }
            set {
                chargeAmount = value;
            }
        }

        /// <summary>
        /// Constructor that takes 0 arguments. Used when Calculate button is pressed.
        /// </summary>
        public Customer() {

        }
        
        public Customer(int accountNumber, string customerName, char customerType) {
            //Set account number
            if(accountNumber > 0) {
                this.accountNumber = accountNumber;
            }

            //Set customer name
            this.customerName = customerName;

            //Set customer type
            customerType = Char.ToUpper(customerType);
            if (customerType == 'R' || customerType == 'C' || customerType == 'I') {
                this.customerType = customerType;
            }

        }

        /// <summary>
        /// This constructor is called when reading from Customers.txt and rebuilding the list of Customers.
        /// </summary>
        /// <param name="accountNumber">Account Number for Customer</param>
        /// <param name="customerName">Customer Name for Customer</param>
        /// <param name="customerType">Customer Type for Customer</param>
        /// <param name="chargeAmount">Charge Amount for Customer</param>
        public Customer(int accountNumber, string customerName, char customerType, decimal chargeAmount) {
            //Set account number
            if (accountNumber > 0) {
                this.accountNumber = accountNumber;
            }

            //Set customer name
            this.customerName = customerName;

            //Set customer type
            customerType = Char.ToUpper(customerType);
            if (customerType == 'R' || customerType == 'C' || customerType == 'I') {
                this.customerType = customerType;
            }

            //Set chargeAmount
            this.chargeAmount = chargeAmount;

        }

        /// <summary>
        /// Abstract method that is used to calculate charge for Residential and Commercial Customers
        /// </summary>
        /// <param name="hoursUsed">kWh Used</param>
        /// <returns>Amount in dollars that Customer owes.</returns>
        public abstract decimal CalculateCharge(int hoursUsed);

        /// <summary>
        /// Abstract method that is used to calculate charge for Industrial Customers
        /// </summary>
        /// <param name="offHoursUsed">Off peak hours kWh used.</param>
        /// <param name="peakHoursUsed">Peak hours kWh used.</param>
        /// <returns>Amount in dollars that Customer owes.</returns>
        public abstract decimal CalculateCharge(int offHoursUsed, int peakHoursUsed);

        /// <summary>
        /// Overridden ToString function 
        /// </summary>
        /// <returns>String displaying all properties of the cutomer</returns>
        public override string ToString() {
            return "Account #: " + accountNumber + ", Name: " + customerName + ", Customer Type: " + customerType + ", Charge Amount: " + chargeAmount.ToString("c");
        }
    }
}

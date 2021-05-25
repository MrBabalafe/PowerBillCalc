using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CustomerData {
    
    /// <summary>
    /// This class is used to Read and Write to Customers.txt (a CSV file containing all customer info.)
    /// </summary>
    public static class DataAccess {

        //Path for Customers.txt is in bin/Debug
        const string PATH = "Customers.txt";
        
        /// <summary>
        /// Reads customers from Customers.txt in bin/Debug
        /// </summary>
        /// <returns>List of Customers that will be used to populate the ListBox on the form</returns>
        public static List<Customer> ReadData() {
            List<Customer> data = new List<Customer>();

            string line;
            string[] parts;
            Customer custToAdd;

            FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            //For each line in Customers.txt split using a comma as a delimiter.
            while(!sr.EndOfStream) {
                line = sr.ReadLine();
                parts = line.Split(',');
                //Values in Customer.txt in order are: account number, name, type, charge amount.
                int accountNumber = Convert.ToInt32(parts[0]);
                string customerName = parts[1];
                char customerType = Convert.ToChar(parts[2]);
                decimal chargeAmount = Convert.ToDecimal(parts[3]);

                //Depending on what type the current customer being parsed is, create a new Customer object.
                if(customerType == 'R') {
                    custToAdd = new ResidentialCustomer(accountNumber, customerName, customerType, chargeAmount);
                } else if(customerType == 'C') {
                    custToAdd = new CommercialCustomer(accountNumber, customerName, customerType, chargeAmount);
                } else {
                    custToAdd = new IndustrialCustomer(accountNumber, customerName, customerType, chargeAmount);
                }

                //Add the customer being parsed into the List of customers, to populate the ListBox
                data.Add(custToAdd);

            }
            sr.Close();
            return data;
        }

        /// <summary>
        /// Stores Customer list into Customers.txt
        /// </summary>
        /// <param name="data">List that contains Customers</param>
        public static void WriteData(List<Customer> data) {
            FileStream fs = new FileStream(PATH, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            //For each customer in the List given, write a CSV line containing in order: account number, name, type, charge amount
            foreach (Customer cust in data) {
                string stringToWrite = cust.AccountNumber.ToString() + "," + cust.CustomerName + "," + cust.CustomerType.ToString() + "," + cust.ChargeAmount.ToString();
                sw.WriteLine(stringToWrite);
            }
            sw.Close();

        }

    }
}

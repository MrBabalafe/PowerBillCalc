using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerData;

/*
 * Project: Calculates power bill cost for customers, depending on customer type (residential, commercial, industrial) and the amount of kWh used
 * Created: Jan 19, 2021
 * Created By: Walker Sakatch
 */


namespace Lab1 {
    public partial class frmPowerBill : Form {
                
        //totalCharge will hold the total charge for the power bill after calculations are done.
        private decimal totalCharge;
        
        //wasError is used for error handling. If any error occurs due to user input then it will be set to true.
        private bool wasError = true;

        //Generic empty Customer object that will be modified and added to the following list.
        public Customer currentCustomer;
        public List<Customer> customerList;

        public frmPowerBill() {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("../../Images/lightbulb.png");
        }

        //Runs when application first starts
        private void frmPowerBill_Load(object sender, EventArgs e) {
            //Read data from Customers.txt and then display each customer saved into the List Box.
            customerList = DataAccess.ReadData();

            foreach(Customer cust in customerList) {
                lstCustomers.Items.Add(cust);
            }

            //Update the calculated values regarding amount owing for different customer types, etc.
            updateTotals();
        }

        //Depending on the value of visible, this method will display the appropriate text boxes and labels for customer type.
        private void setIndustrialOptions(bool visible) {
            lblOffPeakKwhUsed.Visible = visible;
            txtOffPeakKwhUsed.Visible = visible;
            lblPeakKwhUsed.Visible = visible;
            txtPeakKwhUsed.Visible = visible;
            lblKwhUsed.Visible = !visible;
            txtKwhUsed.Visible = !visible;
            if(visible) {
                txtPeakKwhUsed.Focus();
            } else {
                txtKwhUsed.Focus();
            }
        }

        //Method that is used to update total customer and total charges labels on the form
        private void updateTotals() {
            decimal sumOfCharges = 0;
            decimal sumOfRes = 0;
            decimal sumOfCom = 0;
            decimal sumOfInd = 0;

            //For each customer in the List Box, depending on what type they are update the appropriate total.
            foreach(Customer customer in lstCustomers.Items) {
                if(customer.CustomerType == 'R') {
                    sumOfRes += customer.ChargeAmount;
                } else if(customer.CustomerType == 'C') {
                    sumOfCom += customer.ChargeAmount;
                } else {
                    sumOfInd += customer.ChargeAmount;
                }
            }

            sumOfCharges = sumOfRes + sumOfCom + sumOfInd;

            //Change the labels on the form to the new totals.
            lblTotalCustsCount.Text = customerList.Count.ToString();
            lblTotalResidentialCount.Text = sumOfRes.ToString("c");
            lblTotalCommercialCount.Text = sumOfCom.ToString("c");
            lblTotalIndustrialCount.Text = sumOfInd.ToString("c");
            lblTotalChargesCount.Text = sumOfCharges.ToString("c");
        }
        
        //Set Customer type to residential if residential is selected
        private void radResidential_CheckedChanged(object sender, EventArgs e) {
            setIndustrialOptions(false);
        }

        //Set Customer type to commercial if commercial is selected
        private void radCommercial_CheckedChanged(object sender, EventArgs e) {
            setIndustrialOptions(false);
        }

        //Set Customer type to industrial if industrial is selected
        private void radIndustrial_CheckedChanged(object sender, EventArgs e) {
            setIndustrialOptions(true);
        }

        //Makes sure that the inputted text is valid, and if it is convert it to int and return to perform calculation
        //If inputted text is invalid show a dialog box warning user, and return -1 as an error code.
        private int validateandConvert(string textToBeValidated) {
            try {
                int hoursUsed = Convert.ToInt32(textToBeValidated);
                if(hoursUsed >= 0) {
                    return hoursUsed;
                } else {
                    MessageBox.Show("Input for kWh must be a positive whole number", "ERROR");
                    return -1;
                }
            } catch(FormatException err) {
                MessageBox.Show("Input for kWh must be a positive whole number", "ERROR");
                return -1;
            }
        }

        //Makes sure the account number inputted is valid, meaning it is a postive integer.
        private int validateAccNumber(string textToBeValidated) {
            try {
                int accountNumber = Convert.ToInt32(textToBeValidated);
                if (accountNumber >= 0) {
                    return accountNumber;
                } else {
                    MessageBox.Show("Input for Account Number must be a positive whole number");
                    return -1;
                }
            } catch(FormatException err) {
                MessageBox.Show("Input for Account Number must be a positive whole number");
                return -1;
            }
        }

        //Makes sure that the customer name inputted is valid, meaning it is not empty.
        private bool validateCustomerName(string textToBeValidated) {
            if(textToBeValidated.Length <= 0) {
                MessageBox.Show("Must input Customer Name");
                return false;
            } else {
                return true;
            }
        }

        //Calculate Button performs the calculation depending on what customer type is selected, and displays result
        private void btnCalculate_Click(object sender, EventArgs e) {

            //Customer currentCustomer;

            //Calculate charge if customerType is residential. If there is an error set wasError accordingly.
            if (radResidential.Checked) {
                int hoursUsed = validateandConvert(txtKwhUsed.Text);
                //validateAndConvert returns -1 if there was an error
                if(hoursUsed != -1) {
                    currentCustomer = new ResidentialCustomer();
                    totalCharge = currentCustomer.CalculateCharge(hoursUsed);
                    wasError = false;
                } else {
                    txtKwhUsed.Focus();
                    wasError = true;
                }
            //Calculate charge if customerType is commercial. If there is an error set wasError accordingly.
            } else if(radCommercial.Checked) {
                int hoursUsed = validateandConvert(txtKwhUsed.Text);
                //validateAndConvert returns -1 if there was an error
                if (hoursUsed != -1) {
                    currentCustomer = new CommercialCustomer();
                    totalCharge = currentCustomer.CalculateCharge(hoursUsed);
                    wasError = false;
                } else {
                    txtKwhUsed.Focus();
                    wasError = true;
                }
            //Calculate charge if customerType is industrial. If there is an error set wasError accordingly.
            } else {
                int offHoursUsed = validateandConvert(txtOffPeakKwhUsed.Text);
                int peakHoursUsed = validateandConvert(txtPeakKwhUsed.Text);
                //validateAndConvert returns -1 if there was an error
                if (offHoursUsed != -1 && peakHoursUsed != -1) {
                    currentCustomer = new IndustrialCustomer();
                    totalCharge = currentCustomer.CalculateCharge(offHoursUsed, peakHoursUsed);
                    wasError = false;
                } else {
                    txtPeakKwhUsed.Focus();
                    wasError = true;
                }
            }

            //If there were no errors display total charge, if there were errors then make sure total charge box is empty
            if(wasError) {
                txtTotalCharge.Text = "";
            } else {
                txtTotalCharge.Text = totalCharge.ToString("c");
            }
            
        }

        //Clear Button clears all fields, selects residential and puts focus on the textbox for inputing kWh.
        private void btnClear_Click(object sender, EventArgs e) {
            radResidential.Checked = true;
            txtKwhUsed.Text = "";
            txtOffPeakKwhUsed.Text = "";
            txtPeakKwhUsed.Text = "";
            txtTotalCharge.Text = "";
            txtAccountNumber.Text = "";
            txtCustomerName.Text = "";
            txtKwhUsed.Focus();
        }

        //Exit Button closes application when clicked
        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //When user tabs into textboxes or they are given foxus by program, highlight text so it's easier to replace.
        private void txtKwhUsed_Enter(object sender, EventArgs e) {
            if(!String.IsNullOrEmpty(txtKwhUsed.Text)) {
                txtKwhUsed.SelectAll();
            }
        }

        //When user tabs into textboxes or they are given foxus by program, highlight text so it's easier to replace.
        private void txtPeakKwhUsed_Enter(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(txtPeakKwhUsed.Text)) {
                txtPeakKwhUsed.SelectAll();
            }
        }

        //When user tabs into textboxes or they are given foxus by program, highlight text so it's easier to replace.
        private void txtOffPeakKwhUsed_Enter(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(txtOffPeakKwhUsed.Text)) {
                txtOffPeakKwhUsed.SelectAll();
            }

        }

        //Add button adds the current customer to the Listbox, and also updated Customers.txt
        private void btnAddCustomer_Click(object sender, EventArgs e) {

            //Check if User tries to add customer to list before they exist.
            if(txtTotalCharge.Text == "") {
                MessageBox.Show("You must calculate charge for customer before adding them to the list");
                wasError = true;
                txtAccountNumber.Text = "";
                txtCustomerName.Text = "";
                txtKwhUsed.Focus();
                return;
            }

            //Make sure that the inputted account number is valid; if so then change the current Customer's account number
            if (validateAccNumber(txtAccountNumber.Text) == -1) {
                txtAccountNumber.Focus();
                wasError = true;
            } else {
                currentCustomer.AccountNumber = validateAccNumber(txtAccountNumber.Text);
                wasError = false;
            }

            //Make sure that the inputted customer name is valid; if so then change the current Customer's name
            if (validateCustomerName(txtCustomerName.Text)) {
                currentCustomer.CustomerName = txtCustomerName.Text;
            } else {
                txtCustomerName.Focus();
                wasError = true;
            }

            //Clear the form, so that it isn't confusing.
            radResidential.Checked = true;
            txtKwhUsed.Text = "";
            txtOffPeakKwhUsed.Text = "";
            txtPeakKwhUsed.Text = "";
            txtTotalCharge.Text = "";
            txtAccountNumber.Text = "";
            txtCustomerName.Text = "";
            txtKwhUsed.Focus();

            //If no errors occured validating input, then add the customer to the ListBox, and update Customers.txt
            if (!wasError) {
                lstCustomers.Items.Add(currentCustomer);
                customerList.Add(currentCustomer);
                updateTotals();
                DataAccess.WriteData(customerList);
            }

        }

    }
}

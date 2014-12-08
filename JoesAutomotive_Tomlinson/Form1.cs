using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace JoesAutomotive_Tomlinson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ///This application is designed to accept
        ///user input from a variety of checkboxes
        ///and text boxes. Results are display in
        ///summary labels and spoken through the 
        ///speech synthesizer.Sales tax is calculated
        ///at 6% and is only charged on parts. Labor
        ///is $20/per hour.

        //method for speech synth for total charges
        private void SpeakTotal()
        {

         // Initialize a new instance of the SpeechSynthesizer.
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                //set synth rate
                synth.Rate = 1;

                //create a prompt for total and speak
                Prompt total = new Prompt("Your total is " 
                    +totaloutputLabel.Text);
                synth.Speak(total);

            }
        }

        //method for calculating oil and lube charges
        private int OilLubeCharges()
        {
            //define local variable
            int total = 0;            
            //if oil is checked, add 28 to total
            if (oilChangeCheckBox.Checked)
            {
                total += 26;
                servicesOutputLabel.Text = total.ToString("c");
            }


            //if lube is checked, add 18 to total
            if (lubeJobCheckBox.Checked)
            {
                total += 18;
                servicesOutputLabel.Text = total.ToString("c");
                return total;
            }

            else
            {
                return total;
            }
        }

        //method for calculating flush charges
        private int FlushCharges()
        {
            //define local variables
            int total = 0;

            //if radiator box is checked, add 30 to total
            if (radiatorFlushCheckBox.Checked)
            {
                total += 30;
            }

            //if transmission box is checked, add 80 to total
            if (transmissionFlushCheckBox.Checked)
            {
                total += 80;
                return total;
            }
            else
            {
                return total;
            }
        }

        //method for calculating misc charges
        private int MiscCharges()
        {
            //define local variables
            int total = 0;

            //if inspection box is checked, add 15 to total
            if (inspectionCheckBox.Checked)
            {
                total += 15;
                servicesOutputLabel.Text = total.ToString("c");
            }

            //if muffler box is checked, add 100 to total
            if (mufflerCheckbox.Checked)
            {
                total += 100;
                servicesOutputLabel.Text = total.ToString("c");
            }

            //if tire rotation box is checked, add 20 to total
            if (tireRotationCheckBox.Checked)
            {
                total += 20;
                servicesOutputLabel.Text = total.ToString("c");
                return total;
            }
            else
                return total;
        }
	     
        //method for calculating other charges
        private decimal OtherCharges()
	        {
                //constant for labor rate at 20/hour
                const decimal LABOR_RATE = 20.0m;
                //define local variables
                decimal labor = 0m;
                decimal parts = 0m;
                decimal total = 0m;

                if (decimal.TryParse(partsTextBox.Text, out parts))
	            {
                    partsOutputLabel.Text = parts.ToString("c");
	            }

                if (decimal.TryParse(laborTextBox.Text, out labor))
	            {	                
                    labor = (labor * LABOR_RATE);
                    servicesOutputLabel.Text = labor.ToString("c");
                    return total + labor;

	            }
                   
	            else
	            {
                    return total;
	            }
	 
            }
        //method for calculating tax charges        
        private decimal TaxCharges()
        {
            //define variables
            decimal tax = 0m;
            decimal parts;
            decimal totalParts = 0m;

            //get text from parts box and store as totalParts
            //after, display in parts label
            if (decimal.TryParse(partsTextBox.Text, out parts))
            {
                totalParts = parts;
                partsOutputLabel.Text = totalParts.ToString("c");
                //get value from tax label and multiply it 
                //by 6%, displaying result in label
                //return the value as tax

                if (decimal.TryParse(partsTextBox.Text, out parts))
                {
                    tax = totalParts * 0.06m;
                    taxOutputLabel.Text = tax.ToString("c");
                    return tax + totalParts;
                }
                else
                {
                    return totalParts;
                }

            }
            else
            {
                return tax;
            }
        }
        //method for calculating total charges
        private decimal TotalCharges()
        {
            //define local variable
            decimal totalCharges;
            totalCharges = OilLubeCharges() + FlushCharges() + MiscCharges() +
                OtherCharges() + TaxCharges();
            totaloutputLabel.Text = totalCharges.ToString("c");
            return totalCharges;
        }

        //method for clearing oillube boxes
        private void ClearOilLube()
        {
            oilChangeCheckBox.Checked = false;
            lubeJobCheckBox.Checked = false;
        }

        //method for clearing the flush boxes
        private void ClearFlushes()
        {
            radiatorFlushCheckBox.Checked = false;
            transmissionFlushCheckBox.Checked = false;
        }

        //method for clearing misc
        private void ClearMisc()
        {
            inspectionCheckBox.Checked = false;
            tireRotationCheckBox.Checked = false;
            mufflerCheckbox.Checked = false;
        }

        //method for clearing other
        private void ClearOther()
        {
            partsTextBox.Text = "";
            laborTextBox.Text = "";
        }

        //method for clearing fees
        private void ClearFees()
        {
            servicesOutputLabel.Text = "";
            taxOutputLabel.Text = "";
            partsOutputLabel.Text = "";
            totaloutputLabel.Text = "";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //call methods once calculateButton has been clicked
            OilLubeCharges();
            FlushCharges();
            MiscCharges();
            OtherCharges();
            TaxCharges();
            TotalCharges();
            SpeakTotal();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //call clear methods once clearButton has been clicked
            ClearFees();
            ClearFlushes();
            ClearMisc();
            ClearOilLube();
            ClearOther();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}

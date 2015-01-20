/* Name: Cynthia Liu
 * Date: September 9, 2013
 * Purpose: Assignment 1 (Question 1: To convert from an interger number to its corresponding char value0 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        //Store int variable for number
        int number;
        //Store char variable for character
        char character;
        //Store bool variable for isNumber
        bool isNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            //If the user presses the Enter key in the Input textbox
            if (e.KeyCode == Keys.Enter)
            {
                //If the user inputs numbers, isNumber is true
                //Convert the user's input from string to int and stores that value in the variable number
                isNumber = int.TryParse(txtInput.Text, out number);

                //If isNumber is true, the number will be converted into its char value 
                if (isNumber == true)
                {
                    //If the number inputted is greater than or equal to 0 and 
                    //less than or equal to the largest value of Char, the following code will run
                    if (number >= 0 && number <= char.MaxValue)
                    {
                        //Convert the input to char 
                        //Store the converted char to the variable character 
                        character = Convert.ToChar(number);
                        //Output the char character in the textbox
                        txtOutput.Text = character.ToString();
                    }
                    //If the number doesnt meet the conditions, show an error message 
                    else
                    {
                        MessageBox.Show("ERROR! Either your number is negative or too exceeds char's max value." + "\n" + "Please try another number.");
                    }
                }
                //If the input is not a number, show an error message 
                else
                {
                    MessageBox.Show("ERROR! Please enter an interger value.");
                }
            }
            //If the user doesnt press enter in the textbox, do nothing
            else
            {
            }
        }
    }
}

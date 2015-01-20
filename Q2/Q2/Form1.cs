/* Name: Cynthia Liu 
 * Date: September 13, 2013
 * Purpose: Assignment 1 (Questions 2 and 3)
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        //Create a string variable to store the inputted credit card number
        string creditCardNumber;
        //Create the following bool variables 
        //Assign a value of false to is Valid and isEncrypted 
        bool isValid = false, isEncrypted = false;
        //Create a char array to store the digits of the inputted credit card
        char[] cardDigits;
        //Create a double array to store the encrypted value of the credit card digits 
        double[] encryptedDigits;
        //Create a char variable to store the inputted encryption key 
        char encryptionCharacter;

        public Form1()
        {
            InitializeComponent();
        }

        //Outputs the instructions for using the program in a message box whenever the user misues the program, or any input is wrong 
        static void ShowErrorMessage()
        {
            MessageBox.Show("ERROR. Please do the following steps in the correct order:" + "\n" + "1. Enter a VALID credit card number" + "\n" + "2. Enter an encryption key and encrypt" + "\n" + "3. Decrypt");
        }
        
        /// <summary>
        /// Determines whether or not the passed in number has 2 digits, and then adds the digit(s) accordingly
        /// </summary>
        /// <param name="doubledDigit">the origional credit card digit that has been multiplied by 2</param>
        /// <returns>Depending on the number of digits of the passed in number, either the sum of 2 digits or the origional doubled digit</returns>
        int AddDoubledDigitsToSum(int doubledDigit)
        {
            //Create the int variable and assign it the value of 0
            int sumOfDoubledDigits = 0;
            //If the number passed in is greater than 10, the 2 digits which make up the number will be added together
            if (doubledDigit >= 10)
            {
                //Create int variable and assign it the value of 1
                int doubledDigit1 = 1;
                //Create int variable and assign it the value of the number passed in minus 10 
                int doubledDigit2 = doubledDigit - 10;
                //Add the 2 digits together and store it in sumOfDoubledDigits
                sumOfDoubledDigits = sumOfDoubledDigits + doubledDigit1 + doubledDigit2;
                //return the sum of the digits
                return sumOfDoubledDigits;
            }
            //Else, simply return the origional doubled digit
            else
            {
                return doubledDigit;
            }
        }

        /// <summary>
        /// Checks to see if the credit card inputted is valid or not
        /// </summary>
        /// <returns>True or false depending on the validity of the credit card number</returns>
        bool ValidateCreditCard()
        {
            //Create a ulong variable to store the credit card number after it has been "TryParsed"
            ulong tempCreditCardNumber;
            //If TryParse returns true, the user entered positive whole numbers, 
            //and the following code will run 
            if (ulong.TryParse(txtCreditCardNumber.Text, out tempCreditCardNumber) == true)
            {
                //Store the inputted credit card number to the string variable 
                creditCardNumber = txtCreditCardNumber.Text;
                //If the number of digits of the inputted credit card number is between 8 and 19, the following code will run
                if (creditCardNumber.Length >= 8 && creditCardNumber.Length <= 19)
                {
                    //Store the individual digits of the credit card into a char array 
                    cardDigits = creditCardNumber.ToCharArray();
                    //Create the following int variables 
                    //Assign the value of 0 to sumOfDigits
                    int doubledDigit, sumOfDigits = 0;
                    //If the total number of digits in the credit card is divisible by 2 and the following code will run 
                    if (cardDigits.Length % 2 == 0)
                    {
                        //Create a counting loop that will count from 0 to the number of credit card digits by 1
                        for (int counter = 0; counter < cardDigits.Length; counter++)
                        {
                            //If the index of the array is divisible by 2, multiply the digit by 2
                            if (counter % 2 == 0)
                            {
                                doubledDigit = (int)char.GetNumericValue(cardDigits[counter]) * 2;
                                //Call the subprogram AddDoubledDigitsToSum 
                                //Pass in doubledDigit
                                //Add the returned value to the pre-existing sum of digits 
                                sumOfDigits = sumOfDigits + AddDoubledDigitsToSum(doubledDigit);
                            }
                            //Else, simply add the origional digit to the sum of digits 
                            else
                            {
                                sumOfDigits = sumOfDigits + (int)char.GetNumericValue(cardDigits[counter]);
                            }
                        }
                    }
                    //Else, the total number of digits in the credit card is not divisible by 2 and the following code will run
                    else
                    {
                        //Create a counting loop that will count from 0 to the number of credit card digits by 1
                        for (int counter = 1; counter < cardDigits.Length; counter++)
                        {
                            //If the index of the array is divisible by 2, simply add the origional digit to the sum of digits
                            if (counter % 2 == 0)
                            {
                                sumOfDigits = sumOfDigits + (int)char.GetNumericValue(cardDigits[counter]);
                            }
                            //Else, multiply the digit by 2
                            else
                            {
                                doubledDigit = (int)char.GetNumericValue(cardDigits[counter]) * 2;
                                //Call the subprogram AddDoubledDigitsToSum 
                                //Pass in doubledDigit
                                //Add the returned value to the pre-existing sum of digits 
                                sumOfDigits = sumOfDigits + AddDoubledDigitsToSum(doubledDigit);
                            }
                        }
                    }
                    //If the total sum of digits is divisible by 10, the credit card is valid
                    if (sumOfDigits % 10 == 0)
                    {
                        //Output valid
                        lblValidOrInvalid.Text = "valid credit card number";
                        //Assign isValid as true
                        isValid = true;
                        //Return true
                        return true;
                    }
                    //Else, the credit card number is invalid
                    else
                    {
                        //Output invalid 
                        lblValidOrInvalid.Text = "invalid credit card number";
                        //Return false
                        return false;
                    }
                }
                //Else, return false
                else
                {
                    return false;
                }
            }
            //Else, return false
            else
            {
                return false;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Call the subprogram ValidateCreditCard 
            //If the returned value is true, the credit card number is valid, and its corresponding information will be outputted
            if (ValidateCreditCard() == true)
            {
                //Convert the first element of the char array (ie. the first credit card digit) to an int value 
                //If the first digit is 1 or 2, output Airlines as the industry and unknown as the issuer 
                if (cardDigits[0] == '1' || cardDigits[0] == '2')
                {
                    lblIndustry.Text += " Airliners";
                    lblIssuer.Text += " Unknown";
                }
                //If the first digit is 3 output Travel and Entertainment as the industry 
                else if (cardDigits[0] == '3')
                {
                    lblIndustry.Text += " Travel and Entertainment";
                    //If the second credit card digit is 4 or 7, output the Issuer as Amex
                    if (cardDigits[1] == '4' || cardDigits[1] == '7')
                    {
                        lblIssuer.Text += " Amex";
                    }
                    //Else, output unknown as the issuer 
                    else
                    {
                        lblIssuer.Text += " Unknown";
                    }
                }
                //If the first digit of the credit card is 4 or 5, output Banking and Financial as the industry   
                else if (cardDigits[0] == '4' || cardDigits[0] == '5')
                {
                    lblIndustry.Text += " Banking and Financial";
                    //If the first digit is 4, output Visa as the issuer
                    if (cardDigits[0] == '4')
                    {
                        lblIssuer.Text += " Visa";
                    }
                    //If the first digit is 5, and the second digit is either 1, 2, 3, 4 or 5, output Mastercard as the issuer
                    else 
                    {
                        if (cardDigits[1] == '1' || cardDigits[1] == '2' || cardDigits[1] == '3' || cardDigits[1] == '4' || cardDigits[1] == '5')
                        {
                            lblIssuer.Text += " Mastercard";
                        }
                        //Else, output unknown as unknown 
                        else
                        {
                            lblIssuer.Text += " Unknown";
                        }
                    }
                }
                //If the first digit of the credit card is 6, output Merchandising and Banking as the industry 
                else if (cardDigits[0] == '6')
                {
                    lblIndustry.Text += " Merchandizing and Banking";
                    //If the second digit of the credit card is 5, output Discover as the issuer     
                    if (cardDigits[1] == '5')
                    {
                        lblIssuer.Text += " Discover";
                    }
                    //If the second digit of the credit card is 4 and the third digit is 4, output Discover as the issuer
                    else if (cardDigits[1] == '4' && cardDigits[2] == '4')
                    {
                        lblIssuer.Text += " Discover";
                    }
                    //If the second digit of the credit card is 0 and the third digit is 1 and the fourth digit is 1, output Discover as the issuer 
                    else if (cardDigits[1] == '0' && cardDigits[2] == '1' && cardDigits[3] == '1')
                    {
                        lblIssuer.Text += " Discover";
                    }
                    //Else, output unknown as the issuer 
                    else
                    {
                        lblIssuer.Text += " Unknown";
                    }
                }
                //If the first digit of the credit card is 7, output Petroleum as the industry and unknown as the issuer
                else if (cardDigits[0] == '7')
                {
                    lblIndustry.Text += "Petroleum";
                    lblIssuer.Text += " Unknown";
                }
                //If the first digit of the credit card is 8, output Telecommunications as the industry and unknown as the issuer
                else if (cardDigits[0] == '8')
                {
                    lblIndustry.Text += "Telecommunications";
                    lblIssuer.Text += " Unknown";
                }
                //Else, output National Assignment as the industry and unknown as the issuer 
                else
                {
                    lblIndustry.Text += "National Assignment";
                    lblIssuer.Text += " Unknown";
                }
                //Create a counting loop that counts from 6 to the total number of digits in the credit card number by 1
                for (int counter = 6; counter < cardDigits.Length; counter++)
                {
                    //Output the int value of the credit card digits 
                    lblAccountNumber.Text += (int)char.GetNumericValue(cardDigits[counter]);
                }
                //Clear the textbox 
                txtCreditCardNumber.Clear();
            }
            //Else if the returned value from ValidateCreditCard is false, do the following 
            else
            {
                //Call the subprogram ShowErrorMessage
                ShowErrorMessage();
                //Clear the textbox 
                txtCreditCardNumber.Clear();
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            //Set the size of the double array as the length of the char array cardDigits
            encryptedDigits = new double[cardDigits.Length];
            //If the credit card has already been validated, the following code will run 
            if (isValid == true)
            {
                //If the user enters more than encryption key or no encryption key, call the subprogram ShowErrorMessage
                if (txtCreditCardNumber.Text.Length > 1 || txtCreditCardNumber.Text == "")
                {
                    ShowErrorMessage();
                }
                //Else, run the following code
                else
                {
                    //Store the user's inputted encryption character to a char variable 
                    encryptionCharacter = txtCreditCardNumber.Text.ToCharArray()[0];
                    //Create a counting loop that counts from 0 to the total number of digits of the credit card by 1
                    for (int counter = 0; counter < cardDigits.Length; counter++)
                    {
                        //Add the int value of the encryption character to the credit card digit 
                        //Store this value to the corresponding element in the double array 
                        encryptedDigits[counter] = (int)char.GetNumericValue(cardDigits[counter]) + (int)encryptionCharacter;
                        //Square the value, multiply it by 7, and add 17 to it
                        //Replace the old value with this new one in the double array 
                        encryptedDigits[counter] = 7 * Math.Pow(encryptedDigits[counter], 2) + 17;
                        //Output the char representation of the value 
                        txtEncrypted.Text += " " + ((char)encryptedDigits[counter]).ToString();
                        //Assign isEncrypted the value of true 
                        isEncrypted = true;
                    }
                }
            }
            //Else, call the subprogram ShowErrorMessage
            else
            {
                ShowErrorMessage();
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //If the credit card has been encrypted already, the following code will run
            if (isEncrypted == true)
            {
                //Create a counting loop that counts from 0 to the total number of digits of the credit card by 1
                for (int counter = 0; counter < cardDigits.Length; counter++)
                {
                    //17 is subtracted from the element in the array, then it is divided by 7 and then square rooted
                    //Replace the old value in the array with this new one 
                    encryptedDigits[counter] = Math.Sqrt(((encryptedDigits[counter] - 17) / 7));
                    //Subtract the int value of the inputted encryption character from the element in the array 
                    //Replace the old value in the array with this new one
                    encryptedDigits[counter] = encryptedDigits[counter] - encryptionCharacter;
                    //Output the now decrypted digit  
                    txtDecrypted.Text += " " + (encryptedDigits[counter]).ToString();
                }
            }
            //If not, the subprogram ShowErrorMessage is called
            else
            {
                ShowErrorMessage();
            }
        }
    }
}

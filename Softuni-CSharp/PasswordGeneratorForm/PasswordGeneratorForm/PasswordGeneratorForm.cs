using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGeneratorForm
{
    public partial class PasswordGeneratorForm : Form
    {
        private const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SmallLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string Digits = "0123456789";
        private const string SpecialChars = "~!@#$%^&*()_+=`{}[]\\|':;.,/?<>";
       // private string AllChars = "";
        private StringBuilder AllChars = new StringBuilder();
        private static Random randGen = new Random();

        private static char GenerateChar(string availableChars)
        {
            int randomIndex = randGen.Next(availableChars.Length);
            char randomChar = availableChars[randomIndex];
            return randomChar;
        }
        private static void InsertAtRandomPosition(StringBuilder password, char character)
        {
            int randomPosition = randGen.Next(password.Length + 1);
            password.Insert(randomPosition, character);
        }


        public PasswordGeneratorForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void genPassButton_Click(object sender, EventArgs e)
        {
            StringBuilder password = new StringBuilder();
            

            //generate capital letters in password
            if (capitalLettersCheckbox.Checked == true)
            {
                for (int i = 1; i <= capitalLettersNumUpDown.Value; i++)
                {
                    char capitalLetter = GenerateChar(CapitalLetters);
                    InsertAtRandomPosition(password, capitalLetter);
                }
            }

            //generate small letters in password
            if (smallLettersCheckbox.Checked == true)
            {
                for (int i = 1; i <= smallLettersNumUpDown.Value; i++)
                {
                    char smallLetter = GenerateChar(SmallLetters);
                    InsertAtRandomPosition(password, smallLetter);
                } 
            }
            //generate digits in password
            if (digitsCheckbox.Checked == true)
            {
                for (int i = 1; i <= digitsNumUpDown.Value; i++)
                {
                    char digit = GenerateChar(Digits);
                    InsertAtRandomPosition(password, digit);
                } 
            }
            //generate special characters in password
            if (specialCharsCheckBox.Checked == true)
            {
                for (int i = 1; i <= digitsNumUpDown.Value; i++)
                {
                    char specialChar = GenerateChar(SpecialChars);
                    InsertAtRandomPosition(password, specialChar);
                }
            }

            //generate more random symbols

            if (capitalLettersCheckbox.Checked == true)
            {
                AllChars.Append(CapitalLetters);
            }
            else if(AllChars.ToString().IndexOf('A') >= 0)
            {
                //try add it to check method
                int start = AllChars.ToString().IndexOf('A');
                int end = AllChars.ToString().IndexOf('Z');
                AllChars.Remove(start, end-start+1);
            }

            if (smallLettersCheckbox.Checked == true)
            {
                AllChars.Append(SmallLetters);
            }
            else if (AllChars.ToString().IndexOf('a') >= 0)
            {
                int start = AllChars.ToString().IndexOf('a');
                int end = AllChars.ToString().IndexOf('z');
                AllChars.Remove(start, end - start+1);
            }

            if (digitsCheckbox.Checked == true)
            {
                AllChars.Append(Digits);
            }
            else if (AllChars.ToString().IndexOf('0') >= 0)
            {
                int start = AllChars.ToString().IndexOf('0');
                int end = AllChars.ToString().IndexOf('9');
                AllChars.Remove(start, end - start + 1);
            }

            if (specialCharsCheckBox.Checked == true)
            {
                AllChars.Append(SpecialChars);
            }
            else if (AllChars.ToString().IndexOf('~') >= 0)
            {
                int start = AllChars.ToString().IndexOf('~');
                int end = AllChars.ToString().IndexOf('>');
                AllChars.Remove(start, end - start + 1);
            }

            int maxAdditionalChars = int.Parse(maxLengthTextbox.Text) - password.Length;
            int additionalCharsCount = randGen.Next(maxAdditionalChars + 1);
            for (int i = 0; i <= additionalCharsCount; i++)
            {
                char randomChar = GenerateChar(AllChars.ToString());
                InsertAtRandomPosition(password, randomChar);
            }

            //show password in texbox
            pwTextbox.Text = password.ToString();

        }

        private void capitalLettersCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (capitalLettersCheckbox.Checked == true)
            {
                capitalLettersNumUpDown.Visible = true;
            }
            else
            {
                capitalLettersNumUpDown.Visible = false;
            }
        }

        private void smallLettersCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (smallLettersCheckbox.Checked == true)
            {
                smallLettersNumUpDown.Visible = true;
            }
            else
            {
                smallLettersNumUpDown.Visible = false; 
            }
        }

        private void digitsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (digitsCheckbox.Checked == true)
            {
                digitsNumUpDown.Visible = true;
            }
            else
            {
                digitsNumUpDown.Visible = false;
            }
        }

        private void specialCharsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (specialCharsCheckBox.Checked == true)
            {
                specialCharsNumUpDown.Visible = true;
            }
            else
            {
                specialCharsNumUpDown.Visible = false;
            }

        }
    }
}

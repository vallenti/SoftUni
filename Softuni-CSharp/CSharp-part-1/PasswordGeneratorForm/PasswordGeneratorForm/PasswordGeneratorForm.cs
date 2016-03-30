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
        private void RemoveCharacters(char a, char b)
        {
            int start = AllChars.ToString().IndexOf(a);
            int end = AllChars.ToString().IndexOf(b);
            AllChars.Remove(start, end - start + 1);
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

            StringBuilder generatedString = new StringBuilder();

            //generate capital letters in password
            if (capitalLettersCheckbox.Checked == true)
            {
                for (int i = 1; i <= capitalLettersNumUpDown.Value; i++)
                {
                    char capitalLetter = GenerateChar(CapitalLetters);
                    InsertAtRandomPosition(generatedString, capitalLetter);
                }
            }

            //generate small letters in password
            if (smallLettersCheckbox.Checked == true)
            {
                for (int i = 1; i <= smallLettersNumUpDown.Value; i++)
                {
                    char smallLetter = GenerateChar(SmallLetters);
                    InsertAtRandomPosition(generatedString, smallLetter);
                }
            }

            //generate digits in password
            if (digitsCheckbox.Checked == true)
            {
                for (int i = 1; i <= digitsNumUpDown.Value; i++)
                {
                    char digit = GenerateChar(Digits);
                    InsertAtRandomPosition(generatedString, digit);
                }
            }
            //generate special characters in password
            if (specialCharsCheckBox.Checked == true)
            {
                for (int i = 1; i <= digitsNumUpDown.Value; i++)
                {
                    char specialChar = GenerateChar(SpecialChars);
                    InsertAtRandomPosition(generatedString, specialChar);
                }
            }


            
            //generate more random symbols
            int maxAdditionalChars = 0;
            int maxLength=0;
            try
            {
                maxAdditionalChars = int.Parse(maxLengthTextbox.Text) - generatedString.Length;
                maxLength = int.Parse(maxLengthTextbox.Text);
                if (maxLength >= generatedString.Length)
                {
                    int additionalCharsCount = randGen.Next(maxAdditionalChars + 1);
                    for (int i = 0; i < additionalCharsCount; i++)
                    {
                        char randomChar = GenerateChar(AllChars.ToString());
                        InsertAtRandomPosition(generatedString, randomChar);
                    }
                    //show password in texbox
                    stringTextbox.Text = generatedString.ToString();
                }
                else
                {
                    MessageBox.Show("Maximum numbers cannot be less than minimum requiered symbols.","Error");
                }
            }
            catch (FormatException)
            {
                if (generatedString.Length>=1)
                {
                    stringTextbox.Text = generatedString.ToString();
                }
                else
                {
                    MessageBox.Show("invalid number", "Error");
                }
            }
        }

        private void capitalLettersCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (capitalLettersCheckbox.Checked == true)
            {
                capitalLettersNumUpDown.Enabled = true;
                genPassButton.Enabled = true;
                AllChars.Append(CapitalLetters);
            }
            else if (AllChars.ToString().IndexOf('A') >= 0)
            {
                capitalLettersNumUpDown.Enabled = false;
                genPassButton.Enabled = false;
                RemoveCharacters('A', 'Z');
            }
        }


        private void smallLettersCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (smallLettersCheckbox.Checked == true)
            {
                smallLettersNumUpDown.Enabled = true;
                genPassButton.Enabled = true;
                AllChars.Append(SmallLetters);
            }
            else if (AllChars.ToString().IndexOf('a') >= 0)
            {
                smallLettersNumUpDown.Enabled = false;
                genPassButton.Enabled = false;
                RemoveCharacters('a', 'z');
            }
        }

        private void digitsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (digitsCheckbox.Checked == true)
            {
                digitsNumUpDown.Enabled = true;
                genPassButton.Enabled = true;
                AllChars.Append(Digits);
            }
            else if (AllChars.ToString().IndexOf('0') >= 0)
            {
                digitsNumUpDown.Enabled = false;
                genPassButton.Enabled = false;
                RemoveCharacters('0', '9');
            }
        }

        private void specialCharsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (specialCharsCheckBox.Checked == true)
            {
                specialCharsNumUpDown.Enabled = true;
                genPassButton.Enabled = true;
                AllChars.Append(SpecialChars);
            }
            else if (AllChars.ToString().IndexOf('~') >= 0)
            {
                specialCharsNumUpDown.Enabled = false;
                genPassButton.Enabled = false;
                RemoveCharacters('~', '>');
            }

        }

        private void capitalLettersNumUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;

namespace CharacterCreator
{
    class Character
    {
        private string firstName;
        private string lastName;
        private string charClass;

        public Character()
        {
            firstName = null;
            lastName = null;
            charClass = null;
        }
        
        public Character(string firstName, string lastName, string charClass)
        {
            firstName = this.firstName;
            lastName = this.lastName;
            charClass = this.charClass;
        }

        public override string ToString()
        {
            string output = null;
            output += "NAME: " + firstName + " " + lastName;
            output += " CLASS: " + charClass;
            return output;
        }

        public Boolean validateLength(string value)
        {
            if (value.Length == 0)
                return false;
            else
                return true;
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (validateLength(value))
                    firstName = value;
                else
                    firstName = "ERROR SETTING FIRSTNAME";
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (validateLength(value))
                    lastName = value;
                else
                    lastName = "ERROR SETTING LASTNAME";
            }
        }

        public string CharacterClass
        {
            get { return charClass; }
            set
            {
                if (validateLength(value))
                    charClass = value;
                else
                    charClass = "ERROR SETTING CHARACTER CLASS";
            }
        }
        
    } // END CLASS
} // END NAMESPACE

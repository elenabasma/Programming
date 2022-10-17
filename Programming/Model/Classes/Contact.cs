namespace Programming.Model
{
    public class Contact
    {
        private string _phoneNumber;
        private string _firstName;
        private string _lastName;
        public Contact(string phoneNumber, string firstName, string lastName)
        {
            PhoneNumber = phoneNumber;
            FirstName = firstName;
            LastName = lastName;
        }

        public Contact() { }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                Validator.AssertStringNumberIsCorrect(nameof(PhoneNumber), value);
                _phoneNumber = value;
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(nameof(FirstName), value);
                _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(nameof(LastName), value);
                _lastName = value;
            }
        }
    }
}
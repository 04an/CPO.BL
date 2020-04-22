using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public int CustId { get; private set; }
        public static int InstanceCount { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string FullName
        {
            get 
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
            
        }

        //Validates the customer data
        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }

            return isValid;
        }

        //Save the current customer
        public bool Save( )
        {

            return true;
        }

        //Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        //Retrieve all cutomers
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer(): this(0)
        {

        }

        public Customer(int customerId)
        {
            this.CustId = customerId;
            AddressList = new List<Address>();
        }
        public int CustId { get; private set; }
        public int CustomerType { get; set; }
        public static int InstanceCount { get; set; }
        public Address HomeAddres { get; set; }
        public Address WorkAddress { get; set; }
        public List<Address> AddressList { get; set; }
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

        public override string ToString() => FullName;

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

    }
}

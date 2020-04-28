using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class AddressRepository
    {
        //Retrieve one address
        public Address Retrieve (int addressID)
        {
            Address address = new Address(addressID);

            //Temporary values to return
            if (addressID == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Stinky clowns";
                address.StreetLine2 = "5";
                address.City = "Ankh-Morpork";
                address.State = "The Shades";
                address.Country = "Discworld";
                address.PostalCode = "444"; 
            }

            return address;
        }
        public IEnumerable<Address> RetrieveByCustomerID(int customerID)
        {
            //Temporary values to return
            var addressList = new List<Address>();
            Address address1 = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Stinky clowns",
                StreetLine2 = "5",
                City = "Ankh-Morpork",
                State = "The Shades",
                Country = "Discworld",
                PostalCode = "444"
            };
            addressList.Add(address1);
            Address address2 = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Happy tree",
                StreetLine2 = "1",
                City = "Ankh-Morpork",
                State = "Isle of Gods",
                Country = "Discworld",
                PostalCode = "333"
            };
            addressList.Add(address2);
            return addressList;
        }
        // Save the current address
        public bool Save(Address address)
        {
            return true;
        }
    }
}

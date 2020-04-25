﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address
    {
        public Address()
        {

        }
        public Address(int addressId)
        {
            this.AddressID = addressId;
        }
        public int AddressID { get; set; }
        public int AddressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        
        // Validate the address data
        public bool Validate()
        {
            var isValid = true;
            if (PostalCode == null) isValid = false;
            
            return isValid;
        }


    }
}

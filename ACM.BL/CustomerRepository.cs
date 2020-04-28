using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }

        //Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            //Temporary hard-coded value to return
            if(customerId ==1)
            {
                customer.EmailAddress = "monkey@gmail.com";
                customer.FirstName = "Paul";
                customer.LastName = "Laspapos";
                customer.AddressList = addressRepository.RetrieveByCustomerID(customerId).
                                                                             ToList();
            }
            return customer;
        }

        //Retrieve all cutomers
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        //Save the current customer
        public bool Save(Customer customer)
        {

            return true;
        }
    }
}

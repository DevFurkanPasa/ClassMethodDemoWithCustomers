using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class SqlServer
    {
        public Customer[] ListOfCustomers()
        {
            Customer customer1 = new Customer();
            customer1.Id = 0;
            customer1.FirstName = "Murat";
            customer1.LastName = "TOPAL";
            customer1.Age = 56;
            customer1.PhoneNumber = "+905862486598";
            
            
            Customer customer2 = new Customer();
            customer2.Id = 1;
            customer2.FirstName = "Furkan";
            customer2.LastName = "TOPAL";
            customer2.Age = 18;
            customer2.PhoneNumber = "+905745216325";
            
            Customer customer3 = new Customer();
            customer3.Id = 2;
            customer3.FirstName = "Fatma";
            customer3.LastName = "TOPAL";
            customer3.Age = 54;
            customer3.PhoneNumber = "+9051425636987";

            Customer customer4 = new Customer();
            customer4.Id = 3;
            customer4.FirstName = "Feyza";
            customer4.LastName = "Çetin";
            customer4.Age = 28;
            customer4.PhoneNumber = "+905483659281";

            Customer[] customers = 
            {
                customer1,
                customer2,
                customer3,
                customer4
            };
            
            return customers;

        }
    }
}

using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
           IndividualCustomer customer1 = new IndividualCustomer();
           customer1.CustomerNumber = "12312123";
           customer1.Name = "Alptekin";
           customer1.LastName = "Ocakdan";
           customer1.TCNo = "123123123123";

           CorporateCustomer customer2 = new CorporateCustomer();
           customer2.Id = 2;
           customer2.CustomerNumber = "123213";
           customer2.CompanyName = "Ao";
           customer2.VergiNo = "123123";

           Customer customer3 = new IndividualCustomer();
           Customer customer4 = new CorporateCustomer();
           CustomerManager customerManager = new CustomerManager();
           customerManager.Add(customer1);
           customerManager.Add(customer2);

        }
    }
}
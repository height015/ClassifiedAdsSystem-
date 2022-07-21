using System;
namespace Core.DominLayer.Customers
{
    public class CustomerLoggedinEvent
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="customer">Customer</param>
        public CustomerLoggedinEvent(Customer customer)
        {
            Customer = customer;
        }

        /// <summary>
        /// Customer
        /// </summary>
        public Customer Customer
        {
            get;
        }
    }
}
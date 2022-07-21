using System;
namespace Core.DominLayer.Customers
{
    public class CustomerRegisteredEvent
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="customer">customer</param>
        public CustomerRegisteredEvent(Customer customer)
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
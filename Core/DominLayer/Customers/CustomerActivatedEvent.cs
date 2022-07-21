using System;
namespace Core.DominLayer.Customers
{
    public class CustomerActivatedEvent
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="customer">customer</param>
        public CustomerActivatedEvent(Customer customer)
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

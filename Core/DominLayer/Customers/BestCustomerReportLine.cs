using System;
namespace Core.DominLayer.Customers
{
	public class BestCustomerReportLine
	{
        /// <summary>
        /// Gets or sets the customer identifier
        /// </summary>
        public string CustomerId { get; set; }

        public Customer Customer { get; set; }
        /// <summary>
        /// Gets or sets the order total
        /// </summary>
        public decimal OrderTotal { get; set; }

        /// <summary>
        /// Gets or sets the order count
        /// </summary>
        public int OrderCount { get; set; }
    }
}


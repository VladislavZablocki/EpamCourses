using System.Collections.Generic;

namespace task_DEV_10
{
    /// <summary>
    /// Contains data about customer
    /// </summary>
    class Customer
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public bool OrderCompleted { get; set; }

        public List<Purchase> purchase;
    }
}

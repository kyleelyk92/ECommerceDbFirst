using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBFirst_Ecommerce_August13.Models
{
    public class CustomerManager
    {
        ECommercePracticeAug13Entities db = new ECommercePracticeAug13Entities();
        public ICollection<Customer> getCustomers(string city)
        {
            var custList = db.Customers.Where(c => c.City == city).ToList();

            return custList;
        }
    }
}
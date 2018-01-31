using DataObjects.Model;
using DataObjects.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.Repositories
{
    public class CustomerEntity : ICustomerEntity
    {
        public List<Customer> GetCustomerEntity()
        {
            using (var db = new NorthWindEntities())
            {
                return db.Customers.ToList();
            }
        }
    }
}

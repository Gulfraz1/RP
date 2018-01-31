using DataObjects.Model;
using System.Collections.Generic;

namespace DataObjects.Repositories
{
    public interface ICustomerEntity
    {
        List<Customer> GetCustomerEntity();
    }
}

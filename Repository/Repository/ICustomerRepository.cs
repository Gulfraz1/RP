using System.Collections.Generic;

namespace Repository.Repository
{
    public interface ICustomerRepository
    {
        List<CustomerDto> GetCustomer();
    }
}

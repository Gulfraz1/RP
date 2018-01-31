using System.Collections.Generic;
using DataObjects.Repositories;
using DataObjects.Model;
using AutoMapper;

namespace Repository.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ICustomerEntity _customer;
       
        //public CustomerRepository(ICustomerEntity customerRepository)
        //{
        //    _customer = customerRepository;

        //}
        public List<CustomerDto> GetCustomer()
        {
            var customer = _customer.GetCustomerEntity();
            List<CustomerDto> customerDto =  Mapper.Map<List<Customer>, List<CustomerDto>>(customer);
            return customerDto;
        }
    }
}

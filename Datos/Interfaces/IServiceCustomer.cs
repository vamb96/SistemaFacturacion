using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IServiceCustomer
    {
        public void Add(Customer customer);
        public void Update(Customer customer, int id);
        public bool Delete(int customer);
        public Customer Get(int id);
        public List<Customer> GetAll();
        public List<Customer> GetCustomers(string item);
        public List<CustomerTypes> GetCustomerTypes();
        public CustomerTypes GetCustomerType(int id);
    }
}

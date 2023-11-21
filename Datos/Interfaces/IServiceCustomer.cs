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
        public bool Delete(Customer customer);
        public Customer Get(int id);
        public List<Customer> GetAll();
    }
}

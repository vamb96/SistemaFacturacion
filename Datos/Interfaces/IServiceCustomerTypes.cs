using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IServiceCustomerTypes
    {
        public CustomerTypes Find(int id);
        public List<CustomerTypes> GetListType();
        public bool Delete(int id);
        public void Add(CustomerTypes customerType);
        public void Update(int id,CustomerTypes customerType);
        public List<CustomerTypes> GetListType(string nombre);

     
    }
}

using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IServiceInvoice
    {
        public void Add(Invoice invoice);
        public void Update(Invoice invoice, int id);
        public bool Delete(Invoice invoice);
        public Invoice Get(int id);
        public List<Invoice> GetAll();
        public Product GetProduct(int id);
        public Customer GetCustomer(int id);
    }
}

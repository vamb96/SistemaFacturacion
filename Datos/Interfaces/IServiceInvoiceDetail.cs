using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IServiceInvoiceDetail
    {
        public void Add(InvoiceDetail invoiceDetail);
        public void Update(InvoiceDetail invoiceDetail, int id);
        public bool Delete(InvoiceDetail invoiceDetail);
        public InvoiceDetail Get(int id);
        public List<InvoiceDetail> GetAll();
    }
}

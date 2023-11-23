using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalItbis { get; set; }
        public decimal SubTotal {  get; set; }
        public decimal Total {  get; set; }
        public DateTime dateTime { get; set; }
        public List<InvoiceDetail> ListDetails { get; set; }
        public Customer? Customer { get; set; }
    }
}

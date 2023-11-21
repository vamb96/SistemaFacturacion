using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class InvoiceDetail
    {
        public int id { get; set; }
        public int InvoiceId { get; set; }
        public int IdProducto { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public decimal Itebis { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public Producto producto { get; set; }
        public Invoice invoice {get; set;}
    }
}

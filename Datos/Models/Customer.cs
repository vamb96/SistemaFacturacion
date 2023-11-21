using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustName { get; set; }
        public string Adress { get; set; }
        public string Status { get; set; }
        public bool IsActivo { get; set; }
        public int CustomerTypeId { get; set; }
        public CustomerTypes CustomerType { get; set; }
        public List<Invoice> invoice { get; set;}
        

    }
}

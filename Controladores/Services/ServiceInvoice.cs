using Datos.ConexionDB;
using Datos.Interfaces;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores.Services
{
    public class ServiceInvoice : IServiceInvoice
    {
        private MyContext _context;

        public ServiceInvoice(string stringConexion)
        {
            _context = new MyContext(stringConexion);
        }
        public void Add(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            _context.SaveChanges();
        }

        public bool Delete(Invoice invoice)
        {
            Invoice invoice1 = _context.Invoices.FirstOrDefault(x =>  x.Id == invoice.Id);
            if (invoice1 != null)
            {
                _context.Invoices.Remove(invoice1);
                _context.SaveChanges();
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public Invoice Get(int id)
        {
            Invoice invoice = _context.Invoices.FirstOrDefault(x => x.Id == id);
            return invoice;
        }

        public List<Invoice> GetAll()
        {
            return _context.Invoices.ToList();
        }

        public void Update(Invoice invoice, int id)
        {
            Invoice invoice1 = _context.Invoices.FirstOrDefault(x => x.Id == id);
            if (invoice1 != null)
            {
                invoice1.CustomerId = invoice.CustomerId;
                invoice1.TotalItbis = invoice.TotalItbis;
                invoice1.SubTotal = invoice.SubTotal;
                invoice1.Total = invoice.Total;
                invoice1.dateTime = invoice.dateTime;
            }
        }

        public List<Product> GetProducts(string Name)
        {
            List<Product> listProduct = _context.Productos.Where(x => x.Description.Contains(Name)).ToList();
                return listProduct;
        }

        public Customer GetCustomerId(int id)
        {
            Customer customer = _context.Customers.FirstOrDefault(x => x.Id == id);
            return customer;
        }

        public List<Customer> GetCustomerName(string name)
        {
            List<Customer> listCustomers = _context.Customers.Where(p => p.CustName.Contains(name)).ToList();
            return listCustomers;
        }
        public List<Customer> GetCustomerAll()
        {
            return _context.Customers.ToList();
        }

        public List<Product> GetProductAll()
        {
            return _context.Productos.ToList();
        }

        public Product GetProductId(int id)
        {
            return _context.Productos.FirstOrDefault(x => x.Id == id);
        }
    }
}

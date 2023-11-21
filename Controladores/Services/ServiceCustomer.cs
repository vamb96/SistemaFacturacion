using Datos.ConexionDB;
using Datos.Interfaces;
using Datos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores.Services
{
    public class ServiceCustomer : IServiceCustomer
    {
        private MyContext _context;
        public ServiceCustomer(string stringConexion)
        {
                _context = new MyContext(stringConexion);
        }
        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public bool Delete(Customer customer)
        {
            Customer _customer = _context.Customers.FirstOrDefault(x => x.Id == customer.Id);
            if (_customer != null)
            {
                _context.Customers.Remove(_customer);
                _context.SaveChanges();
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public Customer Get(int id)
        {
            Customer customer = _context.Customers.FirstOrDefault(t => t.Id == id);
            return customer;
        }

        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public void Update(Customer customer, int id)
        {
            Customer _customer = _context.Customers.FirstOrDefault(t => t.Id == id);

            if (_customer != null)
            {
                _customer.Id = customer.Id;
                _customer.CustName = customer.CustName;
                _customer.Adress = customer.Adress;
                _customer.Status = customer.Status;
                _customer.IsActivo = customer.IsActivo;
                _customer.CustomerTypeId = customer.CustomerTypeId;
                _context.Entry(_customer).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}

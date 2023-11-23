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
    public class ServiceCustomerType : IServiceCustomerTypes
    {
        MyContext _context;
        public ServiceCustomerType(string stringConexion)
        {
            _context = new MyContext(stringConexion);
        }
        public void Add(CustomerTypes customerType)
        {
            _context.CustomerTypes.Add(customerType);
            _context.SaveChanges();
        }

        public bool Delete(int id)
        {
            CustomerTypes type = Find(id);
            if (type != null)
            {
                _context.CustomerTypes.Remove(type);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public CustomerTypes Find(int id)
        {
            CustomerTypes type = _context.CustomerTypes.Find(id);
            return type;
        }

        public List<CustomerTypes> GetListType(string nombre)
        {
            return _context.CustomerTypes.Where(x => x.Description.Contains(nombre)).ToList();
        }

        public List<CustomerTypes> GetListType()
        {
            return _context.CustomerTypes.ToList();
        }

        public void Update(int id ,CustomerTypes customerType)
        {
            CustomerTypes type = Find(id);
            if (type != null)
            {
                type.Description = customerType.Description;

                _context.Entry(type).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

    }
}

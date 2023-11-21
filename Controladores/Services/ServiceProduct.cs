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
    public class ServiceProduct : IServiceProduct
    {
        private MyContext _context;
        public ServiceProduct(string stringConexion)
        {
            _context = new MyContext(stringConexion);
        }
        public void Add(Product product)
        {
            _context.Productos.Add(product);
            _context.SaveChanges();
        }

        public bool Delete(Product product)
        {
            Product product1 = _context.Productos.FirstOrDefault(x => x.Id == product.Id);
            if (product1 != null)
            {
                _context.Productos.Remove(product1);
                _context.SaveChanges();
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public Product Get(int id)
        {
            Product product1 = _context.Productos.FirstOrDefault(x => x.Id == id);
            return product1;
        }

        public List<Product> GetAll()
        {
            return _context.Productos.ToList();
        }

        public void Update(Product product, int id)
        {
            Product product1 = _context.Productos.FirstOrDefault(x => x.Id == id);
            if (product1 != null) 
            { 
                product1.Description = product.Description;
                product1.IsActivo = product.IsActivo;
                _context.Entry(product1).State = EntityState.Modified;
                _context.SaveChanges();

            }
        }
    }
}

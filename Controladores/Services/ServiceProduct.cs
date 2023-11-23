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

        public bool Delete(int Id)
        {
            Product product1 = _context.Productos.FirstOrDefault(x => x.Id == Id);
            if (product1 != null)
            {
                _context.Productos.Remove(product1);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public Product GetProductById(int id)
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
                product1.Price = product.Price;
                product1.IsActivo = product.IsActivo;
                _context.Entry(product1).State = EntityState.Modified;
                _context.SaveChanges();

            }
        }

        public List<Product> GetProducts(string nombre)
        {
            List<Product> listProducts = _context.Productos
        .Where(p => p.Description.Contains(nombre))
        .ToList();

            return listProducts;
        }

        public Product GetProductByDescription(string description)
        {
            return _context.Productos.FirstOrDefault(x => x.Description.ToLower() == description.ToLower());
        }
    }
}

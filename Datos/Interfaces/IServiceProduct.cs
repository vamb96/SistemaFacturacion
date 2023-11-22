using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IServiceProduct
    {
        public void Add(Product product);
        public void Update(Product product, int id);
        public bool Delete(int Id);
        public Product Get(int id);
        public List<Product> GetAll();
        List<Product> GetProducts(string text);
    }
}

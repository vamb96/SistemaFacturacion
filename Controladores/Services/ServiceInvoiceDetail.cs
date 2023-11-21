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
    public class ServiceInvoiceDetail : IServiceInvoiceDetail
    {
        private MyContext _context;
        public ServiceInvoiceDetail(string stringConexion)
        {
            _context = new MyContext(stringConexion);
        }
        public void Add(InvoiceDetail invoiceDetail)
        {
            _context.InvoicesDetail.Add(invoiceDetail);
            _context.SaveChanges();
        }

        public bool Delete(InvoiceDetail invoiceDetail)
        {
            InvoiceDetail _invoiceDetail = _context.InvoicesDetail.FirstOrDefault(x => x.id == invoiceDetail.id);
            if (_invoiceDetail != null)
            {
                _context.InvoicesDetail.Remove(invoiceDetail);
                _context.SaveChanges();
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public InvoiceDetail Get(int id)
        {
            InvoiceDetail invoiceDetail = _context.InvoicesDetail.FirstOrDefault(x  => x.id == id);
            return invoiceDetail;
        }

        public List<InvoiceDetail> GetAll()
        {
            return _context.InvoicesDetail.ToList();
        }

        public void Update(InvoiceDetail invoiceDetail, int id)
        {
            InvoiceDetail invoiceDetail1 = _context.InvoicesDetail.FirstOrDefault(x => x.id == id);
            if (invoiceDetail1 != null)
            {
                invoiceDetail1.IdProducto = invoiceDetail.IdProducto;
                invoiceDetail1.Qty = invoiceDetail.Qty;
                invoiceDetail1.Price = invoiceDetail.Price;
                invoiceDetail1.Itebis = invoiceDetail.Itebis;
                invoiceDetail1.SubTotal = invoiceDetail.SubTotal;
                invoiceDetail1.Total = invoiceDetail.Total;

                _context.Entry(invoiceDetail1).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}

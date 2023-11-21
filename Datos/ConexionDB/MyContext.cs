﻿using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ConexionDB
{
    public class MyContext : DbContext
    {
        private readonly string _conString;
        public MyContext(string stringConexion)
        {
            _conString = stringConexion;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_conString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Invoice>().Property(i => i.TotalItbis).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Invoice>().Property(i => i.SubTotal).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Invoice>().Property(i => i.Total).HasColumnType("decimal(18,4)");

            modelBuilder.Entity<InvoiceDetail>().Property(i => i.Price).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<InvoiceDetail>().Property(i => i.SubTotal).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<InvoiceDetail>().Property(i => i.Total).HasColumnType("decimal(18,4)");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoicesDetail { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<CustomerTypes> CustomerTypes { get; set; }

    }

}

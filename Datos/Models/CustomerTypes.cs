﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class CustomerTypes
    {
        public int Id { get; set; }
        public string Description { get; set; }
        List<Customer> customers {  get; set; }

    }
}

﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories.Products
{
    public interface IProductWriteRepository:IWriteRepository<Product>
    {
    }
}

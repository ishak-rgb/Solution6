using Application.Context;
using Application.Interfaces.Repositories.Categories;
using Application.Interfaces.Repositories.Products;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories.Categories;
using Persistence.Repositories.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class ServicesRegistrition
    {
        public static void AddRegistration(this IServiceCollection collection)
        {
            collection.AddScoped<IProductReadRepository, ProductReadRepository>();
            collection.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            collection.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            collection.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
           
            collection.AddSingleton<ETicaretDbsContext>();
        }

    }
}

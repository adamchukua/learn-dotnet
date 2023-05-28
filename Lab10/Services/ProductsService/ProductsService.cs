using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;
using System;
using System.Data;
using System.Net.Mime;
using Lab6.Models;
using Lab6.Services.ProductsService;
using Microsoft.Data.SqlClient;

namespace Lab6.Services.ProductsService
{
    public class ProductsService : IProductsService
    {
        private readonly ShopContext _context;

        public ProductsService (ShopContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> Get()
        {
            return await Task.FromResult(_context.Products
                .ToList());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Lab6.Models;

public class ShopContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public ShopContext(DbContextOptions<ShopContext> options) : base(options)
    {
    }
}
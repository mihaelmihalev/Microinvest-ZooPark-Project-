using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{ 
public class CategoryDbContext : Microsoft.EntityFrameworkCore.DbContext
{


    public CategoryDbContext()
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to mysql with connection string from app settings

        options.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=ZooPark;Integrated Security=True");
    }
    public Microsoft.EntityFrameworkCore.DbSet<Category> Categories { get; set; }
}
}
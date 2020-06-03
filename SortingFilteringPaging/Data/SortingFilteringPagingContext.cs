using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SortingFilteringPaging.Models;

namespace SortingFilteringPaging.Data
{
    public class SortingFilteringPagingContext : DbContext
    {
        public SortingFilteringPagingContext (DbContextOptions<SortingFilteringPagingContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
    }
}

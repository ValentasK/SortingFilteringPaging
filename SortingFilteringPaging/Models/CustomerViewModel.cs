using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingFilteringPaging.Models
{
    public class CustomerViewModel
    {
        public int SkipValue { get; set; }
        public int ItemsPerPage { get; set; }
        public string SearchString { get; set; }
        public string Sorting { get; set; }
        public int AllRecords { get; set; }
        public bool LastPage { get; set; }
        public bool FirsPage { get; set; }

        public List<Customer> Customers { get; set; }
    }
}

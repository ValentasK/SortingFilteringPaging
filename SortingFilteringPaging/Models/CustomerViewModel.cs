using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingFilteringPaging.Models
{
    public class CustomerViewModel
    {
        public int SkipValue { get; set; } // indicates how many records has to be skipped from the database
        public int ItemsPerPage { get; set; } // indicates how many records have to be taken from database
        public string SearchString { get; set; } // search string 
        public string Sorting { get; set; } // value could be: by name, surname, age, atc...
        public int AllRecords { get; set; } // indicates how many records are in database, if search String is applied
                                            // then it will indicate how many records matched that search String 
        public bool LastPage { get; set; } // if true - it is last page
        public bool FirsPage { get; set; } // if true = it is first page

        public List<Customer> Customers { get; set; } // list of records to be sent to 
    }
}

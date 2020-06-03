using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SortingFilteringPaging.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string  FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(6)]
        public string MaleFemale { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        [MaxLength(50)]
        public string EmailAddress { get; set; }
        [Required]
        [MaxLength(50)]
        public string City { get; set; }
        [Required]
        [MaxLength(50)]
        public string Street { get; set; }
        [Required]
        [MaxLength(5)]
        public string HouseNr { get; set; }
    }
}

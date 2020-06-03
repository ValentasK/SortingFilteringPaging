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
        [Required(ErrorMessage = "First name is required")]
        [MaxLength(50)]
        public string  FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Gender is required")]
        [MaxLength(6)]
        public string MaleFemale { get; set; }
        [Required]
        [Range(16,110, ErrorMessage ="Age must be between 16 and 110")]
        public int Age { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.EmailAddress,ErrorMessage ="Email Address is required")]
        public string EmailAddress { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage ="City is required")]
        public string City { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Street is required")]
        public string Street { get; set; }
        [Required]
        [MaxLength(6, ErrorMessage = "House number is required")]
        public string HouseNr { get; set; }
    }
}

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
        [Required(ErrorMessage ="Age is requires")]
        [Range(16,110, ErrorMessage ="Age must be between 16 and 110")]
        public int Age { get; set; }
        [Required(ErrorMessage ="Phone number is required")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Email address is required")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "City is required")]
        [MaxLength(50)]
        public string City { get; set; }
        [Required(ErrorMessage = "Street is required")]
        [MaxLength(50)]
        public string Street { get; set; }
        [Required(ErrorMessage = "House number is required")]
        [MaxLength(6)]
        public string HouseNr { get; set; }
    }
}

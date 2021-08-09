using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerCrudApp.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Display(Name = "First Name"),RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name"),RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required]
        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }

        [Display(Name = "Date Of Birth"), DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string City { get; set; }

        public string Comment { get; set; }

    }
}

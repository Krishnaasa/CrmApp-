using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="First name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Age name is required")]
        public int Age { get; set; }
        [Required(ErrorMessage = "City name is required")]
        public string City { get; set; }
    }
}

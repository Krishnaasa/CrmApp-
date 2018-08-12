using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CrmApp.Models
{
    public class Customer
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Age name is required")]
        public int Age { get; set; }
        [ForeignKey("Cities")]
        //[Required(ErrorMessage = "City name is required")]
        public string City { get; set; }

        public virtual Cities Cities { get; set; }
    }
}
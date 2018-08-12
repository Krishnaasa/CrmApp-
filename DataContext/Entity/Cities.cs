using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext.Entity
{
    public class Cities
    {
        [Required(ErrorMessage = "First name is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string City { get; set; }
    }
}

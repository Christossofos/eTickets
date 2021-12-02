using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }
        
        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Cinema's name is required")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Cinema's name must be between 3-80 characters")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }

        // Relationships
        public virtual List<Movie> Movies { get; set; }
    }
}

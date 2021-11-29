using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Ratings
    {
        [Key]
        public int Id { get; set; }

        public int MovieForeignKey { get; set; }
       
        [ForeignKey("MovieForeignKey")]
        public Movie MovieId { get; set; }

        // The user after authentication
        public string User { get; set; }

        [DefaultValue(0f)]
        public float Rating { get; set; }

    }
}

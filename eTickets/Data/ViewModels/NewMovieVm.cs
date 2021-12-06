using eTickets.Data;
using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class NewMovieVm
    {
        public int Id { get; set; }

        [Display(Name = "Movie name")]
        [Required(ErrorMessage = "Name is REQUIRED!")]
        public string Name { get; set; }

        [Display(Name = "Movie description")]
        [Required(ErrorMessage = "Description is REQUIRED!")]
        public string Description { get; set; }

        [Display(Name = "Movie price")]
        [Required(ErrorMessage = "Price is REQUIRED!")]
        public float Price { get; set; }

        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Movie poster URL is REQUIRED!")]
        public string ImageURL { get; set; }

        [Display(Name = "Movie start date")]
        [Required(ErrorMessage = "Start Date is REQUIRED!")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie end date")]
        [Required(ErrorMessage = "End Date is REQUIRED!")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Movie Category is REQUIRED!")]
        public MovieCategory MovieCategory { get; set; }
        //public float Rating { get; set; }

        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "Movie actor(s) is REQUIRED!")]
        // Relationships
        public List<int> ActorIds { get; set; }

        [Display(Name = "Select cinema")]
        [Required(ErrorMessage = "Cinema is REQUIRED!")]
        // Cinema
        public int CinemaId { get; set; }

        [Display(Name = "Select director")]
        [Required(ErrorMessage = "Director is REQUIRED!")]
        // Director
        public int DirectorId { get; set; }

    }
}

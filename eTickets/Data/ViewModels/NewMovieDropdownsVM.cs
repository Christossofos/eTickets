using eTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.ViewModels
{
    public class NewMovieDropdownsVM
    {
        public List<Director> Directors { get; set; }

        public List<Cinema> Cinemas { get; set; }

        public List<Actor> Actors { get; set; }

        public NewMovieDropdownsVM()
        {
            Directors = new List<Director>();
            Cinemas = new List<Cinema>();
            Actors = new List<Actor>();
        }
    }
}

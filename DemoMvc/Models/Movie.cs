using System.ComponentModel.DataAnnotations;

namespace DemoMvc.Models
{
    public class Movie
    {
        [Display (Name ="Movie id")]
        public int Id { get; set; } 
        public string Title { get; set; }
        public int Year { get; set; }   
        public int Rating { get; set; } 

    }
}

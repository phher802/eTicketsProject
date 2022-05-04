using eTickets.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        [Display(Name = "Image")]
        public string?  ImageURL { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Genre")]
        public MovieCategory MovieCategory { get; set; }

        //relationship
        public List<Actor_Movie>? Actors_Movies { get; set; }
        //cinema
        [ForeignKey("CinemaID")]
        public int CinemaID { get; set; }
        public Cinema? Cinema { get; set; }
       

        [ForeignKey("ProducerID")]
        public int ProducerID { get; set; }
        public Producer? Producer { get; set; }

    }
}

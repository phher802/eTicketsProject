﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Cinema Logo")]
        public string? Logo { get; set; }
        [Display(Name="Cinema Name")]
        public string? Name { get; set; }
        public string? Description { get; set; }

        //relationship
        public List<Movie>? Movies { get; set; }


    }
}

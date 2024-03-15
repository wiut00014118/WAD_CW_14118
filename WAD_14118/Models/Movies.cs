﻿using System.ComponentModel.DataAnnotations;

namespace WAD_14118.Models
{
    public class Movies
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength =3)]
        public string Title { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Required]
        public decimal Rating { get; set; }

        [Required]
        [DataType(DataType.Url)]
        [Display(Name = "ImDB Link")]
        public string ImdbUrl { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Poster")]
        public string ImageUrl { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace AustinBandDatabase.Models
{
    public class Band
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Year Formed"), Required]
        public string YearFormed { get; set; }

        [Display(Name = "Description"), Required]
        public string DescriptionHtml { get; set; }

        public Band()
        {}

        public Band(int id, string name, string yearFormed, string descriptionHtml)
        {
            Id = id;
            Name = name;
            YearFormed = yearFormed;
            DescriptionHtml = descriptionHtml;
        }
    }
}
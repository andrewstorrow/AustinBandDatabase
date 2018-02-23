using System;
using System.ComponentModel.DataAnnotations;

namespace AustinBandDatabase.Models
{
    public class Band
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Year Formed")]
        public string YearFormed { get; set; }

        [Display(Name = "Description")]
        public string DescriptionHtml { get; set; }
    }
}
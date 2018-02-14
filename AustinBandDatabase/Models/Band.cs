using System;
using System.ComponentModel.DataAnnotations;

namespace AustinBandDatabase.Models
{
    public class Band
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Year Formed"), DataType(DataType.Date)]
        public DateTime YearFormed { get; set; }

        public string DescriptionHtml { get; set; }
    }
}
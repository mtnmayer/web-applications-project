using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelMe.Models
{
    public class Place
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; } //Coordinates
        public float? AvgRating { get; set; }
        [Required]
        public int NumOfPosts { get; set; }
    }
}

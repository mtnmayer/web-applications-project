using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelMe.Models
{
    public class Comment
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public int PostID { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Post Post { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YourTube.Models
{
    public class Page
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        [Required]
        public Channel Channel { get; set; }
        [Required]
        public string HtmlContent { get; set; }
    }
}

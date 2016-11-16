using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OurTravelBlog.Models
{
    [Table ("Locations")]
    public class Location
    {
       [Key]
        public int id { get; set; }
        public string City { get; set; }
    }
}

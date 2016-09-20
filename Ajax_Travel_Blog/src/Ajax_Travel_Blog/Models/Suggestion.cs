using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ajax_Travel_Blog.Models
{
    [Table("Suggestions")]
    public class Suggestion
    {
        [Key]
        public int Id { get; set; }
        public string Place { get; set; }
        public string Description { get; set; }
        public Suggestion(string place, string description, int id = 0)
        {
            Place = place;
            Description = description;
            Id = id;
        }
        public Suggestion() { }
    }
}

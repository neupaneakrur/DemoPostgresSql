using System.ComponentModel.DataAnnotations;

namespace DemoPostgresSql.Data.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Genre { get; set; }
    }
}

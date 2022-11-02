using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Itemname { get; set; }

        [Required]
        public int Price { get; set; }
    }
}


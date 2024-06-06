using System.ComponentModel.DataAnnotations;

namespace Proove_of_concept.Domaines.Entities
{
    public class Produit
    {
        public int Id { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string ?Nom { get; set; }
        [Required]
        public decimal Prix { get; set; }
    }
}

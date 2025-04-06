using System.ComponentModel.DataAnnotations;

namespace BookShoppingCartMvcUI.Models.DTOs
{
    public class GenreDTO
    {
        public int  Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string GenreName { get; set; }
    }
}

﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCartMvcUI.Models
{
    [Table("Book")]
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public String ?BookName { get; set; }
        [Required]
        [MaxLength(40)]
        public String ?AuthorName { get; set; }
        [Required]
        public double Price { get; set; }
        public string?Image { get; set; }
        [Required]
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public List<OrderDetail> OrderDetail{ get; set; }
        public List<CartDetail> CartDetail { get; set; }
        [NotMapped]
        public string GenreName { get; set; }

        public Stock Stock { get; set; }
        [NotMapped]
        public int Quantity { get; set; }
    }
}

﻿using P328Pustok.Attributes.ValidationAttributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P328Pustok.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public int GenreId { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Desc { get; set; }
        [Column(TypeName = "money")]
        public decimal SalePrice { get; set; }
        [Column(TypeName = "money")]
        public decimal CostPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal DiscountPercent { get; set; }
        [Required]
        public bool StockStatus { get; set; }
        [Required]
        public bool IsFeatured { get; set; }
        [Required]
        public bool IsNew { get; set; }
        [MaxFileSize(2097152)]
        [AllowedFileTypes("image/jpeg", "image/png")]
        [NotMapped]
        public IFormFile PosterImage { get; set; }
        [MaxFileSize(2097152)]
        [AllowedFileTypes("image/jpeg", "image/png")]
        [NotMapped]
        public IFormFile HoverPosterImage { get; set; }
        [NotMapped]
        [MaxFileSize(2097152)]
        [AllowedFileTypes("image/jpeg", "image/png")]
        public List<IFormFile> Images { get; set; } = new List<IFormFile>();


        public Genre Genre { get; set; }
        public Author Author { get; set; }
        public List<BookImage> BookImages { get; set; } = new List<BookImage>();
        public List<BookTag> BookTags { get; set; }
    }
}

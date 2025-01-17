﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Marcu_Andreea_Cosmina_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]

        public string Title { get; set; }
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }
    }

    public static List<Book> GetInitialBooks()
    {
        return new List<Book>
        {
            new Books { Id = 1, Title = "Cartea 1", PublisherId = 1 },
            new Books { Id = 2, Title = "Cartea 2", PublisherId = 2 }
        };
    }
}

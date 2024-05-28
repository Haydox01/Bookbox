﻿using Bookbox.BaseClass;
using System.ComponentModel.DataAnnotations;

namespace Bookbox.Models
{
    public class Book : BaseEntity
    {
        
        public string Title { get; set; }
        public Double Price { get; set; } //Research if Double is the right DataType
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string AuthorName { get; set; }
        public Guid AuthorId { get; set; }
        public string ? ISBN { get; set; }
       

        //nav Properties

        public Category Category { get; set; }
        public Author Author { get; set; }

    }
}

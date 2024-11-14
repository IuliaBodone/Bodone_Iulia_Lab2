﻿namespace Bodone_Iulia_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public required string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}

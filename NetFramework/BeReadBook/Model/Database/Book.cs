﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Database
{
    public class Book
    {
        public int Id { get; set; }
        public string Guid { get; set; } = System.Guid.NewGuid().ToString("D");
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}

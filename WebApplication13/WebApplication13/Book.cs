﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication13
{
    public class Book
    {
        int Id { get; set; }
        int IdAuthor { get; set; }
        string Name { get; set; }
        public Book(int id, int idauthor, string name)
        {
            Id = id;
            IdAuthor = idauthor;
            Name = name;
        }
    }


}

using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Client
{
    public class Book
        : IBook
    {
        public Book(
            string title)
        {
            Title = title;
        }

        public string Title { get; }
    }
}

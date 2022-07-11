using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Client
{
    public class GetBook
        : IGetBook
    {
        public GetBook(
            IBook book)
        {
            Book = book;
        }

        public IBook Book { get; }
    }
}

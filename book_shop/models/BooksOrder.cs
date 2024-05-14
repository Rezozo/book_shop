using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_shop.models
{
    public class BooksOrder
    {
        public Books Books { get; set; }
        public int Quantity { get; set; }
        public BooksOrder() { }
    }
}

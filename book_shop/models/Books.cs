using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_shop.models
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Cost { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }

        public Books() { }
    }
}

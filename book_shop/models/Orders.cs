using System;
using System.Collections.Generic;

namespace book_shop.models
{
    public  class Orders
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }
        public User user { get; set; }  
        public List<BooksOrder> Books { get; set; }
        public Orders() { }
    }
}

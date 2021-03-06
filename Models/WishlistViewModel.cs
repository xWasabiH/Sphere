using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using Microsoft.Extensions.Logging;
using System.IO;

namespace project5_6.Models
{
    public class Wishlist
    {
        public int Id { get; set; }
        public string user_id { get; set; }
        public int product_id { get; set; }
        public string brand { get; set; }
        public string model_name { get; set; }
        public string description { get; set; }
        public int price { get; set; }

    }
}
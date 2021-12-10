using Eshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191183_Buoi2.Models
{
    public class Comment
    {
        public string Id{ get; set; }
        public string Username { get; set; }
        public Account Account { get; set; }
        public  DateTime WriteDate { get; set; }
        public string Content { get; set; }

        public int PostId { get; set; }
        public Post Posts { get; set; }


    }
}

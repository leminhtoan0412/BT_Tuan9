using Eshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191183_Buoi2.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int Name { get; set; }

        public string Content { get; set; }
        public DateTime WriteDate { get; set; }
        public string AccountID { get; set; }
        public Account Accounts { get; set; }
        public int PostTopicId { get; set; }
        public PostTopic Topic { get; set; }
        public bool status { get; set; }
        public List<Comment> Comments { get; set; }

    }
}

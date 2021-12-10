using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191183_Buoi2.Models
{
    public class PostTopic
    {
        public int Id { get; set; }
        public string  TopicName { get; set; }
        public bool Status { get; set; }
        public List<Post> Post { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using _0306191183_Buoi2.Models;

namespace Eshop.Models
{
    public class Account
    {
        public int Id { get; set; }

       
        public string Username { get; set; }

        
        public string Password { get; set; }

       
        public string Email { get; set; }

        public string Phone { get; set; }

      
        public string Address { get; set; }

       
        public string FullName { get; set; }

      
        public bool IsAdmin { get; set; } = true;
        public bool Status { get; set; }

        public List<Post> Posts { get; set; }
        public List<Comment > Comments { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThisIsAChat.Models
{
    public class Message
    {
        public int ID { get; set; }
        public DateTime DateTimePosted { get; set; }
        public string Text { get; set; }
    }
}
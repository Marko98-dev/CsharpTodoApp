using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TODOApp.Models
{
    public class ToDo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TodoId { get; set; }
        private int NextId = 1;

        public ToDo() 
        {
            TodoId = NextId;
            NextId++;
        }
    }
}
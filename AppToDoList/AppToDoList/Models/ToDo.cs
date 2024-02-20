using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppToDoList.Models
{


    public class ToDo
    {
        public string name { get; set; }
        public int categoryId { get; set; }
        public int userId { get; set; }
        public Work[] works { get; set; }
    }

    public class Work
    {
        public string title { get; set; }
        public string description { get; set; }
        public bool done { get; set; }
    }


}

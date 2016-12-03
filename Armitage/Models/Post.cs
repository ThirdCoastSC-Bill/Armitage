using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Armitage.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime PublishedOn { get; set; }

        public virtual Category Category { get; set; }
    }
}
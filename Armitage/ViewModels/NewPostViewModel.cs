using Armitage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Armitage.ViewModels
{
    public class NewPostViewModel
    {
        public ICollection<Category>Categories { get; set; }

        public Post Post { get; set; }


    }
}
using Armitage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Armitage.ViewModels
{
    public class ManageTagsViewModel
    {
        public IEnumerable<Tag> Tags { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }


    }
}
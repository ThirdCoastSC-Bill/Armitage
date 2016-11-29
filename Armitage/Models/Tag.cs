using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Armitage.Models
{
    public class Tag
    {
        private ApplicationDbContext _context;

        public int TagId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }

        public ICollection<Post> Posts { get; set; }

        public Tag()
        {
            _context = new ApplicationDbContext();
        }


        /// <summary>
        /// Checks to see if this already exists in the database
        /// </summary>
        /// <returns>bool</returns>
        private bool CheckForDuplicates()
        {
            
            bool result = _context.Tags.Any(tag => tag.Name.Equals(this.Name));
            return result;
        }

        /// <summary>
        /// Validates a tag and adds to database.
        /// </summary>
        /// <returns>bool</returns>
        public bool AddTag()
        {
            if (this.CheckForDuplicates() == false && this.Name.Length > 0)
            {
                _context.Tags.Add(this);
                _context.SaveChanges();
                return true;
            }else
            {
                return false;
            }
            
        }


    }
}
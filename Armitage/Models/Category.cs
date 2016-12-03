using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Armitage.Models
{
    public class Category
    {
        private ApplicationDbContext _context;

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<Post> Posts { get; set; }


        public Category()
        {
            _context = new ApplicationDbContext();
        }

        /// <summary>
        /// Checks for duplicates
        /// </summary>
        /// <returns>bool</returns>

        private bool CheckForDuplicates()
        {

            bool result = _context.Categories.Any(tag => tag.Name.Equals(this.Name));
            return result;
        }

        /// <summary>
        /// Validates a tag and adds to database.
        /// </summary>
        /// <returns>bool</returns>
        public bool AddCategory()
        {
            if (this.CheckForDuplicates() == false && this.Name.Length > 0)
            {
                _context.Categories.Add(this);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
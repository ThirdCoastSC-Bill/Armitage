using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Armitage.Models
{
    public class HouseKeeping
    {
        private ApplicationDbContext _context;

        public HouseKeeping()
        {
            _context = new ApplicationDbContext();
        }


        public bool clearMetaTable(string table)
        {
            _context.Database.ExecuteSqlCommand($"DELETE FROM {table}");

            if (_context.Categories.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
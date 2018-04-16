using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEF.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<Movies> Movies { get; set; }
    }
}

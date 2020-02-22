using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options)
         : base(options)
        { }
    }
}

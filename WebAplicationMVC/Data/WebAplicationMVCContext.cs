using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAplicationMVC.Models;

namespace WebAplicationMVC.Data
{
    public class WebAplicationMVCContext : DbContext
    {
        public WebAplicationMVCContext (DbContextOptions<WebAplicationMVCContext> options)
            : base(options)
        {
        }

        public DbSet<WebAplicationMVC.Models.Department> Department { get; set; } = default!;
    }
}

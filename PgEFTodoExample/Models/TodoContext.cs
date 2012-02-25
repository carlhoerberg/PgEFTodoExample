using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PgEFTodoExample.Models
{
    public class TodoContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
    }
}
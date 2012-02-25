using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PgEFTodoExample.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Done { get; set; }
    }
}
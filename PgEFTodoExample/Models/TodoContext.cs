using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.Common;

namespace PgEFTodoExample.Models
{
    public class TodoContext : DbContext
    {
        private static DbConnection CreateConnection()
        {
            var uriString = ConfigurationManager.AppSettings["CLOUDPOSTGRES_URL"] ?? ConfigurationManager.AppSettings["LOCAL_URL"];
            var uri = new Uri(uriString);
            var db = uri.AbsolutePath.Trim('/');
            var user = uri.UserInfo.Split(':')[0];
            var passwd = uri.UserInfo.Split(':')[1];
            var connStr = string.Format("Server={0};Database={1};User Id={2};Password={3}", uri.Host, db, user, passwd);
            return new Npgsql.NpgsqlConnection(connStr);
        }

        public TodoContext() : base(CreateConnection(), true) { }
        public DbSet<Task> Tasks { get; set; }
    }
}
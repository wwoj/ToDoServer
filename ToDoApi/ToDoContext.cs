using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ToDoDataAccess.Models;

namespace ToDoDataAccess
{
    public class ToDoContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-47LTS4F\SQLEXPRESS;Initial Catalog=ToDoApi;Integrated Security=True");
        }
    }
}
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Context
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
            // add default values here =D
        }

        public DbSet<TodoItem> TodoItems { get; set; }

    }
}

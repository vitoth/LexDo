using Microsoft.EntityFrameworkCore;
using LexDo.Models;

namespace LexDo.Data
{
    public class ReminderContext : DbContext
    {
        public ReminderContext(DbContextOptions<ReminderContext> options)
            : base(options)
        {
        }

        public DbSet<Reminder> Reminder { get; set; }
    }
}
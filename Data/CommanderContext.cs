using ProjectCommander.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectCommander.Data
{

    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
            
        }

        public DbSet<Command> Commands { get; set; }

    }
}
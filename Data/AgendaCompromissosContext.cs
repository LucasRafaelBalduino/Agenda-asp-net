using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AgendaCompromissos.Models
{
    public class AgendaCompromissosContext : DbContext
    {
        public AgendaCompromissosContext (DbContextOptions<AgendaCompromissosContext> options)
            : base(options)
        {
        }

        public DbSet<AgendaCompromissos.Models.Contact> Contact { get; set; }
    }
}
